using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Services;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResetPasswordController : Controller
    {
        private readonly UsuarioService service;
        public ResetPasswordController(UsuarioService usuarioService)
        {
            this.service = usuarioService;
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
    }
}
