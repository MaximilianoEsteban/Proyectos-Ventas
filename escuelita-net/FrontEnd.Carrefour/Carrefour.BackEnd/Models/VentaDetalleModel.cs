namespace Carrefour.BackEnd.Models
{
    public class VentaDetalleModel
    {
        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; } // Id de producto
        public string Nombre { get; set; }
        public int IdFormaPago { get; set; }
        public string FormaPago { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; }
        public double ImporteTotal { get; set; }
    }
}
