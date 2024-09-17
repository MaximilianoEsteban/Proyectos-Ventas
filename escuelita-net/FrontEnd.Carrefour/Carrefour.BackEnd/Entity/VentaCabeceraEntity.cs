using System;

namespace Carrefour.BackEnd.Entity
{
    public class VentaCabeceraEntity
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public int IdComprobante { get; set; }
    }
}
