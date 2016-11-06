using The.Apps.Game.Core.Data.Database.Queries;
using System.Linq;
using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Core.Services.Results;
using The.Apps.Game.Core.Resources;
using The.Apps.Game.Core.Extensions;
using System;
using The.Apps.Game.Core.Logger;
using The.Apps.Game.Core.Services.Abstract;
using System.Threading;
using The.Apps.Game.Core.Data.Database;
using The.Apps.Game.Core.Data.Repositories;

namespace The.Apps.Game.Core.Services.Users
{
    public class UserService : IUserService
    {
        private IRepository<User> _userRepository;
        private IRepository<UserAddress> _userAddressRepository;
        private IRepository<UserDetail> _userDetailRepository;
        private IRepository<UserPersonal> _userPersonalRepository;
        private ICryptoService _cryptoService;
        private IUnitOfWork _unitOfWork;
        public UserService(
            IRepository<User> userRepository,
            IRepository<UserAddress> userAddressRepository,
            IRepository<UserDetail> userDetailRepository,
            IRepository<UserPersonal> userPersonalRepository,
            IUnitOfWork unitOfWork,
            ICryptoService cryptoService)
        {
            _userRepository = userRepository;
            _userAddressRepository = userAddressRepository;
            _userDetailRepository = userDetailRepository;
            _userPersonalRepository = userPersonalRepository;
            _cryptoService = cryptoService;
            _unitOfWork = unitOfWork;
        }
        public OperationResult<User> Get(string name)
        {
            try
            {
                var result = _userRepository.Read(u => u.Name == name).SingleOrDefault();
                if (result == null)
                {
                    return new OperationResult<User>(OperationResultType.NotFound, null,
                        ServicesMessages.User_NotFound.FormatSafe(name));
                }
                return new OperationResult<User>(OperationResultType.Success, result);
            }
            catch(Exception exception)
            {
                Log.Error("Cannot get user of name: " + name, exception);
                return new OperationResult<User>(OperationResultType.Error, null);
            }
        }
        public OperationResult<User> Get(int id)
        {
            try
            {
                var result = _userRepository.Read(u => u.Id == id).SingleOrDefault();
                if (result == null)
                {
                    return new OperationResult<User>(OperationResultType.NotFound, null);
                }
                return new OperationResult<User>(OperationResultType.Success, result);
            }
            catch (Exception exception)
            {
                Log.Error("Cannot get user of id: " + id, exception);
                return new OperationResult<User>(OperationResultType.Error, null);
            }
        }
        public OperationResult<User> LogIn(string name, string password)
        {
            try
            {
                User result;
                if (name.Contains("@"))
                {
                    result = _userRepository.Read(u => u.Email == name).SingleOrDefault();                    
                }
                else
                {
                    result = _userRepository.Read(u => u.Name == name).SingleOrDefault();
                }
                
                if (result == null || !_cryptoService.Verify(password, result.Password))
                {
                    return new OperationResult<User>(OperationResultType.NotFound, null,
                        ServicesMessages.User_Validation_UnknownPasswordOrUser);
                }
                return new OperationResult<User>(OperationResultType.Success, result);
            }
            catch (Exception exception)
            {
                Log.Error("Cannot login user of name: " + name, exception);
                    return new OperationResult<User>(OperationResultType.Error, null, ServicesMessages.Error_Unknown);
            }            
        }

