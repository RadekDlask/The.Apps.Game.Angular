using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace The.Apps.Game.Core.Data.Models.Users
{
    public class UserDetail
    {
        public ShareWith ShareWith { get; set; }

        public int? Age { get; set; }        

        [MaxLength(28)]
        public string Aka { get; set; }

        public string AboutMe { get; set; }

        [MaxLength(28)]
        public string Profession { get; set; }

        [MaxLength(28)]
        public string Hobbies { get; set; }

        [Key, ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
