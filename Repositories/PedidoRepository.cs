using RepositoryPathern.Data;
using RepositoryPathern.Repositories.Interfaces;

namespace RepositoryPathern.Repositories
{
    public class PedidoRepository : RepositoryBase, IPedidoRepository
    {
        private readonly DataContext _context;

        public PedidoRepository(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}