using System;

namespace PuntoDeVenta.Models
{
    public class UsuarioModel
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password1 { get; set; }
        public string IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPassword { get; set; }
    }
}
