using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using PuntoDeVenta.Models;
using PuntoDeVenta.Service;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{
    [Authorize(Roles = "Cliente")]
    public class ClienteController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public ClienteController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;

        }

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

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Producto/listar";
            var model = await this.carrefourApiService.RequestGet<List<ProductoModel>>(restResource);

            return View(model);
        }

        public async Task<IActionResult> Carrito()
        {
            string restResource = "/Producto/listar";
            var model = await this.carrefourApiService.RequestGet<List<ProductoModel>>(restResource);

            return Json(model);

            /*return View(model);*/
        }

        public IActionResult CarritoCompras()
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
