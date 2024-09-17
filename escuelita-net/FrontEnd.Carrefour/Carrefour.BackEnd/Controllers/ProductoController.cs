using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductoController : ControllerBase
    {
        private readonly ProductoService service;
        public ProductoController(ProductoService productoService) 
        {
            this.service = productoService;
        }


        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{productoId}")]
        public JsonResult Obtener(int productoId)
        {
            var result = this.service.Obtener(productoId);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(ProductoModel producto)
        {
            try
            {
                service.Guardar(producto);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(ProductoModel producto)
        {
            try
            {
                service.Editar(producto);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int productoId)
        {
            try
            {
                service.Eliminar(productoId);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
