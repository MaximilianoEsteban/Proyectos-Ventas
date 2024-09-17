using FrontEnd.Carrefour.Models;
using FrontEnd.Carrefour.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace FrontEnd.Carrefour.Controllers
{
    public class MarcaController  : Controller
    {
        private readonly CarrefourApiService carrefourApiService;

        public MarcaController (CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;
        }
    
        public async Task<IActionResult> Lista()
        {
            string restResource = "/Marca/listar";
            var model = await this.carrefourApiService.RequestGet<List<MarcaModel>>(restResource);

            return View(model);

        }


        public async Task<IActionResult> ListarMarcasParaCombos()
        {
            string restResource = "/Marca/listar";
            
            var model = await this.carrefourApiService.RequestGet<List<MarcaModel>>(restResource);

            return Json(model);
            
        }



        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(MarcaModel model)
        {
            try
            {
                string restResource = "/Marca/guardar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody] MarcaModel model)
        {
            try
            {
                string restResource = "/Marca/guardar";
                HttpClient client = new HttpClient();
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }


        [HttpGet]

        public async Task<IActionResult> Editar(int marcaId)
        {
            string restResource = "/Marca/" + marcaId;
            MarcaModel model = await carrefourApiService.RequestGet<MarcaModel>(restResource);

            return View(model);
        }

        public async Task<IActionResult> EditarMarcasParaCombos()
        {
            string restResource = "/Marca/listar";

            var model = await this.carrefourApiService.RequestGet<MarcaModel>(restResource);
            return View(model);
        }

        [HttpPost]

        public async Task<IActionResult> Editar(MarcaModel model)
        {
            try
            {
                string restResource = "/Marca/Editar";
                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody] int marcaId)
        {
            try
            {
                string restResource = "/Marca/eliminar?marcaId=" + marcaId;
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
