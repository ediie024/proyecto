using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD.Maps
{
    public class CategoriaMap: IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(o => o.Id);

            
          
            builder.HasMany(o => o.detalleObjetoCategorias).
                WithOne(o => o.categoria).
                HasForeignKey(o => o.IdCategoria);

        }
    }
}