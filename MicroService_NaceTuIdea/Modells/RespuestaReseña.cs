namespace MicroService_NaceTuIdea.Modells
{
    public class RespuestaReseña
    {
        public Guid Id { get; set; }
        public Guid ResenaId { get; set; }
        public Guid PropietarioId { get; set; }
        public string Comentario { get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}
