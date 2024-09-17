using FrontEnd.Carrefour.Service;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using FrontEnd.Carrefour.Models;

namespace FrontEnd.Carrefour.Controllers
{
    public class FormaPagoController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public FormaPagoController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/FormaPago/listar";
            var model = await this.carrefourApiService.RequestGet<List<FormaPagoModel>>(restResource);

            return View(model);
        }

        public async Task<IActionResult> ListarFormasdePagoParaCombos()
        {
            string restResource = "/FormaPago/listar";

            var model = await this.carrefourApiService.RequestGet<List<FormaPagoModel>>(restResource);
            return Json(model);
        }


        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(FormaPagoModel model)
        {
            try
            {
                string restResource = "/FormaPago/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] FormaPagoModel model)
        {
            try
            {
                string restResource = "/FormaPago/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        public async Task<IActionResult> Editar(int IdFormaPago)
        {
            string restResource = "/FormaPago/" + IdFormaPago;
            FormaPagoModel model = await carrefourApiService.RequestGet<FormaPagoModel>(restResource);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(FormaPagoModel model)
        {
            try
            {
                string restResource = "/FormaPago/editar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody] int IdFormaPago)
        {
            try
            {
                string restResource = "/FormaPago/eliminar?IdFormaPago=" + IdFormaPago;
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
