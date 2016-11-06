using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The.Apps.Game.Core.Data.Models.Users
{
    public class UserPersonal
    {
        public ShareWith ShareWith { get; set; }

        public DateTime? Born { get; set; }

        [MaxLength(28)]
        public string FirstName { get; set; }

        [MaxLength(28)]
        public string MiddleName { get; set; }

        [MaxLength(28)]
        public string LastName { get; set; }

        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
