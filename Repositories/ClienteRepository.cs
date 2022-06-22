using RepositoryPathern.Data;
using RepositoryPathern.Repositories.Interfaces;

namespace RepositoryPathern.Repositories
{
    public class ClienteRepository : RepositoryBase, IClienteRepository
    {
        private readonly DataContext _context;

        public ClienteRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}