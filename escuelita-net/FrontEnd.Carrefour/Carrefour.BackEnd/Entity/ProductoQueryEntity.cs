namespace Carrefour.BackEnd.Entity
{
    public class ProductoQueryEntity
    {
        public ProductoEntity Producto { get; set; }
        public MarcaEntity Marca { get; set; }
        public TipoEntity Tipo { get; set; }
        public UnidadEntity Unidad { get; set; }
    }
}
