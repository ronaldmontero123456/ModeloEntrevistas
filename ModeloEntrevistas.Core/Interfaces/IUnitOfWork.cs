using System;
using System.Threading.Tasks;

namespace ModeloEntrevistas.Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public IEstudiantesRepository EstudiantesRepository { get; }
        Task SaveChangesAsync();
    }
}
