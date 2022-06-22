using RepositoryPathern.Data;
using RepositoryPathern.Transaction.Interfaces;

namespace RepositoryPathern.Transaction
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;

        public UnitOfWork(DataContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Rollback()
        {
            throw new System.Exception("Erro ao salvar");
        }
    }
}