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
    public class ProductoController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public ProductoController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;

        }

        public async Task<IActionResult> Lista()
        {
            string restResource = "/Producto/listar";
            var model = await this.carrefourApiService.RequestGet<List<ProductoModel>>(restResource);

            return View(model);
        }

        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Agregar(ProductoModel model)
        {
            try
            {
                string restResource = "/Producto/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> AgregarAjaxPost([FromBody]ProductoModel model)
        {
            try
            {
                string restResource = "/Producto/guardar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpGet]
        public async Task<IActionResult> Editar(int productoId)
        {
            string restResource = "/Producto/" + productoId;
            ProductoModel model = await carrefourApiService.RequestGet<ProductoModel>(restResource);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Editar(ProductoModel model)
        {
            try
            {
                string restResource = "/Producto/editar";

                string jsonResponse = await carrefourApiService.RequestPost(restResource, model);

                return RedirectToAction("Lista");
            }
            catch (Exception ex)
            {

                throw;
            }

        }

        [HttpPost]
        public async Task<IActionResult> Eliminar([FromBody]int productoId)
        {
            try
            {
                string restResource = "/Producto/eliminar?productoId=" + productoId;

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
