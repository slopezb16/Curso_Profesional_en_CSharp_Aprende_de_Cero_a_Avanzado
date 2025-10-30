namespace SistemaPuntoDeVenta.Library.Models
{
    public class Usuarios
    {
        public int IdUsuario { get; set; }
        public string Username { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public bool EsAdmin { get; set; }
    }
}