namespace MicroService_NaceTuIdea.Modells
{
    public class Reseña
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid LocalId { get; set; } // Ahora es requerido
        public int Calificacion { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Guid? RespuestaId { get; set; }

    }
}
