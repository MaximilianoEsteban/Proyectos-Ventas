using System;
using System.Security.Policy;

namespace Carrefour.BackEnd.Entity
{
    public class UsuarioEntity
    {
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string IdPerfil { get; set; }
        public string NombrePerfil { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaPassword { get; set; }
    }
}
