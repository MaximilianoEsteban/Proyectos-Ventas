using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string NumeroDocumento { get; set; }
        public string NombreCompleto { get; set; }
        public int IdRol { get; set; }
        public string FechaRegistro { get; set; }
        public string Clave { get; set; }
    }
}
