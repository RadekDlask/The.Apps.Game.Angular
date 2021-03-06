﻿using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Web.Attributes;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class RegisterViewModel
    {
        public RegisterViewModel()
        {
            Address = new AddressViewModel();
            Detail = new DetailViewModel();
            Personal = new PersonalViewModel();
        }

        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [StringLength(14, ErrorMessageResourceName = "Input_Range_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation), MinimumLength = 4)]
        [Display(Name = "Input_User_Name", ResourceType = typeof(Core.Resources.Validation))]
        [InvalidCharacter("@", ErrorMessageResourceName = "Input_InvalidCharacter_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [StringLength(14, ErrorMessageResourceName = "Input_Range_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation), MinimumLength = 8)]
        [Display(Name = "Input_User_Password", ResourceType = typeof(Core.Resources.Validation))]
        [NotEqualTo(nameof(Name), ErrorMessageResourceName = "Input_NotEqualTo_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [NotEqualTo(nameof(DisplayName), ErrorMessageResourceName = "Input_NotEqualTo_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [NotEqualTo(nameof(Email), ErrorMessageResourceName = "Input_NotEqualTo_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string Password { get; set; }

        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [Display(Name = "Input_User_PasswordConfirmed", ResourceType = typeof(Core.Resources.Validation))]        
        [EqualTo(nameof(Password), ErrorMessageResourceName = "Input_EqualTo_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string PasswordConfirmed { get; set; }

        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [EmailAddress(ErrorMessageResourceName = "Input_Email_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [Display(Name = "Input_User_Email", ResourceType = typeof(Core.Resources.Validation))]
        [StringLength(28, ErrorMessageResourceName = "Input_Range_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation), MinimumLength = 5)]
        public string Email { get; set; }

        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [StringLength(14, ErrorMessageResourceName = "Input_Range_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation), MinimumLength = 2)]
        [Display(Name = "Input_User_Display", ResourceType = typeof(Core.Resources.Validation))]
        [NotEqualTo(nameof(Name), ErrorMessageResourceName = "Input_NotEqualTo_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string DisplayName { get; set; }

        [Display(Name = "Input_User_Country", ResourceType = typeof(Core.Resources.Validation))]
        public int Country { get; set; }

        [Display(Name = "Input_User_Sex", ResourceType = typeof(Core.Resources.Validation))]
        public Sex Sex { get; set; }

        public AddressViewModel Address { get; set; }

        public DetailViewModel Detail { get; set; }

        public PersonalViewModel Personal { get; set; }

        public string CustomError { get; set; }
    }
}