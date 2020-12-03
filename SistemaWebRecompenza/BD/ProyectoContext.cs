

using Microsoft.EntityFrameworkCore;
using SistemaWebRecompenza.BD.Maps;
using SistemaWebRecompenza.Models;

namespace SistemaWebRecompenza.BD
{
    public class ProyectoContext : DbContext
    {
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<DetalleObjetoCategoria> DetalleObjetoCategorias { get; set; }
      
        public DbSet<Mensajeria> Mensajerias { get; set; }
        public DbSet<Objeto> Objetos { get; set; }
        public DbSet<Reporte> Reportes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public ProyectoContext(DbContextOptions<ProyectoContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new DetalleObjetoCategoriaMap());
           
            modelBuilder.ApplyConfiguration(new MensajeriaMap());
            modelBuilder.ApplyConfiguration(new ObjetoMap());
            modelBuilder.ApplyConfiguration(new ReporteMap());
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            

        }
    }
}