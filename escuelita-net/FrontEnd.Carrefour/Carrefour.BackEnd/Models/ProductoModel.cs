using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Carrefour.BackEnd.Models
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
