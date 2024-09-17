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
    public class LineaController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public LineaController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Linea/listar";
            var model = await this.carrefourApiService.RequestGet<List<LineaModel>>(restResource);

            return View(model);
        }

        public async Task<IActionResult> ListarLineasParaCombos()
        {
            string restResource = "/Linea/listar";

            var model = await this.carrefourApiService.RequestGet<List<LineaModel>>(restResource);
            return Json(model);
        }


        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(LineaModel model)
        {
            try
            {
                string restResource = "/Linea/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] LineaModel model)
        {
            try
            {
                string restResource = "/Linea/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        public async Task<IActionResult> Editar(int lineaId)
        {
            string restResource = "/Linea/" + lineaId;
            LineaModel model = await carrefourApiService.RequestGet<LineaModel>(restResource);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(LineaModel model)
        {
            try
            {
                string restResource = "/Linea/editar";
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
                string restResource = "/Linea/eliminar?Id=" + Id;
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
