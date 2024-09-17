using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
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
    public partial class frmImprimir : Form
    {
        public string numerodocumento { get; set; }
        public frmImprimir()
        {
            InitializeComponent();
        }

        private void frmImprimir_Load(object sender, EventArgs e)
        {

            Venta obj = LO_Venta.Instancia.Obtener(numerodocumento);
            Datos odatos = LO_Dato.Instancia.Obtener();
            bool obtenido = true;
            byte[] byteimage = LO_Dato.Instancia.ObtenerLogo(out obtenido);
            string base64String = Convert.ToBase64String(byteimage, 0, byteimage.Length);


            string Texto_Html = Properties.Resources.PlantillaVentaPrint.ToString();
           

            //validamos el formato de la imagen
            string tipo_imagen = string.Empty;
            MemoryStream ms = new MemoryStream(byteimage);
            Image img = Image.FromStream(ms);

            if (img.RawFormat.Equals(System.Drawing.Imaging.ImageFormat.Png))
                tipo_imagen = "data:image/png;base64,";
            else
                tipo_imagen = "data:image/jpg;base64,";


            Texto_Html = Texto_Html.Replace("!imagen!", tipo_imagen + base64String);

            Texto_Html = Texto_Html.Replace("@numerodocumento", numerodocumento);

            Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
            Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
            Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

            Texto_Html = Texto_Html.Replace("@doccliente", obj.DocumentoCliente);
            Texto_Html = Texto_Html.Replace("@nombrecliente", obj.NombreCliente);
            Texto_Html = Texto_Html.Replace("@fecharegistro", obj.FechaRegistro);
            Texto_Html = Texto_Html.Replace("@usuarioregistro", obj.UsuarioRegistro);

            List<DetalleVenta> olista = LO_Venta.Instancia.ListarDetalle(obj.IdVenta);


            string filas = string.Empty;
            foreach (DetalleVenta row in olista)
            {
                filas += "<tr>";
                filas += "<td>" + row.CantidadTexto + "</td>";
                filas += "<td>" + row.Producto + "</td>";
                filas += "<td>" + row.TotalTexto + "</td>";
                filas += "</tr>";
            }
            Texto_Html = Texto_Html.Replace("@filas", filas);
            Texto_Html = Texto_Html.Replace("@montototal", obj.MontoTotalTexto);
            Texto_Html = Texto_Html.Replace("@pagocon", obj.PagoCon);
            Texto_Html = Texto_Html.Replace("@cambio", obj.Cambio);

            webBrowser1.Navigate("about:blank");
            webBrowser1.Document.OpenNew(false);
            webBrowser1.Document.Write(Texto_Html);
            webBrowser1.Refresh();
        }

        private void btnimprimir_Click(object sender, EventArgs e)
        {
            webBrowser1.Print();
        }
    }
}
