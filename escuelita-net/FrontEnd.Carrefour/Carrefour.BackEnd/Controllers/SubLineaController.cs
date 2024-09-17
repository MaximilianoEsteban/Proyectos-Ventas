using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubLineaController : Controller
    {
        private readonly SubLineaService service;
        public SubLineaController(SubLineaService subLineaService)
        {
            this.service = subLineaService;
        }

        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{Id}")]
        public JsonResult Obtener(int Id)
        {
            var result = this.service.Obtener(Id);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(SubLineaModel subLinea)
        {
            try
            {
                service.Guardar(subLinea);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(SubLineaModel SubLinea)
        {
            try
            {
                service.Editar(SubLinea);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int Id)
        {
            try
            {
                service.Eliminar(Id);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
