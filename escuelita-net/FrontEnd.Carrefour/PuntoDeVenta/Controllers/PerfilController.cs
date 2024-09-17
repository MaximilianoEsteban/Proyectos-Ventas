using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using PuntoDeVenta.Service;
using PuntoDeVenta.Models;

namespace PuntoDeVenta.Controllers
{
    public class PerfilController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public PerfilController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Perfil/listar";
            var model = await this.carrefourApiService.RequestGet<List<PerfilModel>>(restResource);

            return View(model);
        }

        public async Task<IActionResult> ListarPerfilesParaCombos()
        {
            string restResource = "/Perfil/listar";

            var model = await this.carrefourApiService.RequestGet<List<PerfilModel>>(restResource);
            return Json(model);
        }


        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(PerfilModel model)
        {
            try
            {
                string restResource = "/Perfil/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] PerfilModel model)
        {
            try
            {
                string restResource = "/Perfil/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        [HttpGet]
        public async Task<IActionResult> Editar(string IdPerfil)
        {
            string restResource = "/Perfil/" + IdPerfil;
            PerfilModel model = await carrefourApiService.RequestGet<PerfilModel>(restResource);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(PerfilModel model)
        {
            try
            {
                string restResource = "/Perfil/editar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody] string IdPerfil)
        {
            try
            {
                string restResource = "/Perfil/eliminar?IdPerfil=" + IdPerfil;
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
