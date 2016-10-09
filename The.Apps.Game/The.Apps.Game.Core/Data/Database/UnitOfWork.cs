using System.Data.Entity;

namespace The.Apps.Game.Core.Data.Database
{
    public class UnitOfWork : IUnitOfWork
    {
        protected readonly DbContext Context;

        public UnitOfWork(DbContext context)
        {
            Context = context;
        }

        public void Commit()
        {
            Context.SaveChanges();
        }
        public async void CommitAsync()
        {
            await Context.SaveChangesAsync();
        }
    }
}
