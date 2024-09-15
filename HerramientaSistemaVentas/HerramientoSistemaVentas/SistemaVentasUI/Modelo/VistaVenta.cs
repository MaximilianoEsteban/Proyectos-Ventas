using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class VistaVenta
    {
        public string NumeroDocumento { get; set; }
        public string FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public string NombreCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string CantidadProductos { get; set; }
        public string MontoSubTotalValor { get; set; }
        public string MontoIVAValor { get; set; }
        public string MontoTotalValor { get; set; }
        public string PagoCon { get; set; }
        public string Cambio { get; set; }
        public string Estado { get; set; }
    }
}
