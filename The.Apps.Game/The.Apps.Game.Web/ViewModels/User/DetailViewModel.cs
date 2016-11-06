using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Core.Data.Models.Users;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class DetailViewModel
    {
        [Display(Name = "Input_User_ShareWith", ResourceType = typeof(Core.Resources.Validation))]
        public ShareWith ShareWith { get; set; }

        //public List<ShareWith> ShareWiths { get; set; }

        [Display(Name = "Input_User_Age", ResourceType = typeof(Core.Resources.Validation))]
        public int? Age { get; set; }

        [Display(Name = "Input_User_Aka", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string Aka { get; set; }

        [Display(Name = "Input_User_AboutMe", ResourceType = typeof(Core.Resources.Validation))]
        public string AboutMe { get; set; }

        [Display(Name = "Input_User_Profession", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string Profession { get; set; }

        [Display(Name = "Input_User_Hobbies", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string Hobbies { get; set; }
    }
}