using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Web.ViewModels.User;

namespace The.Apps.Game.Web.Extensions.ViewModels
{
    public static class UserViewModelExtensions
    {
        public static User ToModel(this RegisterViewModel viewModel, int userId)
        {
            if (viewModel == null)
            {
                return null;
            }
            return new User
            {
                Country = viewModel.Country,
                DisplayName = viewModel.DisplayName,
                Email = viewModel.Email,
                Id = userId,
                Name = viewModel.Name,
                Password = viewModel.Password,
                Sex = viewModel.Sex,
                UserAddress = viewModel.Address.ToModel(userId),
                UserDetail = viewModel.Detail.ToModel(userId),
                UserPersonal = viewModel.Personal.ToModel(userId)
            };
        }

        public static User ToModel(this EditViewModel viewModel, int userId)
        {
            if (viewModel == null)
            {
                return null;
            }
            return new User
            {
                Country = viewModel.Country,
                DisplayName = viewModel.DisplayName,
                Email = viewModel.Email,
                Id = userId,
                Name = viewModel.Name,
                Sex = viewModel.Sex
            };
        }

        
        public static UserAddress ToModel(this AddressViewModel viewModel, int userId)
        {
            if (viewModel == null)
            {
                return null;
            }
            return new UserAddress
            {
                City = viewModel.City,
                ShareWith = viewModel.ShareWith,
                State = viewModel.State,
                UserId = userId
            };
        }

        public static UserDetail ToModel(this DetailViewModel viewModel, int userId)
        {
            if (viewModel == null)
            {
                return null;
            }
            return new UserDetail
            {
                AboutMe = viewModel.AboutMe,
                Age = viewModel.Age,
                Aka = viewModel.Aka,
                Hobbies = viewModel.Hobbies,
                ShareWith = viewModel.ShareWith,
                Profession = viewModel.Profession,
                UserId = userId
            };
        }

        public static UserPersonal ToModel(this PersonalViewModel viewModel, int userId)
        {
            if (viewModel == null)
            {
                return null;
            }
            return new UserPersonal
            {
                Born = viewModel.Born,
                FirstName = viewModel.FirstName,
                LastName = viewModel.LastName,
                MiddleName = viewModel.MiddleName,
                ShareWith = viewModel.ShareWith,
                UserId = userId
            };
        }
    }
}