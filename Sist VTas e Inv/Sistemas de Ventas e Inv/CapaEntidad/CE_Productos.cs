using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CE_Productos
    {
        private int _Id_Producto;
        private string _Codigo;
        private string _Nombre;
        private string _Descripcion;
        private string _Presentacion;
        private decimal _Costo_Unitario;
        private decimal _Precio_Venta;
        private string _Tipo_Cargo;
        private string _Buscar;

        public int Id_Producto { get => _Id_Producto; set => _Id_Producto = value; }
        public string Codigo { get => _Codigo; set => _Codigo = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public string Presentacion { get => _Presentacion; set => _Presentacion = value; }
        public decimal Costo_Unitario { get => _Costo_Unitario; set => _Costo_Unitario = value; }
        public decimal Precio_Venta { get => _Precio_Venta; set => _Precio_Venta = value; }
        public string Tipo_Cargo { get => _Tipo_Cargo; set => _Tipo_Cargo = value; }
        public string Buscar { get => _Buscar; set => _Buscar = value; }
    }
}
