using System.ComponentModel.DataAnnotations;
using System;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Models
{
    public class TReports_clients
    {
        [Key]
        public int IdReporte { set; get; }
        [Display(Name = "Deuda")]
        public Decimal Debt { set; get; }

        [Display(Name = "Mensual")]
        public Decimal Monthly { set; get; }

        [Display(Name = "Cambio")]
        public Decimal Change { set; get; }

        [Display(Name = "Ultimo Pago")]
        public Decimal LastPayment { set; get; }

        [Display(Name = "Fecha de Pago")]
        public DateTime DatePayment { set; get; }

        [Display(Name = "Deuda Actual")]
        public Decimal CurrentDebt { set; get; }

        [Display(Name = "Fecha Dedua")]
        public DateTime DateDebt { set; get; }

        [Display(Name = "Comprobante")]
        public string Ticket { set; get; }

        [Display(Name = "Fecha Limite")]
        public DateTime Deadline { set; get; }

        
        public int IdClient { get; set; }        
        public TClients TClients { get; set; }
    }
}
