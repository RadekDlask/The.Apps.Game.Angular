using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Core.Resources;

namespace The.Apps.Game.Core.Data.Models.Users
{
    public enum Sex
    {
        [Display(ResourceType = typeof(Validation), Name = "Sex_Secret")]
        Secret,
        [Display(ResourceType = typeof(Validation), Name = "Sex_Man")]
        Man,
        [Display(ResourceType = typeof(Validation), Name = "Sex_Woman")]
        Woman
    }
}
