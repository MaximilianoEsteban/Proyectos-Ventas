using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class VistaDetalleVenta
    {
        public string NumeroDocumento { get; set; }
        public string FechaRegistro { get; set; }
        public string UsuarioRegistro { get; set; }
        public string NombreCliente { get; set; }
        public string DocumentoCliente { get; set; }
        public string CorreoCliente { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public string PrecioVenta { get; set; }
        public string CantidadValor { get; set; }
        public string MedidaMinima { get; set; }
        public string Total { get; set; }
        public string Estado { get; set; }

    }
}
