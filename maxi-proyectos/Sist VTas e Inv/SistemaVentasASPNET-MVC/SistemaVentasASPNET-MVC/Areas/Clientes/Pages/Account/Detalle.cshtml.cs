using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaVentasASPNET_MVC.Areas.Clientes.Models;
using SistemaVentasASPNET_MVC.Data;
using SistemaVentasASPNET_MVC.Library;
using System.Linq;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Pages.Account
{
    [Authorize]
    public class DetalleModel : PageModel
    {
        private LCustomers _customer;
        public DetalleModel(
            ApplicationDbContext context)
        {
            _customer = new LCustomers(context);
        }
        public void OnGet(int id)
        {
            var data = _customer.getTClients(null, id);
            if (0 < data.Count)
            {
                Input = new InputModel
                {
                    DataClient = data.ToList().Last(),
                };
            }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public InputModelRegister DataClient { get; set; }
        }
    }
}
