using System.ComponentModel.DataAnnotations;
using The.Apps.Game.Core.Resources;

namespace The.Apps.Game.Core.Data.Models.Users
{
    public enum ShareWith
    {
        [Display(ResourceType = typeof(Validation), Name = "ShareWith_NoOne")]
        NoOne,
        [Display(ResourceType = typeof(Validation), Name = "ShareWith_Friends")]
        Friends,
        [Display(ResourceType = typeof(Validation), Name = "ShareWith_ClanMembers")]
        ClanMembers,
        [Display(ResourceType = typeof(Validation), Name = "ShareWith_FriendsAndClanMembers")]
        FriendsAndClanMembers,
        [Display(ResourceType = typeof(Validation), Name = "ShareWith_RegisteredUsers")]
        RegisteredUsers,
        [Display(ResourceType = typeof(Validation), Name = "ShareWith_Everyone")]
        Everyone
    }
}
