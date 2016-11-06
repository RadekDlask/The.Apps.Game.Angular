using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Core.Data.Models.Users;
using The.Apps.Game.Web.Attributes;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class EditViewModel
    {
        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        [StringLength(14, ErrorMessageResourceName = "Input_Range_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation), MinimumLength = 4)]
        [Display(Name = "Input_User_Name", ResourceType = typeof(Core.Resources.Validation))]
        [InvalidCharacter("@", ErrorMessageResourceName = "Input_InvalidCharacter_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string Name { get; set; }        

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
        [Required(ErrorMessageResourceName = "Input_Required_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public int Country { get; set; }

        [Display(Name = "Input_User_Sex", ResourceType = typeof(Core.Resources.Validation))]
        public Sex Sex { get; set; }        

        public string CustomError { get; set; }
    }
}