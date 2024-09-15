using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaVentasUI.Formularios;

namespace SistemaVentasUI.Modales
{
    public partial class mdProducto : Form
    {
        public Form MostrarFormulario { get; set; }

        public mdProducto()
        {
            InitializeComponent();
        }

        private void mdProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {
            MostrarFormulario = new frmProducto ();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            MostrarFormulario = new frmCategoria();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btncargamasiva_Click(object sender, EventArgs e)
        {
            MostrarFormulario = new frmCargaMasiva();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
