using Microsoft.AspNetCore.Mvc;

namespace SistemaVentasASPNET_MVC.Areas.Principal.Controllers
{
    [Area("Principal")]
    public class PrincipalController : Controller
    {
        public IActionResult Principal()
        {
            return View();
        }
    }
}
