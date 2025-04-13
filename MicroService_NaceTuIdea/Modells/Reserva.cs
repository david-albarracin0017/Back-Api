namespace MicroService_NaceTuIdea.Modells
{
    public class Reserva
    {
        public Guid Id { get; set; }
        public Guid UsuarioId { get; set; }
        public Guid LocalId { get; set; } // Ahora es requerido
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public int NumeroAsistentes { get; set; }
        public decimal PrecioTotal { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Estado { get; set; } // Pendiente, Confirmada, Cancelada, Finalizada

    }
}
