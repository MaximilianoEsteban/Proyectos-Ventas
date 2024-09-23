using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaVentasASPNET_MVC.Areas.Clientes.Models
{
    public class InputModelRegister
    {
        [Required(ErrorMessage = "El campo nid es obligatorio.")]
        public string NID { set; get; }
        [Required(ErrorMessage = "El campo nombre es obligatorio.")]
        public string Nombre { set; get; }
        [Required(ErrorMessage = "El campo apellido es obligatorio.")]
        public string Apellido { set; get; }
        [Required(ErrorMessage = "El campo email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El correo electrónico no es una dirección de correo electrónico válida.")]
        public string Email { set; get; }
        [Required(ErrorMessage = "El campo direccion es obligatorio.")]
        public string Direccion { set; get; }
        [Required(ErrorMessage = "El campo telefono es obligatorio.")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{2})\)?[-. ]?([0-9]{2})[-. ]?([0-9]{5})$", ErrorMessage = "El formato telefono ingresado no es válido.")]
        public string Telefono { set; get; }
        [Required(ErrorMessage = "El campo fecha es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime Fecha { set; get; }
        public bool Credito { set; get; }
        public byte[] Image { get; set; }
        public int IdCliente { set; get; }
        [TempData]
        public string ErrorMessage { get; set; }
    }
}
