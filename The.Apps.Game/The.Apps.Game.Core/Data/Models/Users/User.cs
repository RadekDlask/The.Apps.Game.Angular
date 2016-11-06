using System;
using System.ComponentModel.DataAnnotations;

namespace The.Apps.Game.Core.Data.Models.Users
{
    public class User : NamedModelBase
    {
        [MaxLength(14)]
        public string DisplayName { get; set; }

        [MaxLength(28)]
        public string Email { get; set; }
        
        public string Password { get; set; }

        public int Country { get; set; }

        public DateTime RegisteredAt { get; set; }

        public DateTime LastLogInAt { get; set; }

        public Sex Sex { get; set; }

        public virtual UserDetail UserDetail { get; set; }
        public virtual UserAddress UserAddress { get; set; }
        public virtual UserPersonal UserPersonal { get; set; }
    }
}
