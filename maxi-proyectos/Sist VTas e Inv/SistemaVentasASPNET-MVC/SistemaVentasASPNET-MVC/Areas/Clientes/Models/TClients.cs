using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Models
{
    public class TClients
    {
        [Key]
        public int IdCliente { set; get; }
        public string NID { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        public string Email { set; get; }
        public string Direccion { set; get; }
        public string Telefono { set; get; }
        public DateTime Fecha { set; get; }
        public bool Credito { set; get; }
        public byte[] Image { get; set; }
        public List<TReports_clients> TReports_clients { get; set; }
    }
}
