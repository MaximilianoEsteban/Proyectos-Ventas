using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SistemaVentasASPNET_MVC.Areas.Clientes.Models;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Pages.Account
{
    public class RegisterModel : PageModel
    {
        public void OnGet()
        {
            Input = new InputModel
            {

            };
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel : InputModelRegister
        {
            public IFormFile AvatarImage { get; set; }
        }
    }
}
