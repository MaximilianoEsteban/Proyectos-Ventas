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
    public partial class FrmAgregarProducto : FormBase
    {
        public FrmAgregarProducto(frmProductos Productos)
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
        
        protected void Agregar()
        {
            UpdateEventArgs args = new UpdateEventArgs();
            UpdateEventHandler.Invoke(this, args);
        }

        private void FrmAgregarProducto_Load(object sender, EventArgs e)
        {
            GenerarCodigo();
        }

        private void GenerarCodigo()
        {
            txtCodProducto.Text = "PROD" + Procedimimientos.GenerarCodigo("Productos");
        }

        private void txtNomProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == Convert.ToChar(Keys.Enter))
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
                btnAgregar.Focus();
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        public override bool Guardar()
        {
            try
            {
                if (txtCodProducto.Text == string.Empty || txtNomProducto.Text == string.Empty || txtDescProducto.Text == string.Empty ||
                    txtPresentProducto.Text == string.Empty || txtCostoUnitario.Text == string.Empty || txtPrecioVenta.Text == string.Empty ||
                    cboTipoCargo.Text == string.Empty)
                {
                    MessageBox.Show("Por favor completar el campo", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Producto.Codigo = txtCodProducto.Text.Trim();
                    Producto.Nombre = txtNomProducto.Text.Trim();
                    Producto.Descripcion = txtDescProducto.Text.Trim();
                    Producto.Presentacion = txtPresentProducto.Text.Trim();
                    Producto.Costo_Unitario = Convert.ToDecimal(txtCostoUnitario.Text.Trim());
                    Producto.Precio_Venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim());
                    Producto.Tipo_Cargo = cboTipoCargo.Text.Trim();

                    Productos.AgregarProducto(Producto);
                    MessageBox.Show("El Producto fue agregado correctamente!!", "Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Procedimimientos.LimpiarControles(this);
                    GenerarCodigo();
                    txtNomProducto.Focus();
                    Agregar();
                    return true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El registro no fue creado por: " +ex.Message,"Agregar Producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }
    }
}
