namespace RepositoryPathern.Repositories.Interfaces
{
    public interface IRepositoryBase
    {
        void Add<T>(T entity);

        void Delete<T>(T entity);

        void Update<T>(T entity);
    }
}