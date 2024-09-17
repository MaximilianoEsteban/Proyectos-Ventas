namespace SistemaVentasASPNET_MVC.Areas.Users.Models
{
    public class TUsers
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NID { get; set; }
        public string Email { get; set; }
        public string IdUser { get; set; }
        public byte[] Image { get; set; }
    }
}
