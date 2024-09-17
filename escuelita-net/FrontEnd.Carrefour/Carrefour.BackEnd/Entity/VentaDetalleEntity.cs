namespace Carrefour.BackEnd.Entity
{
    public class VentaDetalleEntity
    {
        public int IdVentaDetalle { get; set; }
        public int IdVenta { get; set; }
        public int IdProducto { get; set; } // Id de producto
        public int IdFormaPago { get; set; }
        public int Cantidad { get; set; }
        public double PrecioVenta { get; set; }
        public double ImporteTotal { get; set; }
    }
}
