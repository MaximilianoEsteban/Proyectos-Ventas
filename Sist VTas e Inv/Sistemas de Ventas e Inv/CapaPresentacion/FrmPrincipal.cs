using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }        

        private void tmTiempo_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void productos_Click(object sender, EventArgs e)
        {
            frmProductos Productos = new frmProductos();
            Productos.ShowDialog();
        }

        private void inventario_Click(object sender, EventArgs e)
        {
            frmInventario Inventario = new frmInventario();
            Inventario.ShowDialog();
        }
    }
}
