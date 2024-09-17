using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LineaController : Controller
    {
        private readonly LineaService service;
        public LineaController(LineaService lineaService)
        {
            this.service = lineaService;
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
        public void Guardar(LineaModel linea)
        {
            try
            {
                service.Guardar(linea);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(LineaModel linea)
        {
            try
            {
                service.Editar(linea);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int lineaId)
        {
            try
            {
                service.Eliminar(lineaId);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
