namespace MicroService_NaceTuIdea.Modells
{
    public class Users
    {
       public Guid Id { get; set; }
        public string Name { get; set; }
        public string Apellido{ get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Registro { get; set; }
        public bool Propietario { get; set; }
        public List<Guid> FavoritosL { get; set; }= new List<Guid>();

    }
}
