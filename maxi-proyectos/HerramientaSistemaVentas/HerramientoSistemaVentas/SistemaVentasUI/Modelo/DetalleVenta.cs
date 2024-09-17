using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class DetalleVenta
    {
        public int IdDetalleVenta { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; }
        public string Producto { get; set; }
        public string Categoria { get; set; }
        public int CantidadValor { get; set; }
        public string CantidadTexto { get; set; }

        public decimal PrecioValor { get; set; }
        public string PrecioTexto { get; set; }

        public decimal TotalValor { get; set; }
        public string TotalTexto { get; set; }
        public bool Estado { get; set; }
    }
}
