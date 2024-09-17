using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using FrontEnd.Carrefour.Models;
using FrontEnd.Carrefour.Service;

namespace FrontEnd.Carrefour.Controllers
{
    public class SubLineaController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public SubLineaController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/SubLinea/listar";
            var model = await this.carrefourApiService.RequestGet<List<SubLineaModel>>(restResource);

            return View(model);
        }

        public async Task<IActionResult> ListarSubLineasParaCombos()
        {
            string restResource = "/SubLinea/listar";
            
            var model = await this.carrefourApiService.RequestGet<List<SubLineaModel>>(restResource);
            return Json(model);
        }


        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(SubLineaModel model)
        {
            try
            {
                string restResource = "/SubLinea/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] SubLineaModel model)
        {
            try
            {
                string restResource = "/SubLinea/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        public async Task<IActionResult> Editar(int subLineaId)
        {
            string restResource = "/SubLinea/" + subLineaId;
            SubLineaModel model = await carrefourApiService.RequestGet<SubLineaModel>(restResource);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(SubLineaModel model)
        {
            try
            {
                string restResource = "/SubLinea/editar";      
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
                string restResource = "/SubLinea/eliminar?Id=" + Id;
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
