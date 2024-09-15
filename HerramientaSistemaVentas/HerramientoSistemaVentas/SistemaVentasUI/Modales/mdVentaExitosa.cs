using SistemaVentasUI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Modales
{
    public partial class mdVentaExitosa : Form
    {
        public string _numerodocumento { get; set; }
        public mdVentaExitosa()
        {
            InitializeComponent();
        }

        private void mdVentaExitosa_Load(object sender, EventArgs e)
        {
            txtnumerodocumento.Text = _numerodocumento;
            txtnumerodocumento.Focus();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtnumerodocumento.Text);
            this.Close();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            frmImprimir frm = new frmImprimir();
            frm.numerodocumento = _numerodocumento;
            frm.Show();
            this.Close();
        }
    }
}
