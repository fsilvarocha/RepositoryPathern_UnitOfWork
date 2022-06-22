namespace RepositoryPathern.Transaction.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();

        void Rollback();
    }
}