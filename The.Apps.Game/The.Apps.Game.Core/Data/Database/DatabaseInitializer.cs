namespace The.Apps.Game.Core.Data.Database
{
    // TODO later on or in production change drop to migrate if model changes
    public class DatabaseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GameDatabaseContext>        
    {
        protected override void Seed(GameDatabaseContext context)
        {
            // TODO ?
        }
    }
}
