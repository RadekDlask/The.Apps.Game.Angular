using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The.Apps.Game.Core.Data.Models.Users
{
    public class UserAddress
    {
        public ShareWith ShareWith { get; set; }

        [MaxLength(28)]
        public string State { get; set; }

        [MaxLength(28)]
        public string City { get; set; }

        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
