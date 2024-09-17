namespace Carrefour.BackEnd.Models
{
    public class SubLineaModel
    {
        public int Id { get; set; }
        public int LineaId { get; set; }
        public string DescripcionLinea { get; set; }
        public string Nombre { get; set; }
    }
}
