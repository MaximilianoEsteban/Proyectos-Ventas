using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Categoria oCategoria { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal Utilidad { get; set; }
        public int Stock { get; set; }
        public int StockMinimo { get; set; }
        public string NombreCarpeta { get; set; }
        public string NombreArchivo { get; set; }


    }
}
