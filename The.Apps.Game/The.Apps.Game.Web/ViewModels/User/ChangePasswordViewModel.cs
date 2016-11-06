using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Web.Attributes;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class ChangePasswordViewModel
    {
        public string Name { get; set; }

        public string Email { get; set; }
        
        public string DisplayName { get; set; }

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
        [Display(Name = "Input_User_OriginalPassword", ResourceType = typeof(Core.Resources.Validation))]
        public string OriginalPassword { get; set; }

        public string CustomError { get; set; }
    }
}