using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using PuntoDeVenta.Service;
using PuntoDeVenta.Models;

namespace FrontEnd.Carrefour.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public UsuarioController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Usuario/listar";
            var model = await this.carrefourApiService.RequestGet<List<UsuarioModel>>(restResource);

            return View(model);
        }      

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(UsuarioModel model)
        {
            try
            {
                string restResource = "/Usuario/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] UsuarioModel model)
        {
            try
            {
                string restResource = "/Usuario/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Editar(string IdUsuario)
        {
            string restResource = "/Usuario/" + IdUsuario;
            UsuarioModel model = await carrefourApiService.RequestGet<UsuarioModel>(restResource);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(UsuarioModel model)
        {
            try
            {
                string restResource = "/Usuario/editar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody] string IdUsuario)
        {
            try
            {
                string restResource = "/Usuario/eliminar?IdUsuario=" + IdUsuario;
                string jsonResponse = await this.carrefourApiService.RequestDelete(restResource);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
