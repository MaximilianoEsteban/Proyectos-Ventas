using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PerfilController : Controller
    {
        private readonly PerfilService service;
        public PerfilController(PerfilService perfilService)
        {
            this.service = perfilService;
        }

        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{IdPerfil}")]
        public JsonResult Obtener(string IdPerfil)
        {
            var result = this.service.Obtener(IdPerfil);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(PerfilModel perfil)
        {
            try
            {
                service.Guardar(perfil);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(PerfilModel perfil)
        {
            try
            {
                service.Editar(perfil);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(string IdPerfil)
        {
            try
            {
                service.Eliminar(IdPerfil);
            }
            catch (System.Exception ex)
            {

                throw;
            }
        }
    }
}
