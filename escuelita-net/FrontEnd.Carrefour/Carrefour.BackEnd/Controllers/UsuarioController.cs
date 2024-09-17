using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        private readonly UsuarioService service;
        public UsuarioController(UsuarioService usuarioService)
        {
            this.service = usuarioService;
        }

        [HttpGet]
        [Route("listar")]
        public JsonResult Listar()
        {
            var result = this.service.Listar();
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("{IdUsuario}")]
        public JsonResult Obtener(string IdUsuario)
        {
            var result = this.service.Obtener(IdUsuario);
            return new JsonResult(result);
        }

        [HttpPost]
        [Route("guardar")]
        public void Guardar(UsuarioModel usuario)
        {
            try
            {
                service.Guardar(usuario);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("editar")]
        public void Editar(UsuarioModel usuario)
        {
            try
            {
                service.Editar(usuario);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("editarPassword")]
        public void EditarPassword(UsuarioModel usuario)
        {
            try
            {
                service.EditarPassword(usuario);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [Route("resetPassword")]
        public void ResetPassword(UsuarioModel usuario)
        {
            try
            {
                service.ResetPassword(usuario);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }

        [HttpDelete]
        [Route("eliminar")]
        public void Eliminar(string IdUsuario)
        {
            try
            {
                service.Eliminar(IdUsuario);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }
    }
}
