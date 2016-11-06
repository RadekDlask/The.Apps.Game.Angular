using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using The.Apps.Game.Core.Data.Models.Users;

namespace The.Apps.Game.Core.Data.Database
{
    public class GameDatabaseContext : DbContext
    {
        public GameDatabaseContext() : base("name=The.Apps.Game")
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<UserPersonal> UserPersonals { get; set; }
        public DbSet<UserAddress> UserAddresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
