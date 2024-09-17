using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormaPagoController : Controller
    {
        private readonly FormaPagoService service;
        public FormaPagoController(FormaPagoService formaPagoService)
        {
            this.service = formaPagoService;
        }

        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{IdFormaPago}")]
        public JsonResult Obtener(int IdFormaPago)
        {
            var result = this.service.Obtener(IdFormaPago);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(FormaPagoModel formaPago)
        {
            try
            {
                service.Guardar(formaPago);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(FormaPagoModel formaPago)
        {
            try
            {
                service.Editar(formaPago);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(int IdFormaPago)
        {
            try
            {
                service.Eliminar(IdFormaPago);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
