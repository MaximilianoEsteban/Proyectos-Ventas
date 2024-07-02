using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaEntidad;

namespace CapaPresentacion
{
    public partial class FrmEditarProducto : FormBase
    {
        public FrmEditarProducto(frmProductos Productos)
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimimientos = new CDo_Procedimientos();
        CDo_Productos Productos = new CDo_Productos();
        CE_Productos Producto = new CE_Productos();
        private frmProductos frmProductos;

        public delegate void UpdateDelegate(object sender, UpdateEventArgs args);
        public event UpdateDelegate UpdateEventHandler;

        public class UpdateEventArgs : EventArgs
        {
            public string Data { get; set; }
        }

        protected void Actualizar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {

        }

        private void txtNomProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtDescProducto.Focus();
                e.Handled = true;
            }
        }

        private void txtDescProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPresentProducto.Focus();
                e.Handled = true;
            }
        }

        private void txtPresentProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtCostoUnitario.Focus();
                e.Handled = true;
            }
        }

        private void txtCostoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txtPrecioVenta.Focus();
                e.Handled = true;
            }
        }

        private void txtCostoUnitario_Leave(object sender, EventArgs e)
        {
            Procedimimientos.FormatoMoneda(txtCostoUnitario);
        }

        private void txtPrecioVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cboTipoCargo.Focus();
                e.Handled = true;
            }
        }

        private void txtPrecioVenta_Leave(object sender, EventArgs e)
        {
            Procedimimientos.FormatoMoneda(txtPrecioVenta);
        }

        private void cboTipoCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnEditar.Focus();
                e.Handled = true;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        public override void Editar()
        {
            try
            {
                if (txtCodProducto.Text == string.Empty || txtNomProducto.Text == string.Empty || txtDescProducto.Text == string.Empty ||
                    txtPresentProducto.Text == string.Empty || txtCostoUnitario.Text == string.Empty || txtPrecioVenta.Text == string.Empty ||
                    cboTipoCargo.Text == string.Empty)
                {
                    MessageBox.Show("Por favor completar el campo", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Producto.Id_Producto = Convert.ToInt32(txtId_Producto.Text.Trim());
                    Producto.Codigo = txtCodProducto.Text.Trim();
                    Producto.Nombre = txtNomProducto.Text.Trim();
                    Producto.Descripcion = txtDescProducto.Text.Trim();
                    Producto.Presentacion = txtPresentProducto.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = cboTipoCargo.Text.Trim();

                    Productos.EditarProducto(Producto);
                    MessageBox.Show("El Producto fue editado correctamente!!", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);     
                    
                    this.Close();
                    Actualizar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no fue editado por: " + ex.Message, "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
