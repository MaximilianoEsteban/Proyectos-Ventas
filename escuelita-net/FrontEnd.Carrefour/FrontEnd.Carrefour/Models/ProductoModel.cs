using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FrontEnd.Carrefour.Models
{
    public class ProductoModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int? MarcaId { get; set; }
        public string NombreMarca { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public int? TipoId { get; set; }
        public string NombreTipo { get; set; }
        public int UnidadId { get; set; }

        public string Descripcion { get; set; }

    }
}
