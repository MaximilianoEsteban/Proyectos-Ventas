using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
using SistemaVentasUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Formularios
{
    public partial class frmBusqueda : Form
    {
        private Venta oventa = null;
        private List<DetalleVenta> odetalleventa = null;
        

        public frmBusqueda()
        {
            InitializeComponent();
        }


        private void frmBusqueda_Load(object sender, EventArgs e)
        {
            this.Tag = "";
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            buscarcompra();
        }

        private void buscarcompra() {
            if (txtbusqueda.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el numero de documento", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            Venta obj = LO_Venta.Instancia.Obtener(txtbusqueda.Text);

            if (obj != null)
            {
                oventa = obj;

                this.Tag = obj.IdVenta.ToString();

                txtnumerodocumento.Text = obj.NumeroDocumento;
                txtfecharegistro.Text = obj.FechaRegistro;
                txtusuarioregistro.Text = obj.UsuarioRegistro;

                txtnombres.Text = obj.NombreCliente;
                txtdocumento.Text = obj.DocumentoCliente;
                txtcorreo.Text = obj.CorreoCliente;

                txtSubTotal.Text = obj.MontoSubTotalTexto;
                txtIVA.Text = obj.MontoIVATexto;
                txtTotal.Text = obj.MontoTotalTexto;

                txtpagocon.Text = obj.PagoCon;
                txtcambio.Text = obj.Cambio;

                if (obj.Estado)
                {
                    lblestado.Text = "Activo";
                    lblestado.ForeColor = Color.Green;
                    lblestado.Visible = true;
                }
                else
                {
                    bloquear();
                }
                

                List<DetalleVenta> olista = LO_Venta.Instancia.ListarDetalle(obj.IdVenta);
                odetalleventa = olista;

                dgvdata.Rows.Clear();
                foreach (DetalleVenta de in olista)
                {
                    dgvdata.Rows.Add(new object[] { de.IdProducto, de.Producto, de.CantidadTexto, de.PrecioTexto, de.TotalTexto });
                }


            }
            else {
                limpiar();
                MessageBox.Show("No se encontraron resultados", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bloquear() {
            lblestado.Text = "Cancelado";
            lblestado.ForeColor = Color.Red;
            lblestado.Visible = true;

            gbdetallecliente.Enabled = false;
            btnenviarcorreo.Enabled = false;
            btncancelar.Enabled = false;
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buscarcompra();
            }
        }

        private void limpiar() {

            this.Tag = "";
            lblestado.Visible = false;
            txtnumerodocumento.Text = "";
            txtfecharegistro.Text = "";
            txtusuarioregistro.Text = "";
            gbdetallecliente.Enabled = true;
            txtnombres.Text = "";
            txtdocumento.Text = "";
            txtcorreo.Text = "";
            btnenviarcorreo.Enabled = true;
            btncancelar.Enabled = true;
            dgvdata.Rows.Clear();
            txtSubTotal.Text = "";
            txtIVA.Text = "";
            txtTotal.Text = "";

            txtpagocon.Text = "";
            txtcambio.Text = "";
            txtbusqueda.Select();

            oventa = null;
            odetalleventa = null;

        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

            limpiar();
        }

        private void btnenviarcorreo_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "") {
                MessageBox.Show("No se encontro una venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Desea enviar el correo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                if (txtnombres.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el nombre del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtdocumento.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el documento del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (txtcorreo.Text.Trim() == "")
                {
                    MessageBox.Show("Debe ingresar el correo del cliente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                try
                {
                    MonedaImporte obj = LO_MonedaImporte.Instancia.Obtener();

                    string simbolo = obj.Simbolo;
                    string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
                    Datos odatos = LO_Dato.Instancia.Obtener();

                    Texto_Html = Texto_Html.Replace("@numerodocumento", oventa.NumeroDocumento);

                    Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
                    Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
                    Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

                    Texto_Html = Texto_Html.Replace("@doccliente", txtdocumento.Text);
                    Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombres.Text);
                    Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.Date.ToString("dd/MM/yyyy", new CultureInfo("es-PE")));
                    Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuarioregistro.Text);

                    string filas = string.Empty;
                    foreach (DetalleVenta row in odetalleventa)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.CantidadTexto + "</td>";
                        filas += "<td>" + row.Producto + "</td>";
                        filas += "<td>" + row.TotalTexto + "</td>";
                        filas += "</tr>";
                    }
                    Texto_Html = Texto_Html.Replace("@filas", filas);
                    Texto_Html = Texto_Html.Replace("@montototal", oventa.MontoTotalTexto);
                    Texto_Html = Texto_Html.Replace("@pagocon", string.Concat(simbolo, " ", oventa.PagoCon));
                    Texto_Html = Texto_Html.Replace("@cambio", string.Concat(simbolo, " ", oventa.Cambio));

                    bool respuesta = Operaciones.EnviarCorreo3(txtcorreo.Text, string.Format("RECIBO DE VENTA - {0}", oventa.NumeroDocumento), Texto_Html);

                    if (respuesta)
                        MessageBox.Show("Correo Enviado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("No se pudo enviar el correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                catch
                {
                    MessageBox.Show("No se pudo enviar el correo", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }

           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "")
            {
                MessageBox.Show("No se encontro una venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmCancelarVenta md = new frmCancelarVenta();
            md.numerodocumento = oventa.NumeroDocumento;
            md.odetalleventa = odetalleventa;
            md.IdVenta = Convert.ToInt32(this.Tag.ToString());
            

            var result = md.ShowDialog();
            if (result == DialogResult.OK)
            {
                bloquear();
            }
            else if(result == DialogResult.None) {
                MessageBox.Show(md.mensaje_eliminar, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btndescargarpdf_Click(object sender, EventArgs e)
        {
            if (this.Tag.ToString() == "")
            {
                MessageBox.Show("No se encontro una venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string Texto_Html = Properties.Resources.PlantillaVenta2.ToString();
            Datos odatos = LO_Dato.Instancia.Obtener();
           


            Texto_Html = Texto_Html.Replace("@numerodocumento", txtnumerodocumento.Text);

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@doccliente", txtdocumento.Text);
            Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombres.Text);
            Texto_Html = Texto_Html.Replace("@fecharegistro", txtfecharegistro.Text);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", txtusuarioregistro.Text);

            string filas = string.Empty;
            foreach (DetalleVenta row in odetalleventa)
            {
                filas += "<tr>";
                filas += "<td>" + row.CantidadTexto + "</td>";
                filas += "<td>" + row.Producto + "</td>";
                filas += "<td>" + row.TotalTexto + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", oventa.MontoTotalTexto);
            Texto_Html = Texto_Html.Replace("@pagocon", txtpagocon.Text);
            Texto_Html = Texto_Html.Replace("@cambio", txtcambio.Text);


            SaveFileDialog savefile = new SaveFileDialog();
            savefile.FileName = string.Format("Venta_{0}.pdf", txtnumerodocumento.Text);
            savefile.Filter = "Pdf Files|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefile.FileName, FileMode.Create))
                {
                    //Creamos un nuevo documento y lo definimos como PDF
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                    pdfDoc.Open();

                    using (StringReader sr = new StringReader(Texto_Html))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }


                    bool obtenido = true;
                    byte[] byteimage = LO_Dato.Instancia.ObtenerLogo(out obtenido);
                    if (obtenido)
                    {
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(byteimage);
                        img.ScaleToFit(60, 60);
                        img.Alignment = iTextSharp.text.Image.UNDERLYING;
                        img.SetAbsolutePosition(pdfDoc.Left, pdfDoc.GetTop(51));
                        pdfDoc.Add(img);
                    }

                    
                    pdfDoc.Close();
                    stream.Close();
                    MessageBox.Show("Documento Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
