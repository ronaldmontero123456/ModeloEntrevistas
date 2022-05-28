using ModeloEntrevistas.Core.Entities;
using ModeloEntrevistas.Core.Interfaces;
using ModeloEntrevistas.Infrastructure.Data;

namespace ModeloEntrevistas.Infrastructure.Repositories
{
    public class EstudiantesRepository : BaseRepository<Estudiantes>, IEstudiantesRepository
    {
        public EstudiantesRepository(ModeloEntrevistasContext context) : base(context) { }
    }
}
