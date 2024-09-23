using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaVentasASPNET_MVC.Areas.Clientes.Models;
using SistemaVentasASPNET_MVC.Data;
using SistemaVentasASPNET_MVC.Library;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Pages.Account
{
    [Authorize]
    public class ReportesModel : PageModel
    {
        private LCustomers _customer;
        private static int idCliente = 0;
        public static string Money = "$";
        private static string _errorMessage;
        public static InputModelRegister _dataClient;
        //private LCodes _codes;
        private ApplicationDbContext _context;
        private UserManager<IdentityUser> _userManager;

        public ReportesModel(
            UserManager<IdentityUser> userManager,
            ApplicationDbContext context)
        {
            _context = context;
            _userManager = userManager;
            _customer = new LCustomers(context);
        }
        public IActionResult OnGet(int id)
        {
            if (idCliente == 0)
            {
                idCliente = id;
            }
            else
            {
                if (idCliente != id)
                {
                    idCliente = 0;
                    return Redirect("/Clientes/Clientes?area=Clientes");
                }
            }
            return Page();
        }
    }
}

