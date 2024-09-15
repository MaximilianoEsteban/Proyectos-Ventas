using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SistemaVentasUI.Modales;
using SistemaVentasUI.Formularios;
using System.Globalization;
using SistemaVentasUI.Modelo;
using SistemaVentasUI.Logica;

namespace SistemaVentasUI
{
    public partial class Form1 : Form
    {
        public Usuario ousuario { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void stockmininmo() {
            lblstockminimo.Visible = false;
            if (ousuario.IdRol == 1)
            {
                //notifyIcon1.BalloonTipTitle = "Alerta de Stock";
                //notifyIcon1.BalloonTipText = "Hay algunos productos que cumplen con el stock minimo";
                //notifyIcon1.Text = "Alerta de stock";
                //notifyIcon1.Visible = true;
                //notifyIcon1.ShowBalloonTip(0);
                string msg = string.Empty;
                int prds = LO_Producto.Instancia.Listar(out msg).Where(p => p.Stock <= p.StockMinimo).Count();

                if (prds > 0)
                {
                    lblstockminimo.Visible = true;
                    lblstockminimo.Text = "Hay algunos productos que cumplen con el stock minimo";
                }

            }

        }

        private void Frm_Closing(object sender, FormClosedEventArgs e)
        {


            stockmininmo();

            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal tt = Convert.ToDecimal("245.45",new CultureInfo("es-PE"));
            string tset =  string.Format(new CultureInfo("es-PE"),"{0:0.0}0", tt); // "256.58"
            string tset1 =  string.Format("{0:0.00}", tt); // "256.58"

            string tset2 = tt.ToString("{0:0.0}", new CultureInfo("es-PE"));

            DateTime dateTime = DateTime.UtcNow.Date;
            lblfecha.Text = dateTime.ToString("dd/MM/yyyy");

            lblnombre.Text = ousuario.NombreCompleto;
            lblusuario.Text = ousuario.NombreUsuario;

            if (ousuario.IdRol != 1) {
                btnproductos.Enabled = false;
                btnreportes.Enabled = false;
                btnusuarios.Enabled = false;
                btnconfiguracion.Enabled = false;
            }

            stockmininmo();
        }

        private void btnproductos_Click(object sender, EventArgs e)
        {

            using (var Iform = new mdProducto())
            {

                Iform.ShowInTaskbar = false;
                var result = Iform.ShowDialog();
                if (result == DialogResult.OK)
                {
                    Form MostrarFormulario = Iform.MostrarFormulario;
                    this.Hide();
                    MostrarFormulario.Show();
                    MostrarFormulario.FormClosed += Frm_Closing;
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frmNuevaVenta FormularioVista = new frmNuevaVenta();
            FormularioVista.ousuario = this.ousuario;
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosed += Frm_Closing;
        }

        private void btnconfiguracion_Click(object sender, EventArgs e)
        {
            frmConfiguracion FormularioVista = new frmConfiguracion();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosed += Frm_Closing;
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            frmBusqueda FormularioVista = new frmBusqueda();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosed += Frm_Closing;
        }

        private void btnusuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios FormularioVista = new frmUsuarios();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosed += Frm_Closing;
        }

        private void btnreportes_Click(object sender, EventArgs e)
        {
            frmReporte FormularioVista = new frmReporte();
            this.Hide();
            FormularioVista.Show();
            FormularioVista.FormClosed += Frm_Closing;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btninfo_Click(object sender, EventArgs e)
        {
            if (ousuario.NombreUsuario == "CodigoEstudiante" && ousuario.Clave == "12345")
            {
                System.Diagnostics.Process.Start("https://ouo.io/RtEfXgd");
            }

            //
            mdAcercaDe form = new mdAcercaDe();
            form.ShowDialog();
        }
    }
}
