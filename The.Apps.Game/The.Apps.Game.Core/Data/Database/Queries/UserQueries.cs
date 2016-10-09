using System.Collections.Generic;
using System.Linq;
using The.Apps.Game.Core.Data.Models.Users;

namespace The.Apps.Game.Core.Data.Database.Queries
{
    internal static class UserQueries
    {        
        internal static User FindByAny(this IQueryable<User> users, string name, string email, string displayName)
        {
            if (users == null || string.IsNullOrWhiteSpace(name))
                return null;
            if (!string.IsNullOrWhiteSpace(email))
                email = email.ToLower();

            return users.SingleOrDefault(u => u.Name == name || u.Email == email || u.DisplayName == displayName);
        }
    }
}
