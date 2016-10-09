using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Web.Attributes;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [Display(Name = "Input_User_Name", ResourceType = typeof(Core.Resources.Validation))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [Display(Name = "Input_User_Password", ResourceType = typeof(Core.Resources.Validation))]
        public string Password { get; set; }

        [Display(Name = "Label_Error", ResourceType = typeof(Core.Resources.Validation))]
        public string CustomError { get; set; }
    }
}