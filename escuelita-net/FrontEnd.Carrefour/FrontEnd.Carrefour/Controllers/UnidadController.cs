using FrontEnd.Carrefour.Models;
using FrontEnd.Carrefour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FrontEnd.Carrefour.Controllers
{
    public class UnidadController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public UnidadController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Unidad/listar";
            var model = await this.carrefourApiService.RequestGet<List<UnidadModel>>(restResource);
            return View(model);
        }

        public async Task<IActionResult> ListarUnidadesParaCombos()
        {
            string restResource = "/Unidad/listar";
            var model = await this.carrefourApiService.RequestGet<List<UnidadModel>>(restResource);
            return Json(model);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(UnidadModel model)
        {
            try
            {
                string restResource = "/Unidad/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] UnidadModel model)
        {
            try
            {
                string restResource = "/Unidad/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int unidadId)
        {
            string restResource = "/Unidad/" + unidadId;
            UnidadModel model = await carrefourApiService.RequestGet<UnidadModel>(restResource);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(UnidadModel model)
        {
            try
            {
                string restResource = "/Unidad/editar";
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
                string restResource = "/Unidad/eliminar?Id=" + Id;
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
