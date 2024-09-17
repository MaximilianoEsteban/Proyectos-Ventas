using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Modelo
{
    public class ItemsVenta
    {
        public int IdProducto { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public string CantidadTexto { get; set; }
        public decimal Precio { get; set; }
        public string PrecioTexto { get; set; }
        public decimal Total { get; set; }
        public string TotalTexto { get; set; }

    }
}
