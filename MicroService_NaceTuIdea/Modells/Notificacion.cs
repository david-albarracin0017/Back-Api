namespace MicroService_NaceTuIdea.Modells
{
    public class Notificacion
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public string Tipo { get; set; }
        public string Mensaje { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Leida { get; set; }

    }
}
