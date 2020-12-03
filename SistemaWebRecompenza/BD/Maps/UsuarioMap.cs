using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD.Maps
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(o => o.Id);

            builder.HasMany(o => o.reportes).
                WithOne(o => o.usuario).
                HasForeignKey(o => o.IdUSuario);

            builder.HasMany(o => o.Mensajeria1).
                WithOne(o => o.usuarioLocalMensajeria).
                HasForeignKey(o => o.IdDestino);

            builder.HasMany(o => o.Mensajeria2).
                WithOne(o => o.usuarioDestinoMensajeria).
                HasForeignKey(o => o.IdLocal);

        }
    }
}