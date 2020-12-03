using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD.Maps
{
    public class ObjetoMap: IEntityTypeConfiguration<Objeto>
    {
        public void Configure(EntityTypeBuilder<Objeto> builder)
        {
            builder.ToTable("Objeto");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.Reportes).
                WithOne(o => o.objeto).
                HasForeignKey(o => o.IdObjeto);
          
            builder.HasMany(o => o.detalleObjetoCategorias).
                WithOne(o => o.objeto).
                HasForeignKey(o => o.IdObjeto);

        }
    }
}