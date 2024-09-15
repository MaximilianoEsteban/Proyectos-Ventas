using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
using SistemaVentasUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Formularios
{
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {

            int x = 0;
            foreach (var item in Enum.GetNames(typeof(BarcodeLib.TYPE)))
            {
                cbotipobarra.Items.Add(new OpcionCombo() { Valor = x, Texto = item });
                x++;
            }
            
            cbotipobarra.DisplayMember = "Texto";
            cbotipobarra.ValueMember = "Valor";
            cbotipobarra.SelectedIndex = 0;

            mostrar_tipo_barra();
            mostrar_datos();
        }

        private void mostrar_datos() {

            bool obtenido = true;
            byte[] byteimage = LO_Dato.Instancia.ObtenerLogo(out obtenido);
            if (obtenido)
                picLogo.Image = Operaciones.ByteToImage(byteimage);


            Datos da = LO_Dato.Instancia.Obtener();
            txtrazonsocial.Text = da.RazonSocial;
            txtruc.Text = da.RUC;
            txtdireccion.Text = da.Direccion;
        }

        private void mostrar_tipo_barra() {

            TipoBarra objtipobarra = LO_TipoBarra.Instancia.ObtenerTipoBarra();
            int indexcombo = 0;
            if (objtipobarra.IdTipoBarra != 0)
            {
                int i = 0;
                foreach (OpcionCombo op in cbotipobarra.Items)
                {

                    if (Convert.ToInt32(op.Valor) == objtipobarra.Value)
                    {
                        indexcombo = i;
                        break;
                    }
                    i++;
                }
            }

            cbotipobarra.SelectedIndex = indexcombo;
        }

        private void mostrar_moneda_importe()
        {
            MonedaImporte obj = LO_MonedaImporte.Instancia.Obtener();
            if (obj != null)
            {
                txtsimbolo.Text = obj.Simbolo;
                txtporcentaje.Value = obj.Porcentaje;
            }
        }

        private void mostrar_correo()
        {
            Correo obj = LO_Correo.Instancia.ObtenerCorreo();
            if (obj != null)
            {
                txtemail.Text = obj.Email;
                txtclave.Text = obj.Clave;
            }
        }

        private void btnguardartipocodigo_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                int valor = Convert.ToInt32(((OpcionCombo)cbotipobarra.SelectedItem).Valor.ToString());

                int respuesta = LO_TipoBarra.Instancia.Guardar(valor, out mensaje);

                if (respuesta < 1)
                {
                    lblresultado2.Text = "No se pudo guardar el tipo";
                    lblresultado2.Visible = true;
                    lblresultado2.ForeColor = Color.Red;
                    return;
                }

                TipoBarraCodigo.TipoCodigo = (Enum.IsDefined(typeof(BarcodeLib.TYPE), valor)) ? ((BarcodeLib.TYPE)valor) : ((BarcodeLib.TYPE)0);

                
                lblresultado2.Text = "Se guardaron los cambios";
                lblresultado2.Visible = true;
                lblresultado2.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblresultado2.Text = "No se pudo guardar el tipo\nMayor Detalle: " + ex.Message;
                lblresultado2.Visible = true;
                lblresultado2.ForeColor = Color.Red;
                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabDatos":
                    mostrar_datos();
                    txtrazonsocial.Select();
                    lblresultado1.Visible = false;
                    break;

                case "tabCodigoBarra":
                    mostrar_tipo_barra();
                    lblresultado2.Visible = false;
                    break;

                case "tabMonedaImporte":
                    txtsimbolo.Select();
                    mostrar_moneda_importe();
                    lblresultado3.Visible = false;
                    lblresultado4.Visible = false;
                    break;
                case "tabCorreo":
                    txtemail.Select();
                    mostrar_correo();
                    lblresultado5.Visible = false;
                    break;
            }
        }

        private void btnguardarsimbolo_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;
                

                int respuesta = LO_MonedaImporte.Instancia.Guardar(txtsimbolo.Text,true, out mensaje);

                if (respuesta < 1)
                {
                    lblresultado3.Text = "No se pudo guardar el simbolo";
                    lblresultado3.Visible = true;
                    lblresultado3.ForeColor = Color.Red;
                    return;
                }


                lblresultado3.Text = "Se guardaron los cambios";
                lblresultado3.Visible = true;
                lblresultado3.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblresultado3.Text = "No se pudo guardar el simbolo\nMayor Detalle: " + ex.Message;
                lblresultado3.Visible = true;
                lblresultado3.ForeColor = Color.Red;

            }
        }

        private void btnguardarporcentaje_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;


                int respuesta = LO_MonedaImporte.Instancia.Guardar(txtporcentaje.Value, false, out mensaje);

                if (respuesta < 1)
                {
                    lblresultado4.Text = "No se pudo guardar el porcentaje";
                    lblresultado4.Visible = true;
                    lblresultado4.ForeColor = Color.Red;
                    return;
                }


                lblresultado4.Text = "Se guardaron los cambios";
                lblresultado4.Visible = true;
                lblresultado4.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblresultado4.Text = "No se pudo guardar el porcentaje\nMayor Detalle: " + ex.Message;
                lblresultado4.Visible = true;
                lblresultado4.ForeColor = Color.Red;

            }
        }

        private void btnguardarcorreo_Click(object sender, EventArgs e)
        {
            try
            {
                string mensaje = string.Empty;


                int respuesta = LO_Correo.Instancia.Guardar(txtemail.Text.Trim(),txtclave.Text.Trim(), out mensaje);

                if (respuesta < 1)
                {
                    lblresultado5.Text = "No se pudo guardar las credenciales";
                    lblresultado5.Visible = true;
                    lblresultado5.ForeColor = Color.Red;
                    return;
                }


                lblresultado5.Text = "Se guardaron las credenciales";
                lblresultado5.Visible = true;
                lblresultado5.ForeColor = Color.Green;
            }
            catch (Exception ex)
            {
                lblresultado5.Text = "No se pudo guardar las credenciales\nMayor Detalle: " + ex.Message;
                lblresultado5.Visible = true;
                lblresultado5.ForeColor = Color.Red;

            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            frmEnviarCorreo frm = new frmEnviarCorreo();
            frm.ShowDialog();
        }

        private void btnguardarcambios_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            if (txtrazonsocial.Text == "")
            {
                lblresultado1.Text = "Debe ingresar Razon Social";
                lblresultado1.Visible = true;
                lblresultado1.ForeColor = Color.Red;
                return;
            }
            if (txtruc.Text == "")
            {
                lblresultado1.Text = "Debe ingresar R.U.C";
                lblresultado1.Visible = true;
                lblresultado1.ForeColor = Color.Red;
                return;
            }
            if (txtdireccion.Text == "")
            {
                lblresultado1.Text = "Debe ingresar direccion";
                lblresultado1.Visible = true;
                lblresultado1.ForeColor = Color.Red;
                return;
            }


            int nrooperacion = LO_Dato.Instancia.Guardar(new Datos()
            {
                RazonSocial = txtrazonsocial.Text,
                RUC = txtruc.Text,
                Direccion = txtdireccion.Text
            }, out mensaje);

            if (nrooperacion < 1)
            {
                lblresultado1.Text = "No se pudo guardar los cambios, intente más tarde";
                lblresultado1.Visible = true;
                lblresultado1.ForeColor = Color.Red;
                
            }
            else
            {
                lblresultado1.Text = "Los cambios fueron guardados";
                lblresultado1.Visible = true;
                lblresultado1.ForeColor = Color.Green;
            }
        }

        private void btnsubir_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                int numerooperacion = LO_Dato.Instancia.ActualizarLogo(byteImagen, out mensaje);

                if (numerooperacion < 1)
                {
                    lblresultado1.Text = "No se pudo guardar el logo";
                    lblresultado1.Visible = true;
                    lblresultado1.ForeColor = Color.Red;
                }
                else
                {
                    picLogo.Image = Operaciones.ByteToImage(byteImagen);
                    lblresultado1.Text = "Logo guardado correctamente";
                    lblresultado1.Visible = true;
                    lblresultado1.ForeColor = Color.Green;
                }
            }
        }
    }
}
