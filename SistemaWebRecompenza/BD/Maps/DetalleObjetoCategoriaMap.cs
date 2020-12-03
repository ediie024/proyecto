using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD.Maps
{
    public class DetalleObjetoCategoriaMap: IEntityTypeConfiguration<DetalleObjetoCategoria>
    {
        public void Configure(EntityTypeBuilder<DetalleObjetoCategoria> builder)
        {
            builder.ToTable("DetalleObjetoCategoria");
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.objeto).
                WithMany(o => o.detalleObjetoCategorias)
                .HasForeignKey(o => o.IdObjeto);
            
            builder.HasOne(o => o.categoria).
                WithMany(o => o.detalleObjetoCategorias)
                .HasForeignKey(o => o.IdCategoria);
        }
    }
}