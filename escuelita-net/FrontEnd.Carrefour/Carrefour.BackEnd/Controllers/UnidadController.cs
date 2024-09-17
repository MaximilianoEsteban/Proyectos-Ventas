using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnidadController : Controller
    {
        private readonly UnidadService service;
        public UnidadController(UnidadService unidadService)
        {
            this.service = unidadService;
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
        public void Guardar(UnidadModel unidad)
        {
            try
            {
                service.Guardar(unidad);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(UnidadModel unidad)
        {
            try
            {
                service.Editar(unidad);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int unidadId)
        {
            try
            {
                service.Eliminar(unidadId);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
