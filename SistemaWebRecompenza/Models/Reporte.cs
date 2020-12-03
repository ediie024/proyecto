using System;
using System.Collections.Generic;

namespace SistemaWebRecompenza.Models
{
    public class Reporte
    {
        public int Id { get; set; }

        public String Nombre { get; set; }
        public double Recompenza { get; set; }
        
        public DateTime Fecha{ get; set; }
        public int IdUSuario { get; set; }
        public String Ubicacion { get; set; } 
        public String Descripcion { get; set; }
        public bool EstadoReporte { get; set; } 
        public bool EstadoHabilitado { get; set; }
        public int IdObjeto { get; set; }
        public Usuario usuario { get; set; }
        public Objeto objeto { get; set; }

    }
}