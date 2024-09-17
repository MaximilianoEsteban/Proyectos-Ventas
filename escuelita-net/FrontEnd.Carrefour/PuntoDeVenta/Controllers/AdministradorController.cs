using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PuntoDeVenta.Models;
using PuntoDeVenta.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PuntoDeVenta.Controllers
{
    [Authorize(Roles = "Administrador")]
    public class AdministradorController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public AdministradorController(CarrefourApiService carrefourApiService)
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

        /* implementar para que se vea la lista de usuarios con la opcion de solo editar password o blanqueo de password */

        public async Task<IActionResult> Lista()
        {            

            string restResource = "/Usuario/listar";
            var model = await this.carrefourApiService.RequestGet<List<UsuarioModel>>(restResource);

            return View(model);
        }
        
        [HttpGet]
        public async Task<IActionResult> EditarPassword(string IdUsuario)
        {
            string restResource = "/Administrador/" + IdUsuario;
            UsuarioModel model = await carrefourApiService.RequestGet<UsuarioModel>(restResource);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditarPassword(UsuarioModel model)
        {
            try
            {
                string restResource = "/Usuario/editarPassword";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
