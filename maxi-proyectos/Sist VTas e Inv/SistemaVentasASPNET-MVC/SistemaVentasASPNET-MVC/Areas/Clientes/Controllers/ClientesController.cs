using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SistemaVentasASPNET_MVC.Data;
using SistemaVentasASPNET_MVC.Library;
using SistemaVentasASPNET_MVC.Models;
using System.Collections.Generic;
using System;
using SistemaVentasASPNET_MVC.Areas.Clientes.Models;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Controllers
{
    [Authorize]
    [Area("Clientes")]
    public class ClientesController : Controller
    {
        private LCustomers _customer;
        private SignInManager<IdentityUser> _signInManager;
        private static DataPaginador<InputModelRegister> models;

        public ClientesController(
           SignInManager<IdentityUser> signInManager,
           ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _customer = new LCustomers(context);
        }
        public IActionResult Clientes(int id, String filtrar)
        {
            if (_signInManager.IsSignedIn(User))
            {
                Object[] objects = new Object[3];
                var data = _customer.getTClients(filtrar, 0);
                if (0 < data.Count)
                {
                    var url = Request.Scheme + "://" + Request.Host.Value;
                    objects = new LPaginador<InputModelRegister>().paginador(data,
                        id, 10, "Clientes", "Clientes", "Clientes", url);
                }
                else
                {
                    objects[0] = "No hay datos que mostrar";
                    objects[1] = "Su busqueda no arrojo resultados";
                    objects[2] = new List<InputModelRegister>();
                }
                models = new DataPaginador<InputModelRegister>
                {
                    List = (List<InputModelRegister>)objects[2],
                    Pagi_info = (String)objects[0],
                    Pagi_navegacion = (String)objects[1],
                    Input = new InputModelRegister(),
                };
                return View(models);
            }
            else
            {
                return Redirect("/");
            }

        }
    }
}
