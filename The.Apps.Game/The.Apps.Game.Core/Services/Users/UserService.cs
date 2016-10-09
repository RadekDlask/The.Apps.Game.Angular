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
        private ICryptoService _cryptoService;
        private IUnitOfWork _unitOfWork;
        public UserService(IRepository<User> userRepository, IUnitOfWork unitOfWork, ICryptoService cryptoService)
        {
            _userRepository = userRepository;
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

        public OperationResult<User> Register(string name, string password, string displayName, string email)
        {
            try
            {
                var existingUser = _userRepository.Read().FindByAny(name, email, displayName);
                if (existingUser != null)
                {
                    if (existingUser.Name == name)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_NameAlreadyExists.FormatSafe(name));
                    }
                    if (existingUser.DisplayName == displayName)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_DisplayNameAlreadyExists.FormatSafe(displayName));
                    }
                    if (existingUser.Email == email)
                    {
                        return new OperationResult<User>(OperationResultType.ValidationFailed, null,
                            ServicesMessages.User_Validation_EmailAlreadyExists.FormatSafe(email));
                    }
                    Log.Error("Unknown error during registering user of name: " + name, null);
                        return new OperationResult<User>(OperationResultType.Error, null);
                }
                else
                {
                    var userToAdd = new User
                    {
                        DisplayName = displayName,
                        Email = email,
                        Name = name,
                        Password = _cryptoService.Compute(password, null),
                    };
                    _userRepository.Create(userToAdd);
                    _unitOfWork.Commit();
                    return new OperationResult<User>(OperationResultType.Success, userToAdd);
                }
            }
            catch (Exception exception)
            {
                Log.Error("Exception during registering user of name: " + name, exception);
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
    }
}
