using FrontEnd.Carrefour.Models;
using FrontEnd.Carrefour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Carrefour.Controllers
{
    public class TipoController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public TipoController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Tipo/listar";
            var model = await this.carrefourApiService.RequestGet<List<TipoModel>>(restResource);
            return View(model);
        }

        public async Task<IActionResult> ListarTiposParaCombos()
        {
            string restResource = "/Tipo/listar";
            var model = await this.carrefourApiService.RequestGet<List<TipoModel>>(restResource);
            return Json(model);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(TipoModel model)
        {
            try
            {
                string restResource = "/Tipo/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] TipoModel model)
        {
            try
            {
                string restResource = "/Tipo/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int tipoId)
        {
            string restResource = "/Tipo/" + tipoId;
            TipoModel model = await carrefourApiService.RequestGet<TipoModel>(restResource);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(TipoModel model)
        {
            try
            {
                string restResource = "/Tipo/editar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody] int Id)
        {
            try
            {
                string restResource = "/Tipo/eliminar?Id=" + Id;
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