        public OperationResult<User> Register(User model)
        {
            try
            {
                var existingUser = _userRepository.Read().FindByAny(model.Name, model.Email, model.DisplayName);
                if (existingUser != null)
                {
                    if (existingUser.Name == model.Name)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_NameAlreadyExists.FormatSafe(model.Name));
                    }
                    if (existingUser.DisplayName == model.DisplayName)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_DisplayNameAlreadyExists.FormatSafe(model.DisplayName));
                    }
                    if (existingUser.Email == model.Email)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_EmailAlreadyExists.FormatSafe(model.Email));
                    }
                    Log.Error("Unknown error during registering user of name: " + model.Name, null);
                        return new OperationResult<User>(OperationResultType.Error, null);
                }
                else
                {
                    var now = DateTime.Now;
                    var userToAdd = new User
                    {
                        Country = model.Country,
                        DisplayName = model.DisplayName,
                        Email = model.Email,
                        Name = model.Name,
                        Password = _cryptoService.Compute(model.Password, null),
                        RegisteredAt = now,
                        LastLogInAt = now,
                        Sex = model.Sex                        
                    };
                    userToAdd.UserAddress = new UserAddress { User = userToAdd };
                    userToAdd.UserDetail = new UserDetail { User = userToAdd };
                    userToAdd.UserPersonal = new UserPersonal { User = userToAdd };
                    _userRepository.Create(userToAdd);
                    _unitOfWork.Commit();
                    return new OperationResult<User>(OperationResultType.Success, userToAdd);
                }
            }
            catch (Exception exception)
            {
                var userName = model== null ? null : model.Name;
                Log.Error("Exception during registering user of name: " + userName, exception);
                    return new OperationResult<User>(OperationResultType.Error, null, ServicesMessages.Error_Unknown);
            }
        }

        public OperationResult<User> GetCurrent()
        {
            try
            {
                var principal = Thread.CurrentPrincipal;
                if (principal == null || !principal.Identity.IsAuthenticated)
                {
                    return new OperationResult<User>(OperationResultType.NotFound, null);
                }
                return Get(int.Parse(principal.Identity.Name));
            }
            catch (Exception exception)
            {
                Log.Error("Exception during getting current user", exception);
                    return new OperationResult<User>(OperationResultType.Error, null);
            }
        }

        public OperationResult<User> Edit(User model)
        {
            try
            {
                var existingUser = GetCurrent().Model;
                if (existingUser == null)
                {
                    return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_UnknownUser);
                }
                var collidingUser = _userRepository.Read().FindByAny(model.Name, model.Email, model.DisplayName);
                if (collidingUser != null && collidingUser.Id != existingUser.Id)
                {
                    if (collidingUser.Name == model.Name)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_NameAlreadyExists.FormatSafe(model.Name));
                    }
                    if (collidingUser.DisplayName == model.DisplayName)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_DisplayNameAlreadyExists.FormatSafe(model.DisplayName));
                    }
                    if (collidingUser.Email == model.Email)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_EmailAlreadyExists.FormatSafe(model.Email));
                    }
                    Log.Error(string.Format("Exception during editing new user of name: {0}, id: {1}", model.Name, existingUser.Id), null);
                    return new OperationResult<User>(OperationResultType.Error, null);
                }
                else
                {                    
                    if (existingUser == null)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_UnknownUser);
                    }
                    existingUser.Country = model.Country;
                    existingUser.DisplayName = model.DisplayName;
                    existingUser.Email = model.Email;
                    existingUser.Name = model.Name;
                    existingUser.Sex = model.Sex;

                    _userRepository.Update(existingUser);
                    _unitOfWork.Commit();
                    return new OperationResult<User>(OperationResultType.Success, existingUser);
                }
            }
            catch (Exception exception)
            {
                var userName = model == null ? null : model.Name;
                Log.Error(string.Format("Exception during editing user of name: {0}", userName), exception);
                return new OperationResult<User>(OperationResultType.Error, null, ServicesMessages.Error_Unknown);
            }
        }

        public OperationResult<User> EditDetails(User model)
        {
            try
            {
                var existingUser = GetCurrent().Model;
                if (existingUser == null)
                {
                    return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_UnknownUser);
                }
                
                if (existingUser == null)
                {
                    return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                        ServicesMessages.User_Validation_UnknownUser);
                }
                //existingUser.UserAddress.User = existingUser;
                existingUser.UserAddress.City = model.UserAddress.City;
                existingUser.UserAddress.ShareWith = model.UserAddress.ShareWith;
                existingUser.UserAddress.State = model.UserAddress.State;
                _userAddressRepository.Update(existingUser.UserAddress);

                //existingUser.UserDetail.User = existingUser;
                existingUser.UserDetail.AboutMe = model.UserDetail.AboutMe;
                existingUser.UserDetail.Age = model.UserDetail.Age;
                existingUser.UserDetail.Aka = model.UserDetail.Aka;
                existingUser.UserDetail.Hobbies = model.UserDetail.Hobbies;
                existingUser.UserDetail.Profession = model.UserDetail.Profession;
                existingUser.UserDetail.ShareWith = model.UserDetail.ShareWith;
                _userDetailRepository.Update(existingUser.UserDetail);

                //existingUser.UserPersonal.User = existingUser;
                existingUser.UserPersonal.Born = model.UserPersonal.Born;
                existingUser.UserPersonal.FirstName = model.UserPersonal.FirstName;
                existingUser.UserPersonal.LastName = model.UserPersonal.LastName;
                existingUser.UserPersonal.MiddleName = model.UserPersonal.MiddleName;
                existingUser.UserPersonal.ShareWith = model.UserPersonal.ShareWith;
                _userPersonalRepository.Update(existingUser.UserPersonal);
                
                _unitOfWork.Commit();
                return new OperationResult<User>(OperationResultType.Success, existingUser);
            }
            catch (Exception exception)
            {
                var userName = model == null ? null : model.Name;
                Log.Error(string.Format("Exception during editing details for users of name: {0}", userName), exception);
                return new OperationResult<User>(OperationResultType.Error, null, ServicesMessages.Error_Unknown);
            }
        }

        public OperationResult<User> ChangePassword(string oldPassword, string newPassword)
        {
            try
            {
                var existingUser = GetCurrent().Model;
                if (existingUser == null)
                {
                    return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_UnknownUser);
                }
                if (existingUser == null)
                {
                    return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                        ServicesMessages.User_Validation_UnknownUser);
                }
                if (!string.IsNullOrWhiteSpace(newPassword))
                {
                    if (!_cryptoService.Verify(oldPassword, existingUser.Password))
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_WrongOriginalPassword);
                    }
                    existingUser.Password = _cryptoService.Compute(newPassword, null);
                }
                _userRepository.Update(existingUser);
                _unitOfWork.Commit();
                return new OperationResult<User>(OperationResultType.Success, existingUser);
            }
            catch (Exception exception)
            {
                Log.Error(string.Format("Exception during changing password"), exception);
                return new OperationResult<User>(OperationResultType.Error, null, ServicesMessages.Error_Unknown);
            }
        }
    }
}
