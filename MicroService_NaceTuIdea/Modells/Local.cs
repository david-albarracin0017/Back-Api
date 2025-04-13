namespace MicroService_NaceTuIdea.Modells
{
    public class Local
    {
        public Guid Id { get; set; }
        public Guid PropietarioId {  get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal PresioxHora { get; set; }
        public string Direccion {  get; set; }
        public double Latitud {  get; set; }
        public double Longitud { get; set; }
        public int Capacidad { get; set; }
        public List<ComodidadLocal> Comodidades { get; set; } = new List<ComodidadLocal>();
        public List<string> FotosUrls { get; set; } = new List<string>();
        public List<string> VideosUrls { get; set; } = new List<string>();
        public List<ReglaLocal> Reglas { get; set; } = new List<ReglaLocal>();
        public List<ServicioAdicionalLocal> ServiciosAdicionales { get; set; } = new List<ServicioAdicionalLocal>();
        public List<DisponibilidadLocal> Disponibilidades { get; set; } = new List<DisponibilidadLocal>();
        public List<Guid> CategoriasIds { get; set; } = new List<Guid>(); // Referencias a las categorías del local


    }
}
