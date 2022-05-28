using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModeloEntrevistas.Core.Entities;

namespace ModeloEntrevistas.Infrastructure.Data.ModelCreatingConfigurations
{
    class EstudiantesConfigurations : IEntityTypeConfiguration<Estudiantes>
    {
        public void Configure(EntityTypeBuilder<Estudiantes> builder)
        {
            builder.HasKey(e => e.ID);

            builder.Property(e => e.Nombre)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.FechaNacimiento)
                .IsRequired()
                .IsUnicode(false);

            builder.Property(e => e.Curso)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false);

            builder.Property(e => e.Estado)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
