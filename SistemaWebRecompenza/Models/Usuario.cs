using System;
using System.Collections.Generic;

namespace SistemaWebRecompenza.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public String Apellidos { get; set; }
        public DateTime FechaNacimiento{ get; set; }
        
        public String Correo { get; set; } 
        public String Telefono { get; set; }

        public String Username { get; set; }
        public String Password { get; set; }
        //
        public List<Reporte> reportes { get; set; }
        public List<Mensajeria> Mensajeria1 { get; set; }
        public List<Mensajeria> Mensajeria2 { get; set; }
    }
}