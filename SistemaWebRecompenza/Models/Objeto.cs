using System;
using System.Collections.Generic;

namespace SistemaWebRecompenza.Models
{
    public class Objeto
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Imagen { get; set; }
        
        
        public List<Reporte> Reportes { get; set; }
        public List<DetalleObjetoCategoria> detalleObjetoCategorias { get; set; }
    }
}