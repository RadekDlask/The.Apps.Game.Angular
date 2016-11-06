using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using The.Apps.Game.Core.Data.Models.Users;

namespace The.Apps.Game.Web.ViewModels.User
{
    public class PersonalViewModel
    {
        [Display(Name = "Input_User_ShareWith", ResourceType = typeof(Core.Resources.Validation))]
        public ShareWith ShareWith { get; set; }

        [Display(Name = "Input_User_Born", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public DateTime? Born { get; set; }

        [Display(Name = "Input_User_FirstName", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string FirstName { get; set; }

        [Display(Name = "Input_User_MiddleName", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string MiddleName { get; set; }

        [Display(Name = "Input_User_LastName", ResourceType = typeof(Core.Resources.Validation))]
        [MaxLength(28, ErrorMessageResourceName = "Input_MaxLength_Validation", ErrorMessageResourceType = typeof(Core.Resources.Validation))]
        public string LastName { get; set; }
    }
}