using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuntoDeVenta.Models;
using System.Data;
using System.Linq;
using System.Security.Claims;

namespace PuntoDeVenta.Controllers
{
    [Authorize(Roles = "Gerente")]
    public class GerenteController : Controller
    {
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                // obtiene los claims del usuario
                var claims = User.Claims.ToList();

                var usuario = new UsuarioModel();
                usuario.IdUsuario = User.Claims.Where(x => x.Type == ClaimTypes.Name).Select(x => x.Value).FirstOrDefault();
                usuario.Nombre = User.Claims.Where(x => x.Type == ClaimTypes.GivenName).Select(x => x.Value).FirstOrDefault();
                usuario.Apellido = User.Claims.Where(x => x.Type == ClaimTypes.Surname).Select(x => x.Value).FirstOrDefault();
                usuario.NombrePerfil = User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).FirstOrDefault();

                ViewData["Usuario"] = usuario;

                return View(claims);
            }

            return View();
        }
    }
}
