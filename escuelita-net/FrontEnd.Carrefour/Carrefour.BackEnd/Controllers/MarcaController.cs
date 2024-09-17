using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MarcaController : ControllerBase
    {
        private readonly MarcaService service;
        public MarcaController(MarcaService marcaService)
        {
            this.service = marcaService;
        }

        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{marcaId}")]
        public JsonResult Obtener(int marcaId)
        {
            var result = this.service.Obtener(marcaId);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(MarcaModel marca)
        {
            try
            {
                service.Guardar(marca);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(MarcaModel marca)
        {
            try
            {
              service.Editar(marca);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int marcaId)
        {
            try
            {
                service.Eliminar(marcaId);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
