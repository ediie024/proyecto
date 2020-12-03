using System;
using System.Collections.Generic;

namespace SistemaWebRecompenza.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public List<DetalleObjetoCategoria> detalleObjetoCategorias { get; set; }
    }
}