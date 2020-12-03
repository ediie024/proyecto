using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD.Maps
{
    public class MensajeriaMap : IEntityTypeConfiguration<Mensajeria>
    {
        public void Configure(EntityTypeBuilder<Mensajeria> builder)
        {
            builder.ToTable("Mensajeria");
            builder.HasKey(o => o.Id);

        
        }
    }
}