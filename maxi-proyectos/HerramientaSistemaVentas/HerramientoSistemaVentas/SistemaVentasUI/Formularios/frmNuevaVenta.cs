using SistemaVentasUI.Logica;
using SistemaVentasUI.Modales;
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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Formularios
{
    public partial class frmNuevaVenta : Form
    {
        private static string simbolo = string.Empty;
        private static decimal importe = 0;
        private List<ItemsVenta> listaventas = new List<ItemsVenta>();
        public Usuario ousuario { get; set; }

        public frmNuevaVenta()
        {
            InitializeComponent();
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {

            //Thread th1 = new Thread(new ThreadStart(() => Mostrar2("hola mundo")));
            //th1.Start();
            //mdBackground modal = new mdBackground();

            //modal.Show();

            //Task tarea = new Task(() => Mostrar2("no digas mamadas mj"));
            //tarea.Start();
            //await tarea;

            //modal.Hide();

            MonedaImporte obj = LO_MonedaImporte.Instancia.Obtener();
            
            simbolo = obj.Simbolo;
            importe = Convert.ToDecimal(obj.Porcentaje.ToString(),new CultureInfo("es-PE"));
            lblimporte.Text = string.Format(":% IVA {0}", obj.Porcentaje.ToString());


            lblequivalente.Visible = false;
        }

        private void txtbusqueda_KeyDown(object sender, KeyEventArgs e)
        {
            string mensaje = string.Empty;

            if (e.KeyData == Keys.Enter)
            {
                limpiarproducto();

                lstresultados.Items.Clear();

                List<Producto> olistaProducto = new LO_Producto().Listar(out mensaje).Where(p =>
                        p.Codigo.Equals(txtbusqueda.Text.Trim()) || p.Descripcion.ToLower().Contains(txtbusqueda.Text.Trim().ToLower())
                    ).ToList();

                foreach (Producto p in olistaProducto) {
                    lstresultados.Items.Add(new OpcionCombo() {
                        Valor = p.IdProducto,
                        Texto = string.Concat(p.Descripcion ," - ", p.Codigo)
                    });
                }

                lstresultados.DisplayMember = "Texto";
                lstresultados.ValueMember = "Valor";

                if (olistaProducto.Count == 1) {


                    txtid.Text = olistaProducto[0].IdProducto.ToString();
                    txtdescripcion.Text = olistaProducto[0].Descripcion;
                    txtcategoria.Text = olistaProducto[0].oCategoria.Descripcion;
                    txtmedida.Text = olistaProducto[0].oCategoria.oMedida.Descripcion;
                    lblequivalente.Text = olistaProducto[0].oCategoria.oMedida.Equivalente;
                    txtcantidad.Value = olistaProducto[0].oCategoria.oMedida.Valor;
                    txtpventa.Text = olistaProducto[0].PrecioVenta.ToString("0.00",new CultureInfo("es-PE"));
                    txtstock.Text = olistaProducto[0].Stock.ToString();
                    lblequivalente.Visible = true;

                    try
                    {
                        string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                        path = Path.Combine(path, olistaProducto[0].NombreCarpeta, olistaProducto[0].NombreArchivo);

                        byte[] byteImagen = File.ReadAllBytes(path);
                        picProducto.Image = Operaciones.ByteToImage(byteImagen);

                    }
                    catch
                    {
                        
                    }

                    txtcantidad.Select();
                }


            }
        }

        private void txtpventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpventa.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtpventa_Enter(object sender, EventArgs e)
        {
            txtpventa.BackColor = Color.Yellow;
        }

        private void txtpventa_Leave(object sender, EventArgs e)
        {
            txtpventa.BackColor = Color.White;
        }

        private void txtcantidad_Enter(object sender, EventArgs e)
        {
            txtcantidad.BackColor = Color.Yellow;
        }

        private void txtcantidad_Leave(object sender, EventArgs e)
        {
            txtcantidad.BackColor = Color.White;
        }

        private void lstresultados_Enter(object sender, EventArgs e)
        {
            lstresultados.BackColor = Color.Yellow;
        }

        private void lstresultados_Leave(object sender, EventArgs e)
        {
            lstresultados.BackColor = Color.White;
        }

        private void txtbusqueda_Enter(object sender, EventArgs e)
        {
            txtbusqueda.BackColor = Color.Yellow;
        }

        private void txtbusqueda_Leave(object sender, EventArgs e)
        {
            txtbusqueda.BackColor = Color.White;
        }


        private void lstresultados_DoubleClick(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int id = Convert.ToInt32(((OpcionCombo)lstresultados.SelectedItem).Valor.ToString());

            Producto ob = new LO_Producto().obtener(id, out mensaje);

            txtid.Text = ob.IdProducto.ToString();
            txtdescripcion.Text = ob.Descripcion;
            txtcategoria.Text = ob.oCategoria.Descripcion;
            txtmedida.Text = ob.oCategoria.oMedida.Descripcion;
            lblequivalente.Text = ob.oCategoria.oMedida.Equivalente;
            txtcantidad.Value = ob.oCategoria.oMedida.Valor;
            txtpventa.Text = ob.PrecioVenta.ToString("0.00", new CultureInfo("es-PE"));
            txtstock.Text = ob.Stock.ToString();
            lblequivalente.Visible = true;

            try
            {
                string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                path = Path.Combine(path, ob.NombreCarpeta, ob.NombreArchivo);

                byte[] byteImagen = File.ReadAllBytes(path);
                picProducto.Image = Operaciones.ByteToImage(byteImagen);

            }
            catch
            {

            }

            txtcantidad.Select();

        }

        private void lstresultados_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                string mensaje = string.Empty;

                if (lstresultados.SelectedItem == null) return;

                int id = Convert.ToInt32(((OpcionCombo)lstresultados.SelectedItem).Valor.ToString());

                Producto ob = new LO_Producto().obtener(id, out mensaje);

                txtid.Text = ob.IdProducto.ToString();
                txtdescripcion.Text = ob.Descripcion;
                txtcategoria.Text = ob.oCategoria.Descripcion;
                txtmedida.Text = ob.oCategoria.oMedida.Descripcion;
                lblequivalente.Text = ob.oCategoria.oMedida.Equivalente;
                txtcantidad.Value = ob.oCategoria.oMedida.Valor;
                txtpventa.Text = ob.PrecioVenta.ToString("0.00", new CultureInfo("es-PE"));
                txtstock.Text = ob.Stock.ToString();
                lblequivalente.Visible = true;

                try
                {
                    string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                    path = Path.Combine(path, ob.NombreCarpeta, ob.NombreArchivo);

                    byte[] byteImagen = File.ReadAllBytes(path);
                    picProducto.Image = Operaciones.ByteToImage(byteImagen);

                }
                catch
                {

                }

                txtcantidad.Select();
            }
        }

        private void AgregarProductoALista() {

            int cantidad = 0;
            decimal precio = 0;
            string mensaje = string.Empty;

            if (txtid.Text.Trim() == "") return;

            int id = Convert.ToInt32(txtid.Text.ToString());


            int stockactual = Convert.ToInt32(txtstock.Text);
            int cantidad_temp = Convert.ToInt32(txtcantidad.Value.ToString(), new CultureInfo("es-PE"));

            if (cantidad_temp > stockactual) {
                MessageBox.Show("Stock no disponible", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            ItemsVenta item = listaventas.FirstOrDefault(i => i.IdProducto == id);

            if (item != null)
            {
                MessageBox.Show("El producto ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int respuesta = LO_Producto.Instancia.Control(id, Convert.ToInt32(txtcantidad.Value.ToString()), false);

            if (respuesta > 0)
            {

                try
                {

                    Producto ob = new LO_Producto().obtener(id, out mensaje);
                    if (!decimal.TryParse(txtpventa.Text, NumberStyles.Number, new CultureInfo("es-PE"), out precio)) return;

                    if (ob.oCategoria.oMedida.Valor == 1)
                    {
                        cantidad = Convert.ToInt32(txtcantidad.Value.ToString(), new CultureInfo("es-PE"));
                        decimal total = Convert.ToDecimal(cantidad.ToString(), new CultureInfo("es-PE")) * precio;

                        listaventas.Add(new ItemsVenta()
                        {
                            IdProducto = Convert.ToInt32(txtid.Text.ToString()),
                            Descripcion = txtdescripcion.Text,
                            Categoria = txtcategoria.Text,
                            Cantidad = cantidad,
                            CantidadTexto = string.Concat(cantidad, " ", ob.oCategoria.oMedida.Descripcion),
                            Precio = precio,
                            PrecioTexto = string.Concat(simbolo, " ", precio.ToString("0.00", new CultureInfo("es-PE"))),
                            Total = total,
                            TotalTexto = string.Concat(simbolo, " ", total.ToString("0.00", new CultureInfo("es-PE")))
                        });
                    }
                    else
                    {

                        int ctemp = Convert.ToInt32(txtcantidad.Value.ToString());
                        decimal total = (Convert.ToDecimal(ctemp.ToString(), new CultureInfo("es-PE")) * precio) / Convert.ToDecimal(ob.oCategoria.oMedida.Valor, new CultureInfo("es-PE"));

                        string nuevoprecio = string.Format(new CultureInfo("es-PE"), "{0:0.0}0", total);
                        total = Convert.ToDecimal(nuevoprecio, new CultureInfo("es-PE"));


                        decimal cantidad_resultado = Convert.ToDecimal(txtcantidad.Value.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(ob.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));


                        listaventas.Add(new ItemsVenta()
                        {
                            IdProducto = Convert.ToInt32(txtid.Text.ToString()),
                            Descripcion = txtdescripcion.Text,
                            Categoria = txtcategoria.Text,
                            Cantidad = ctemp,
                            CantidadTexto = string.Concat(cantidad_resultado.ToString("0.##", new CultureInfo("es-PE")), " ", ob.oCategoria.oMedida.Descripcion),
                            Precio = precio,
                            PrecioTexto = string.Concat(simbolo, " ", precio.ToString("0.00", new CultureInfo("es-PE"))),
                            Total = total,
                            TotalTexto = string.Concat(simbolo, " ", total.ToString("0.00", new CultureInfo("es-PE")))
                        });
                    }


                    mostraritemsventa();
                    limpiarproducto();
                    mostrar_precios_importes();
                    txtbusqueda.Select();

                }
                catch (Exception ex)
                {
                    int respuesta2 = LO_Producto.Instancia.Control(id, Convert.ToInt32(txtcantidad.Value.ToString()), true);
                }

            }

        }


        private void btnagregar_Click(object sender, EventArgs e)
        {
            AgregarProductoALista();
        }
        private void txtcantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AgregarProductoALista();
            }
            
        }

        private void txtpventa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                AgregarProductoALista();
            }
        }

        private void limpiarproducto() {
            
            txtid.Text = "";
            txtdescripcion.Text = "";
            txtcategoria.Text = "";
            txtmedida.Text = "";
            picProducto.Image = null;
            txtcantidad.Value = 1;
            txtpventa.Text = "";
            txtstock.Text = "";
            lblequivalente.Visible = false;
        }

        private void mostraritemsventa() {

            dgvdata.Rows.Clear();

            foreach (ItemsVenta i in listaventas) {
                dgvdata.Rows.Add(new object[] {
                    i.IdProducto,
                    i.Descripcion,
                    i.CantidadTexto,
                    i.PrecioTexto,
                    i.TotalTexto
                });
            }

        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.trash_17.Width;
                var h = Properties.Resources.trash_17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.trash_17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje = string.Empty;
            int index = e.RowIndex;
            if (index >= 0)
            {

                if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {

                    int id = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                    var item = listaventas.Single(i => i.IdProducto == id);


                    int respuesta = LO_Producto.Instancia.Control(id, item.Cantidad, true);
                    if (respuesta > 0)
                    {
                        listaventas.Remove(item);
                        mostraritemsventa();
                        mostrar_precios_importes();
                    }
                    else
                        MessageBox.Show("No se pudo eliminar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
        }

        private void frmNuevaVenta_FormClosing(object sender, FormClosingEventArgs e)
        {

            try
            {
                if (listaventas.Count > 0)
                {
                    if (MessageBox.Show("Existen productos en la lista.\n¿Desea salir de todos modos?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        foreach (ItemsVenta item in listaventas)
                        {
                            int respuesta = LO_Producto.Instancia.Control(item.IdProducto, item.Cantidad, true);
                        }

                    }
                    else {
                        e.Cancel = true;
                    }
                }
            }
            catch
            {


            }
        }

        private void mostrar_precios_importes() {

            decimal precioSinIVA = 0;
            decimal ivaTotal = 0;
            decimal precioTotal = 0;

            if (listaventas.Count > 0) {

               
                foreach (ItemsVenta item in listaventas)
                {
                    precioTotal += item.Total;
                }

                precioSinIVA = precioTotal / ((importe / 100) + 1);
                ivaTotal = precioSinIVA * (importe / 100);

                //ivaTotal = precioTotal * (importe / 100);
                //precioSinIVA = precioTotal - ivaTotal;

            }

            txtSubTotal.Text = string.Concat(simbolo," ", precioSinIVA.ToString("0.00", new CultureInfo("es-PE")));
            txtSubTotal.Tag = precioSinIVA.ToString("0.00", new CultureInfo("es-PE"));

            txtIVA.Text = string.Concat(simbolo," ", ivaTotal.ToString("0.00", new CultureInfo("es-PE")));
            txtIVA.Tag = ivaTotal.ToString("0.00", new CultureInfo("es-PE"));


            txtTotal.Text = string.Concat(simbolo," ", precioTotal.ToString("0.00", new CultureInfo("es-PE")));
            txtTotal.Tag = precioTotal.ToString("0.00", new CultureInfo("es-PE"));


        }

        private void frmNuevaVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.F1)
            {
                txtbusqueda.Select();
            }
        }

        private void calcularcambio()
        {
            if (txtTotal.Text.Trim() == "")
            {
                MessageBox.Show("No existen productos en la venta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            decimal pagacon;
            decimal total = Convert.ToDecimal(txtTotal.Tag.ToString(), new CultureInfo("es-PE"));

            if (txtpagocon.Text.Trim() == "")
            {
                txtpagocon.Text = txtTotal.Tag.ToString();
            }


            if (decimal.TryParse(txtpagocon.Text.Trim(), NumberStyles.Number, new CultureInfo("es-PE"),out pagacon))
            {
                if (pagacon < total)
                {
                    txtcambio.Text = "0.00";
                }
                else
                {
                    decimal cambio = pagacon - total;
                    txtcambio.Text = cambio.ToString("0.00", new CultureInfo("es-PE"));
                }
            }
        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                calcularcambio();
            }
        }

        private void txtterminarventa_Click(object sender, EventArgs e)
        {
            if (chkenviarcorreo.Checked) {
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

            }

            if (dgvdata.Rows.Count < 1)
            {
                MessageBox.Show("Debe ingresar productos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string mensaje = string.Empty;
            int cantidad_productos = 0;
            int idcorrelativo = LO_Venta.Instancia.ObtenerCorrelativo(out mensaje);
            List<DetalleVenta> olista = new List<DetalleVenta>();

            if (idcorrelativo < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            foreach (ItemsVenta row in listaventas)
            {
                olista.Add(new DetalleVenta()
                {
                    IdProducto = row.IdProducto,
                    Producto = row.Descripcion,
                    Categoria = row.Categoria,
                    CantidadValor = row.Cantidad,
                    CantidadTexto = row.CantidadTexto,
                    PrecioValor = row.Precio,
                    PrecioTexto = row.PrecioTexto,
                    TotalValor = row.Total,
                    TotalTexto = row.TotalTexto,
                    Estado = true
                });

                cantidad_productos += 1;
            }

            calcularcambio();

            Venta oventa = new Venta()
            {
                NumeroDocumento = String.Format("{0:00000}", idcorrelativo),
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd", new CultureInfo("en-US")),
                UsuarioRegistro = ousuario.NombreCompleto,
                NombreCliente = txtnombres.Text,
                DocumentoCliente = txtdocumento.Text,
                CorreoCliente = txtcorreo.Text,
                CantidadProductos = cantidad_productos,
                MontoSubTotalValor = Convert.ToDecimal(txtSubTotal.Tag.ToString(), new CultureInfo("es-PE")),
                MontoSubTotalTexto = txtSubTotal.Text,

                MontoIVAValor = Convert.ToDecimal(txtIVA.Tag.ToString(), new CultureInfo("es-PE")),
                MontoIVATexto = txtIVA.Text,

                MontoTotalValor = Convert.ToDecimal(txtTotal.Tag.ToString(), new CultureInfo("es-PE")),
                MontoTotalTexto = txtTotal.Text,

                PagoCon = Convert.ToDecimal(txtpagocon.Text.Trim(), new CultureInfo("es-PE")).ToString("0.00", new CultureInfo("es-PE")),
                Cambio = Convert.ToDecimal(txtcambio.Text.Trim(), new CultureInfo("es-PE")).ToString("0.00", new CultureInfo("es-PE")),
                Estado = true,
                oListaDetalleVenta = olista
            };

            int operaciones = LO_Venta.Instancia.Registrar(oventa, out mensaje);

            if (operaciones < 1)
            {
                MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (chkenviarcorreo.Checked)
                {
                    string Texto_Html = Properties.Resources.PlantillaVenta.ToString();
                    Datos odatos = LO_Dato.Instancia.Obtener();

                    Texto_Html = Texto_Html.Replace("@numerodocumento", string.Format("{0:00000}", idcorrelativo));

                    Texto_Html = Texto_Html.Replace("@nombrenegocio", odatos.RazonSocial.ToUpper());
                    Texto_Html = Texto_Html.Replace("@docnegocio", odatos.RUC);
                    Texto_Html = Texto_Html.Replace("@direcnegocio", odatos.Direccion);

                    Texto_Html = Texto_Html.Replace("@doccliente", txtdocumento.Text);
                    Texto_Html = Texto_Html.Replace("@nombrecliente", txtnombres.Text);
                    Texto_Html = Texto_Html.Replace("@fecharegistro", DateTime.Now.Date.ToString("dd/MM/yyyy", new CultureInfo("es-PE")));
                    Texto_Html = Texto_Html.Replace("@usuarioregistro", ousuario.NombreCompleto);

                    string filas = string.Empty;
                    foreach (ItemsVenta row in listaventas)
                    {
                        filas += "<tr>";
                        filas += "<td>" + row.CantidadTexto + "</td>";
                        filas += "<td>" + row.Descripcion + "</td>";
                        filas += "<td>" + row.TotalTexto + "</td>";
                        filas += "</tr>";
                    }
                    Texto_Html = Texto_Html.Replace("@filas", filas);
                    Texto_Html = Texto_Html.Replace("@montototal", oventa.MontoTotalTexto);
                    Texto_Html = Texto_Html.Replace("@pagocon", string.Concat(simbolo, " ", oventa.PagoCon));
                    Texto_Html = Texto_Html.Replace("@cambio", string.Concat(simbolo, " ", oventa.Cambio));

                    bool respuesta = Operaciones.EnviarCorreo3(txtcorreo.Text, string.Format("RECIBO DE VENTA - {0}", string.Format("{0:00000}", idcorrelativo)), Texto_Html);
                }

                txtnombres.Text = "";
                txtdocumento.Text = "";
                txtcorreo.Text = "";
                
                dgvdata.Rows.Clear();
                listaventas.Clear();

                txtSubTotal.Text = "";
                txtSubTotal.Tag = "";
                txtIVA.Text = "";
                txtIVA.Tag = "";
                txtTotal.Text = "";
                txtTotal.Tag = "";

                txtpagocon.Text = "";
                txtcambio.Text = "";

                txtbusqueda.Select();

                mdVentaExitosa md = new mdVentaExitosa();
                md._numerodocumento = string.Format("{0:00000}", idcorrelativo);
                md.ShowDialog();
            }

        }

        //public void Mostrar2(string mensaje)
        //{
        //    Thread.Sleep(5000);
        //    MessageBox.Show(mensaje);
        //}

        private void txtpagocon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpagocon.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
                {
                    e.Handled = true;
                }
                else
                {
                    if (Char.IsControl(e.KeyChar) || e.KeyChar.ToString() == ".")
                    {
                        e.Handled = false;
                    }
                    else
                    {
                        e.Handled = true;
                    }
                }
            }
        }



    }
}
