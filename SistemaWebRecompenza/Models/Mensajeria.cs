using System;

namespace SistemaWebRecompenza.Models
{
    public class Mensajeria
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int IdLocal { get; set; }
        public int IdDestino { get; set; }
        public DateTime FechaMensaje {get; set; }

        
        //
        public Usuario usuarioLocalMensajeria { get; set; }
        public Usuario usuarioDestinoMensajeria  { get; set; }
    }
}