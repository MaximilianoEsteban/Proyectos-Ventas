using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TipoController : Controller
    {
        private readonly TipoService service;
        public TipoController(TipoService tipoService)
        {
            this.service = tipoService;
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
        public void Guardar(TipoModel tipo)
        {
            try
            {
                service.Guardar(tipo);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(TipoModel tipo)
        {
            try
            {
                service.Editar(tipo);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int tipoId)
        {
            try
            {
                service.Eliminar(tipoId);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
