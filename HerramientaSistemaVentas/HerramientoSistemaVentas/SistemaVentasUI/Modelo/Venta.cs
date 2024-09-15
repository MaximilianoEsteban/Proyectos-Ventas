using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public string NumeroDocumento { get; set; }
        public string FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public string NombreCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public int CantidadProductos { get; set; }


        public decimal MontoSubTotalValor { get; set; }
        public string MontoSubTotalTexto { get; set; }

        public decimal MontoIVAValor { get; set; }
        public string MontoIVATexto { get; set; }

        public decimal MontoTotalValor { get; set; }
        public string MontoTotalTexto { get; set; }
        public string PagoCon { get; set; }
        public string Cambio { get; set; }
        public bool Estado { get; set; }
        public List<DetalleVenta> oListaDetalleVenta { get; set; }
    }
}
