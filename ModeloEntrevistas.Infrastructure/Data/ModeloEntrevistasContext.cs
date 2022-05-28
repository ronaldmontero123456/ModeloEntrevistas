using Microsoft.EntityFrameworkCore;
using ModeloEntrevistas.Core.Entities;
using System.Reflection;

namespace ModeloEntrevistas.Infrastructure.Data
{
    public class ModeloEntrevistasContext : DbContext
    {
        public ModeloEntrevistasContext(DbContextOptions<ModeloEntrevistasContext> options) : base(options) { }

        public DbSet<Estudiantes> Estudiantes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
