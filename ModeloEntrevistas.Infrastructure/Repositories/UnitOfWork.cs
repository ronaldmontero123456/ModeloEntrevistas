using ModeloEntrevistas.Core.Interfaces;
using ModeloEntrevistas.Infrastructure.Data;
using System;
using System.Threading.Tasks;

namespace ModeloEntrevistas.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ModeloEntrevistasContext _context;
        private readonly IEstudiantesRepository _estudiantesRepository;

        public UnitOfWork(ModeloEntrevistasContext context)
        {
            _context = context;
        }

        public IEstudiantesRepository EstudiantesRepository => _estudiantesRepository?? new EstudiantesRepository(_context);

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
