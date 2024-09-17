using Carrefour.BackEnd.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace Carrefour.BackEnd.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EncriptarDesencriptarController : Controller
    {
        private readonly Helpers.AESEncrypter service;
        public EncriptarDesencriptarController(AESEncrypter encriptarDesencriptarService)
        {
            this.service = encriptarDesencriptarService;
        }

        [HttpGet]
        [Route("encriptar")]
        public JsonResult Encrypt128Base64UrlEncode(string plainText)
        {
            var result = this.service.Encrypt128Base64UrlEncode(plainText);
            return new JsonResult(result);
        }

        [HttpGet]
        [Route("desencriptar")]
        public JsonResult Decrypt128Base64UrlEncode(string encryptedEncoded)
        {
            var result = this.service.Decrypt128Base64UrlEncode(encryptedEncoded);
            return new JsonResult(result);
        }
    }
}
