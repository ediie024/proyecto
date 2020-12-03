namespace SistemaWebRecompenza.Models
{
    public class DetalleObjetoCategoria
    {
        public int Id { get; set; }
        public int IdObjeto { get; set; }
        public int IdCategoria { get; set; }

        public Objeto objeto { get; set; }
        public Categoria categoria { get; set; }
    }
}