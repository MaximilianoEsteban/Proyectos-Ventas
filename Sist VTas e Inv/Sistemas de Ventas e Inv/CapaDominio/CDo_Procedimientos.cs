using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDominio
{
    public class CDo_Procedimientos
    {
        CD_Procedimientos ObjProcedimientos = new CD_Procedimientos();


        //Metodo que permite cargar los datos de una a tabla a un DataGridView
        public DataTable CargarDatos(string Tabla)
        {
            return ObjProcedimientos.CargarDatos(Tabla);
        }

        //Metodo que permite alternar los colores en las filas de un DataGridView
        public void AlternarColorFilaDataGridView(DataGridView Dgv)
        {
            ObjProcedimientos.AlternarColorFilaDataGridView(Dgv);
        }

        public string GenerarCodigo(string Tabla)
        {
           return ObjProcedimientos.GenerarCodigo(Tabla);

        }

        public string GenerarCodigoId(string Tabla)
        {
            return ObjProcedimientos.GenerarCodigoId(Tabla);
        }

        // Metodo que permite dar formato moneda a un TextBox
        public void FormatoMoneda(TextBox xTBox)
        {
            ObjProcedimientos.FormatoMoneda(xTBox);
        }

        // Metodo que permite limpiar un TextBox
        public void LimpiarControles(Form xForm)
        {
            ObjProcedimientos.LimpiarControles(xForm);
        }

        // Metodo que permite llenar un ComboBox
        public void LlenarComboBox(string Tabla, string Nombre, ComboBox xCBox)
        {
            ObjProcedimientos.LlenarComboBox(Tabla, Nombre, xCBox); 
        }
    }
}
