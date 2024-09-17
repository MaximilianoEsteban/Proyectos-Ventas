using Carrefour.BackEnd.Interfaces;
using Carrefour.BackEnd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System.Net.Mail;
using System.Threading.Tasks;
using System;
using Carrefour.BackEnd.Services;
using System.Security.Cryptography.X509Certificates;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EnviarMailController : Controller
    {
        private readonly IEmailSender _emailSender;
        public EnviarMailController(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }       

        [HttpGet]        
        [Route("enviarMail")]
        public async Task<IActionResult> EnviarMail(string IdUsuario)
        {
            await _emailSender
                .SendEmailAsync("emaximiliano739@gmail.com", "Asunto", "Mensaje")
                .ConfigureAwait(false);            

            return Json(new {success=true});
        }

       
        [HttpPost]
        [Route("")]
        public void EnviarMail(MailModel mailModel)
        {
            try
            {
                _emailSender.SendEmailAsync(mailModel.email, mailModel.subject, mailModel.message);
            }
            catch (System.Exception ex)
            {
                throw;
            }
        }        
    }
}
