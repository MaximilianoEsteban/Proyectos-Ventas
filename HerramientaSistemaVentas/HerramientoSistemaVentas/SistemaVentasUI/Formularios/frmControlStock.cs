using SistemaVentasUI.Logica;
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
    public partial class frmControlStock : Form
    {
        public bool sumar { get; set; }

        public int id { get; set; }
        public string codigo { get; set; }
        public string descripcion { get; set; }
        public int stock { get; set; }

        public int nuevo_stock { get; set; }
        public frmControlStock()
        {
            InitializeComponent();
        }

        private void frmControlStock_Load(object sender, EventArgs e)
        {
            txtcodigo.Text = codigo;
            txtdescripcion.Text = descripcion;
            txtstockactual.Text = stock.ToString();

            lbltexto.Text = sumar ? "Agregar al stock:" : "Restar al stock:";
            lbltitulo.Text = sumar ? "Agregar stock" : "Restar stock";

            txtagregar.Select();
        }

        private void btnvolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnguardar_Click(object sender, EventArgs e)
        {
            int agregar = Convert.ToInt32(txtagregar.Value.ToString());
            int total = 0;

            if (!sumar && (agregar > stock))
            {
                lblresultado1.Visible = true;
                lblresultado1.Text = "El resultado no puede ser menos cero";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (sumar)
            {
                total = stock + agregar;
            }
            else
            {
                total = stock - agregar;
            }

            int respuesta = LO_Producto.Instancia.Control(id, Convert.ToInt32(txtagregar.Value.ToString()), sumar);
            if (respuesta > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.nuevo_stock = total;
                this.Close();
            }
            else {
                lblresultado1.Visible = true;
                lblresultado1.Text = "No se pudo actualizar el stock";
                lblresultado1.ForeColor = Color.Red;
            }
   
            
        }

       

        private void txtagregar_KeyUp(object sender, KeyEventArgs e)
        {

            int total = 0;

            try
            {
                int agregar = Convert.ToInt32(txtagregar.Value.ToString());



                if (sumar)
                {
                    total = stock + agregar;
                }
                else
                {

                    if (agregar > stock)
                    {
                        lblresultado1.Visible = true;
                        lblresultado1.Text = "El resultado no puede ser menos cero";
                        lblresultado1.ForeColor = Color.Red;
                    }
                    else
                    {
                        total = stock - agregar;
                        lblresultado1.Visible = false;
                    }


                }

            }catch{
                lblresultado1.Visible = true;
                lblresultado1.Text = "El numero supero lo permitido";
                lblresultado1.ForeColor = Color.Red;
            }

            txtnuevostock.Text = total.ToString();
        }
    }
}
