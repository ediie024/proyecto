using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD.Maps
{
    public class ReporteMap : IEntityTypeConfiguration<Reporte>
    {
        public void Configure(EntityTypeBuilder<Reporte> builder)
        {
            builder.ToTable("Reporte");
            builder.HasKey(o => o.Id);
            
            builder.HasOne(o => o.usuario).
                WithMany(o => o.reportes).
                HasForeignKey(o => o.IdUSuario);
            
            builder.HasOne(o => o.objeto).
                WithMany(o => o.Reportes).
                HasForeignKey(o => o.IdObjeto);

        }
    }
}