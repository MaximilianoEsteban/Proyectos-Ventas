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
    public partial class frmProductos : FormBase
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        CDo_Procedimientos Procedimientos = new CDo_Procedimientos();


        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarDatos();

            dataGridView1.Columns[0].Visible = false; // Id Producto
            dataGridView1.Columns[1].Width = 140; // Codigo Producto
            dataGridView1.Columns[2].Width = 260; // Nombre Producto
            dataGridView1.Columns[3].Width = 300; // Descripcion Producto
            dataGridView1.Columns[4].Width = 150; // Presentacion Producto
            dataGridView1.Columns[5].Width = 140; // Costo unitario Producto
            dataGridView1.Columns[6].Width = 140; // Precio venta Producto
            dataGridView1.Columns[7].Width = 150; // Tipo cargo Producto

            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.Columns[5].DefaultCellStyle.Format = "#,##0.00";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "#,##0.00";

            Procedimientos.AlternarColorFilaDataGridView(dataGridView1);

        }

        private void CargarDatos()
        {
            dataGridView1.DataSource = Procedimientos.CargarDatos("Productos");
            dataGridView1.ClearSelection();
        }

        private void AgPro_UpdateEventHandler(object sender, FrmAgregarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void EdPro_UpdateEventHandler(object sender, FrmEditarProducto.UpdateEventArgs args)
        {
            CargarDatos();
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            FrmAgregarProducto AgregarProducto = new FrmAgregarProducto(this);
            AgregarProducto.UpdateEventHandler += AgPro_UpdateEventHandler;
            AgregarProducto.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("No hay registro para editar", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    if (dataGridView1.SelectedRows == null)
                    {
                        return;
                    }
                    else
                    {
                        FrmEditarProducto EditarProducto = new FrmEditarProducto(this);
                        EditarProducto.UpdateEventHandler += EdPro_UpdateEventHandler;
                        EditarProducto.txtId_Producto.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                        EditarProducto.txtCodProducto.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                        EditarProducto.txtNomProducto.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                        EditarProducto.txtDescProducto.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                        EditarProducto.txtPresentProducto.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                        EditarProducto.txtCostoUnitario.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        EditarProducto.txtPrecioVenta.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                        EditarProducto.cboTipoCargo.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                        EditarProducto.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Debe seleccionar una fila con datos", "Editar Producto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        public override void Eliminar()
        {
            
        }
    }
}
