using RepositoryPathern.Data;
using RepositoryPathern.Repositories.Interfaces;

namespace RepositoryPathern.Repositories
{
    public class RepositoryBase : IRepositoryBase
    {
        private readonly DataContext _context;

        public RepositoryBase(DataContext context)
        {
            _context = context;
        }

        public void Add<T>(T entity)
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity)
        {
            _context.Remove(entity);
        }

        public void Update<T>(T entity)
        {
            _context.Update(entity);
        }
    }
}