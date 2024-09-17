using System;

namespace Carrefour.BackEnd.Models
{
    public class VentaCabeceraModel
    {
        public int IdVenta { get; set; }
        public DateTime Fecha { get; set; }
        public string IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdComprobante { get; set; }
        public string Comprobante { get; set; }
    }
}
