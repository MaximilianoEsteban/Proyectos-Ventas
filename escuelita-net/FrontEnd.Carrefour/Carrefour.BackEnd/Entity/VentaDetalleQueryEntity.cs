namespace Carrefour.BackEnd.Entity
{
    public class VentaDetalleQueryEntity
    {
        public VentaDetalleEntity VentaDetalle {get; set;}
        public VentaCabeceraEntity ventaCabecera {get; set;}
        public ProductoEntity Producto {get; set;}
        public FormaPagoEntity FormaPago {get; set;}
    }
}
