using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ComprobanteController : Controller
    {
        private readonly ComprobanteService service;
        public ComprobanteController(ComprobanteService comprobanteService)
        {
            this.service = comprobanteService;
        }

        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{IdComprobante}")]
        public JsonResult Obtener(int IdComprobante)
        {
            var result = this.service.Obtener(IdComprobante);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(ComprobanteModel comprobante)
        {
            try
            {
                service.Guardar(comprobante);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(ComprobanteModel comprobante)
        {
            try
            {
                service.Editar(comprobante);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int IdComprobante)
        {
            try
            {
                service.Eliminar(IdComprobante);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
