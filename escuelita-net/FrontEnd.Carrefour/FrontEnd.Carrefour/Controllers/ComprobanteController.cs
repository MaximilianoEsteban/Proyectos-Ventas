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
    public class ComprobanteController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public ComprobanteController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Comprobante/listar";
            var model = await this.carrefourApiService.RequestGet<List<ComprobanteModel>>(restResource);

            return View(model);
        }

        public async Task<IActionResult> ListarComprobantesParaCombos()
        {
            string restResource = "/Comprobante/listar";

            var model = await this.carrefourApiService.RequestGet<List<ComprobanteModel>>(restResource);
            return Json(model);
        }


        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(ComprobanteModel model)
        {
            try
            {
                string restResource = "/Comprobante/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] ComprobanteModel model)
        {
            try
            {
                string restResource = "/Comprobante/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public async Task<IActionResult> Editar(int IdComprobante)
        {
            string restResource = "/Comprobante/" + IdComprobante;
            ComprobanteModel model = await carrefourApiService.RequestGet<ComprobanteModel>(restResource);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(ComprobanteModel model)
        {
            try
            {
                string restResource = "/Comprobante/editar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody] int IdComprobante)
        {
            try
            {
                string restResource = "/Comprobante/eliminar?IdComprobante=" + IdComprobante;
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
