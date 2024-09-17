using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Controllers
{
    [Authorize]
    [Area("Clientes")]
    public class ClientesController : Controller
    {
        public IActionResult Clientes()
        {
            return View();
        }
    }
}
