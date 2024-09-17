using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Formularios
{
    public partial class frmCancelarVenta : Form
    {
        public int IdVenta { get; set; }
        public string numerodocumento { get; set; }
        public List<DetalleVenta> odetalleventa { get; set; }
        public string mensaje_eliminar { get; set; }

        public frmCancelarVenta()
        {
            InitializeComponent();
        }

        private void frmCancelarVenta_Load(object sender, EventArgs e)
        {
            lblcancelarventa.Text = string.Format("¿Desea cancelar la venta {0}?", numerodocumento);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.None;
            this.Close();
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            int operaciones = LO_Venta.Instancia.cancelar_venta(IdVenta, odetalleventa, out mensaje);
            if (operaciones > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else {
                mensaje_eliminar = mensaje;
                this.Close();
            }

        }
    }
}
