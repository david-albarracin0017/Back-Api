namespace MicroService_NaceTuIdea.Modells
{
    public class DisponibilidadLocal
    {
        public Guid Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public TimeSpan? HoraInicio { get; set; }
        public TimeSpan? HoraFin { get; set; }
        public bool Disponible { get; set; }

    }
}
