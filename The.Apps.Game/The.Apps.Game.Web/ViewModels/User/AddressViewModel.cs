using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Core.Data.Models.Users;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class AddressViewModel
    {
        [Display(Name = "Input_User_ShareWith", ResourceType = typeof(Core.Resources.Validation))]
        public ShareWith ShareWith { get; set; }

        [Display(Name = "Input_User_State", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string State { get; set; }

        [Display(Name = "Input_User_City", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string City { get; set; }
    }
}