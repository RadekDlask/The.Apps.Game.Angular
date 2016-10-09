namespace The.Apps.Game.Core.Data.Database
{
    public interface IUnitOfWork
    {
        void Commit();
        void CommitAsync();
    }
}
