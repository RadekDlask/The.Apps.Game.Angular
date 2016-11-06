using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Web.ViewModels.User;

namespace The.Apps.Game.Web.Extensions.ViewModels
{
    public static class UserModelExtensions
    {
        public static EditViewModel ToEditViewModel(this User model, int userId)
        {
            if (model == null)
            {
                return null;
            }
            return new EditViewModel
            {
                Country = model.Country,
                DisplayName = model.DisplayName,
                Email = model.Email,
                Name = model.Name,
                Sex = model.Sex
            };
        }

        public static DetailsViewModel ToDetailsViewModel(this User model, int userId)
        {
            if (model == null)
            {
                return null;
            }
            return new DetailsViewModel
            {
                Name = model.Name,
                Address = model.UserAddress.ToViewModel(userId),
                Detail = model.UserDetail.ToViewModel(userId),
                Personal = model.UserPersonal.ToViewModel(userId)
            };
        }

        public static AddressViewModel ToViewModel(this UserAddress viewModel, int userId)
        {
            if (viewModel == null)
            {
                return null;
            }
            return new AddressViewModel
            {
                City = viewModel.City,
                ShareWith = viewModel.ShareWith,
                State = viewModel.State
            };
        }

        public static DetailViewModel ToViewModel(this UserDetail model, int userId)
        {
            if (model == null)
            {
                return null;
            }
            return new DetailViewModel
            {
                AboutMe = model.AboutMe,
                Age = model.Age,
                Aka = model.Aka,
                Hobbies = model.Hobbies,
                ShareWith = model.ShareWith,
                Profession = model.Profession
            };
        }

        public static PersonalViewModel ToViewModel(this UserPersonal model, int userId)
        {
            if (model == null)
            {
                return null;
            }
            return new PersonalViewModel
            {
                Born = model.Born,
                FirstName = model.FirstName,
                LastName = model.LastName,
                MiddleName = model.MiddleName,
                ShareWith = model.ShareWith
            };
        }
    }
}