using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Claims;
using System.Security.Principal;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Castle.Components.DictionaryAdapter.Xml;
using Castle.Core.Smtp;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Routing;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Bcpg.OpenPgp;
using PuntoDeVenta.Models;
using PuntoDeVenta.Service;
using static System.Net.WebRequestMethods;

namespace PuntoDeVenta.Controllers
{
    public class AccountController : Controller
    {
        private readonly CarrefourApiService carrefourApiService;
        public AccountController(CarrefourApiService carrefourApiService)
        {
            this.carrefourApiService = carrefourApiService;            
        }       

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpGet]
        public ActionResult RegisterSuccess()
        {
            return View(); // La vista de register success tiene solo un texto que dice que el usuiario se registro con exito
        }

        [HttpGet]
        public ActionResult ResetPasswordVencido()
        {
            return View(); // La vista tiene solo un texto que dice que expiro el tiempo de reseteo de contraseña
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View(); // La vista de register contiene los campos de formulario para la tabla de usuario
        }

        [HttpPost]
        public async Task<IActionResult> Register(UsuarioModel usuario) 
        {
            
            var usuarioExistente =  await carrefourApiService.RequestGet<UsuarioModel>("/usuario/" + usuario.IdUsuario); // busco si ya existe un usuario con ese nombre
            if (usuarioExistente != null) {
                ModelState.AddModelError("Username", "Usuario ya existe");
                return View();
            } else {

                if (usuario.Password != usuario.Password1)
                {
                    ModelState.AddModelError("", "LA CONTRASEÑA Y LA CONFIRMACION INGRESADAS NO SON COINCIDENTES!!!.");
                    return View(usuario);
                }
                else
                {
                    await carrefourApiService.RequestPost("/usuario/guardar", usuario);
                }
            }
            return Redirect("RegisterSuccess");
        }
        
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel userToLogin)
        {
            try
            {
                // Buscar y validar usuario y credenciales aca
                if (!User.Identity.IsAuthenticated)
                {
                    //ValidarUsuario(userToLogin)

                    var usuario = await carrefourApiService.RequestGet<UsuarioModel>("/usuario/" + userToLogin.Username);
                    
                    if (usuario == null) {
                        throw new Exception("Usuario no valido");
                    }

                    if (usuario.Password != userToLogin.Password) {
                        throw new Exception("Usuario o contrasenia no valido");                        
                    }                   

                    var claims = new List<Claim>
                        {                
                            new Claim(ClaimTypes.Name, userToLogin.Username),
                            new Claim(ClaimTypes.GivenName, usuario.Nombre),
                            new Claim(ClaimTypes.Surname, usuario.Apellido),
                            new Claim("FullName", usuario.Apellido + ", " + usuario.Nombre),                            
                            new Claim(ClaimTypes.Role, usuario.NombrePerfil),
                            new Claim(ClaimTypes.Email, usuario.Email)

                        };

                    var claimsIdentity = new ClaimsIdentity(
                        claims, CookieAuthenticationDefaults.AuthenticationScheme);

                    var authProperties = new AuthenticationProperties
                    {    
                        RedirectUri = "/Home/Index",
                    };

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        new ClaimsPrincipal(claimsIdentity),
                        authProperties);

                    /* selector para logueo segun perfil*/

                    switch (usuario.IdPerfil)
                    {
                        case "1":
                            return Redirect("/Cliente/Index");
                         case "2":
                            return Redirect("/Empleado/Index");
                        case "3":
                            return Redirect("/Gerente/Index");
                        case "4":
                            return Redirect("/Administrador/Index");
                    }
                        return View();
                }
                else
                {
                    return Redirect("/Home/Index");
                }
            }
            catch (Exception e)
            {
                ViewData.ModelState.AddModelError("", $"Ocurrio un eror al iniciar sesion: {e.Message}");

                return View();
            }
        }

        [HttpGet]
        public ActionResult EnviarMail()
        {
            try
            {  
                return View();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<IActionResult> EnviarMail([FromForm]string IdUsuario)
        {     
            var usuario = await carrefourApiService.RequestGet<UsuarioModel>("/usuario/" + IdUsuario);
            var model = new MailModel();

            var userJason = new UsuarioModel 
            {
                IdUsuario = IdUsuario,
                FechaPassword = DateTime.Now
            };

            string json = JsonConvert.SerializeObject(userJason);


            string rutaEncriptamiento = "/EncriptarDesencriptar/encriptar?plainText=" +json;
            object encriptar = await carrefourApiService.RequestGet<object>(rutaEncriptamiento);
            string rutaUrl = @"<a href=https://localhost:64466/Account/ResetPassword?d=" + encriptar.ToString() + "> Link </a>";
            model.message = "Se ha solicitado resetear su contraseña, haga click en el siguiente" + rutaUrl;
            model.subject = "Solicitud de reseteo de contraseña";
            model.email = usuario.Email;
            await carrefourApiService.RequestPost("/EnviarMail", model);

            ViewData["MENSAJE"] = "email enviado a " + model.email;

            return View(usuario);
        }

        [HttpGet]
        public async Task<IActionResult> ResetPassword(string d)
        {
            string rutaDesencriptamiento = "/EncriptarDesencriptar/desencriptar?encryptedEncoded=" + d;
            string desencriptar = await carrefourApiService.RequestGet<string>(rutaDesencriptamiento);
            UsuarioModel jsUser = JsonConvert.DeserializeObject<UsuarioModel>(desencriptar.ToString());

            
            
            var fecha = jsUser.FechaPassword;
            var fechaCaducidad = fecha.AddHours(1);
            var fechaActual = DateTime.Now;
            
            if (fechaActual < fechaCaducidad)
                { 
                var usuario = await carrefourApiService.RequestGet<UsuarioModel>("/usuario/" + jsUser.IdUsuario);
                return View(usuario);
            }else
            {                
                return Redirect("/Account/ResetPasswordVencido");
            }            
        }

        [HttpPost]
        public async Task<IActionResult> ResetPassword(UsuarioModel model)
        {
            try
            {
                string restResource = "/Usuario/resetPassword";
                if (model.Password!=model.Password1)
                { 
                    ModelState.AddModelError("", "LA CONTRASEÑA Y LA CONFIRMACION INGRESADAS NO SON COINCIDENTES!!!.");
                    return View(model);
                }
                else
                {
                    string jsonResponse = await carrefourApiService.RequestPost(restResource, model);
                    return RedirectToAction("Login");
                }
            }
            catch (Exception e)
            {
                ViewData.ModelState.AddModelError("", $"Ocurrio un eror al iniciar sesion: {e.Message}");
                return View();
            }
        }

        [HttpGet]
        public async Task<RedirectResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/Account/Login");
        }
    }
}