using ClosedXML.Excel;
using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
using SistemaVentasUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Formularios
{
    public partial class frmProducto : Form
    {
        public frmProducto()
        {
            InitializeComponent();
        }

        private void txtpreciocompra1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra1.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtpreciocompra2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtpreciocompra2.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtprecioventa1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa1.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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

        private void txtprecioventa2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (txtprecioventa2.Text.Trim().Length == 0 && e.KeyChar.ToString() == ".")
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


        private void listar_productos()
        {
            string mensaje = string.Empty;
            dgvdata.Rows.Clear();

            List<Producto> lista = LO_Producto.Instancia.Listar(out mensaje);

            int indice = 0;
            foreach (Producto c in lista)
            {
                decimal _stock = Convert.ToDecimal(c.Stock.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(c.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));

                decimal _stock_minimo = Convert.ToDecimal(c.StockMinimo.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(c.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));


                dgvdata.Rows.Add(new object[] {
                    c.IdProducto,
                    c.Codigo,
                    c.Descripcion,
                    c.oCategoria.Descripcion,
                    c.PrecioCompra.ToString("0.00"),
                    c.PrecioVenta.ToString("0.00"),
                    c.Utilidad.ToString("0.00"),
                    string.Concat(_stock.ToString("0.##",new CultureInfo("es-PE"))," ",c.oCategoria.oMedida.Descripcion),
                    string.Concat(_stock_minimo.ToString("0.##",new CultureInfo("es-PE"))," ",c.oCategoria.oMedida.Descripcion),
                    c.NombreCarpeta,
                    c.NombreArchivo,
                    "",
                    "",
                    "",
                    ""
                });


                if (c.Stock <= c.StockMinimo)
                    dgvdata.Rows[indice].DefaultCellStyle.BackColor = Color.MistyRose;

                indice++;
            }

        }
        private void frmProducto_Load(object sender, EventArgs e)
        {
            stockmininmo();
            string mensaje = string.Empty;
            listar_productos();


            List<Categoria> lista = LO_Categoria.Instancia.Listar(out mensaje);
            foreach (Categoria m in lista)
            {
                cbocategoria1.Items.Add(new OpcionCombo() { Valor = m.IdCategoria, Texto = m.Descripcion });
                cbocategoria2.Items.Add(new OpcionCombo() { Valor = m.IdCategoria, Texto = m.Descripcion });
            }
            cbocategoria1.DisplayMember = "Texto";
            cbocategoria1.ValueMember = "Valor";
            if (lista.Count > 0) cbocategoria1.SelectedIndex = 0;

            cbocategoria2.DisplayMember = "Texto";
            cbocategoria2.ValueMember = "Valor";
            if (lista.Count > 0) cbocategoria2.SelectedIndex = 0;



            cbobuscar.Items.Add(new OpcionCombo() { Valor = "Codigo", Texto = "Codigo" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "Descripcion", Texto = "Descripcion" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "Categoria", Texto = "Categoria" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "PCompra", Texto = "Precio Compra" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "PVenta", Texto = "Precio Venta" });
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;

            TipoBarra objtipobarra = LO_TipoBarra.Instancia.ObtenerTipoBarra();
            if (objtipobarra.IdTipoBarra != 0)
            {
                TipoBarraCodigo.TipoCodigo = (Enum.IsDefined(typeof(BarcodeLib.TYPE), objtipobarra.Value)) ? ((BarcodeLib.TYPE)objtipobarra.Value) : ((BarcodeLib.TYPE)0);
            }

        }



        private void btnguardarnuevo_Click(object sender, EventArgs e)
        {
            lblresultado1.Visible = true;
            string mensaje = string.Empty;
            decimal pcompra = 0;
            decimal pventa = 0;
            decimal utilidad = 0;


            int existe = LO_Producto.Instancia.Existe(txtcodigo1.Text.Trim(), 0, out mensaje);
            if (existe > 0)
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (txtcodigo1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar el codigo del producto";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (txtdescripcion1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar la descripcion del producto";
                lblresultado1.ForeColor = Color.Red;
                return;
            }




            if (!decimal.TryParse(txtpreciocompra1.Text, NumberStyles.Number, new CultureInfo("es-PE"), out pcompra))
            {
                lblresultado1.Text = "El formato de moneda debe ser #.## - Precio Compra";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (!decimal.TryParse(txtprecioventa1.Text, NumberStyles.Number, new CultureInfo("es-PE"), out pventa))
            {
                lblresultado1.Text = "El formato de moneda debe ser #.## - Precio Venta";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            utilidad = (pventa - pcompra) > 0 ? (pventa - pcompra) : 0;


            Producto objeto = new Producto()
            {
                Codigo = txtcodigo1.Text,
                Descripcion = txtdescripcion1.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria1.SelectedItem).Valor.ToString()) },
                PrecioCompra = pcompra,
                PrecioVenta = pventa,
                Utilidad = utilidad,
                Stock = Convert.ToInt32(txtstock1.Value.ToString()),
                StockMinimo = Convert.ToInt32(txtstockminimo1.Value.ToString())
            };

            int idgenerado = LO_Producto.Instancia.Guardar(objeto, out mensaje);

            if (idgenerado > 0)
            {
                if (txtrutaimagen1.Text != "")
                {

                    try
                    {
                        string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                        path = Path.Combine(path, "Imagenes");
                        byte[] byteImagen = File.ReadAllBytes(txtrutaimagen1.Text);

                        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                        using (MemoryStream ms = new MemoryStream(byteImagen))
                        {
                            Image imagen = Image.FromStream(ms);
                            imagen.Save(Path.Combine(path, string.Concat(idgenerado.ToString(), ".jpg")), ImageFormat.Jpeg);
                        }

                        int operaciones = LO_Producto.Instancia.ActualizarImagen(idgenerado.ToString(), string.Concat(idgenerado, ".jpg"), out mensaje);

                    }
                    catch
                    {
                        lblresultado1.Text = "Se registro el producto pero la imagen no pudo ser guardada";
                        lblresultado1.ForeColor = Color.Red;
                    }
                }


                txtcodigo1.Text = "";
                txtdescripcion1.Text = "";
                cbocategoria1.SelectedIndex = 0;
                txtpreciocompra1.Text = "";
                txtprecioventa1.Text = "";
                txtstock1.Value = 0;
                txtstockminimo1.Value = 0;
                picProducto1.Image = null;
                txtrutaimagen1.Text = "";
                txtcodigo1.Select();


                lblresultado1.Text = "El producto fue registrado";
                lblresultado1.ForeColor = Color.Green;
            }
            else
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
            }

        }

        private void btnsubir1_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                txtrutaimagen1.Text = oOpenFileDialog.FileName;

                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                picProducto1.Image = Operaciones.ByteToImage(byteImagen);

            }
        }

        private void btnsubir2_Click(object sender, EventArgs e)
        {
            string mensaje = string.Empty;
            OpenFileDialog oOpenFileDialog = new OpenFileDialog();
            oOpenFileDialog.Filter = "Files|*.jpg;*.jpeg;*.png";

            if (oOpenFileDialog.ShowDialog() == DialogResult.OK)
            {

                txtrutaimagen2.Text = oOpenFileDialog.FileName;

                byte[] byteImagen = File.ReadAllBytes(oOpenFileDialog.FileName);
                picProducto2.Image = Operaciones.ByteToImage(byteImagen);

            }
        }

        private void stockmininmo()
        {
            string msg = string.Empty;
            int prds = LO_Producto.Instancia.Listar(out msg).Where(p => p.Stock <= p.StockMinimo).Count();

            if (prds > 0)
            {
                lblstockminimo.Visible = true;
                lblstockminimo.Text = "Hay algunos productos que cumplen con el stock minimo - ver";
            }
            else
            {
                lblstockminimo.Visible = false;
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabCatalogo":
                    stockmininmo();
                    listar_productos();
                    break;

                case "tabNuevo":
                    txtcodigo1.Text = "";
                    txtdescripcion1.Text = "";
                    cbocategoria1.SelectedIndex = 0;
                    txtpreciocompra1.Text = "";
                    txtprecioventa1.Text = "";
                    txtstock1.Value = 0;
                    txtstockminimo1.Value = 0;
                    picProducto1.Image = null;
                    txtrutaimagen1.Text = "";
                    lblresultado1.Visible = false;
                    txtcodigo1.Select();
                    break;

                case "tabModificar":

                    txtcodigo2.Text = "";
                    txtdescripcion2.Text = "";
                    cbocategoria2.SelectedIndex = 0;
                    txtpreciocompra2.Text = "";
                    txtprecioventa2.Text = "";
                    txtstock2.Value = 0;
                    txtstockminimo2.Value = 0;
                    picProducto2.Image = null;
                    txtrutaimagen2.Text = "";
                    lblresultado2.Visible = false;
                    txtcodigo2.Select();
                    break;
            }
        }



        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 11)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.mas_17.Width;
                var h = Properties.Resources.mas_17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.mas_17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 12)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.menos_17.Width;
                var h = Properties.Resources.menos_17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.menos_17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 13)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.editar_17.Width;
                var h = Properties.Resources.editar_17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editar_17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 14)
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

        private void buscarproducto()
        {
            string mensaje = string.Empty;
            List<Producto> lista = LO_Producto.Instancia.Listar(out mensaje);

            Producto ob = lista.Where(c => c.Codigo.ToString().Equals(txtcodigo2.Text.ToString().Trim())).FirstOrDefault();

            if (ob != null)
            {
                txtid.Text = ob.IdProducto.ToString();
                txtdescripcion2.Text = ob.Descripcion;

                int encontrado = 0;
                foreach (OpcionCombo oc in cbocategoria2.Items)
                {
                    if (Convert.ToInt32(oc.Valor.ToString()) == ob.oCategoria.IdCategoria) break;
                    encontrado++;
                }
                cbocategoria2.SelectedIndex = encontrado;
                txtpreciocompra2.Text = ob.PrecioCompra.ToString("0.00", new CultureInfo("es-PE"));
                txtprecioventa2.Text = ob.PrecioVenta.ToString("0.00", new CultureInfo("es-PE"));
                txtstock2.Value = ob.Stock;
                txtstockminimo2.Value = ob.StockMinimo;


                try
                {
                    string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                    path = Path.Combine(path, ob.NombreCarpeta, ob.NombreArchivo);

                    byte[] byteImagen = File.ReadAllBytes(path);
                    picProducto2.Image = Operaciones.ByteToImage(byteImagen);

                }
                catch
                {
                    MessageBox.Show("No se pudo cargar la imagen del producto", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }


                lblresultado2.Visible = false;
            }
            else
            {
                txtid.Text = "";

                txtcodigo2.Text = "";
                txtdescripcion2.Text = "";
                cbocategoria2.SelectedIndex = 0;
                txtpreciocompra2.Text = "";
                txtprecioventa2.Text = "";
                txtstock2.Value = 0;
                txtstockminimo2.Value = 0;
                picProducto2.Image = null;
                txtrutaimagen2.Text = "";

                lblresultado2.Text = "No se encontraron resultados";
                lblresultado2.Visible = true;
                lblresultado2.ForeColor = Color.Red;
            }

        }

        private void btnbuscarproducto_Click(object sender, EventArgs e)
        {
            buscarproducto();
        }

        private void txtcodigo2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                buscarproducto();
            }
        }

        private void btnguardarmodificacion_Click(object sender, EventArgs e)
        {

            lblresultado2.Visible = true;
            string mensaje = string.Empty;
            decimal pcompra = 0;
            decimal pventa = 0;
            decimal utilidad = 0;

            if (txtid.Text.Trim() == "")
            {
                lblresultado2.Text = "No se encontró producto";
                lblresultado2.ForeColor = Color.Red;
                return;
            }


            int existe = LO_Producto.Instancia.Existe(txtcodigo2.Text.Trim(), Convert.ToInt32(txtid.Text), out mensaje);
            if (existe > 0)
            {
                lblresultado2.Text = mensaje;
                lblresultado2.ForeColor = Color.Red;
                return;
            }


            if (txtcodigo2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar el codigo del producto";
                lblresultado2.ForeColor = Color.Red;
                return;
            }

            if (txtdescripcion2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar la descripcion del producto";
                lblresultado2.ForeColor = Color.Red;
                return;
            }



            if (!decimal.TryParse(txtpreciocompra2.Text, NumberStyles.Number, new CultureInfo("es-PE"), out pcompra))
            {
                lblresultado2.Text = "El formato de moneda debe ser #.## - Precio Compra";
                lblresultado2.ForeColor = Color.Red;
                return;
            }

            if (!decimal.TryParse(txtprecioventa2.Text, NumberStyles.Number, new CultureInfo("es-PE"), out pventa))
            {
                lblresultado2.Text = "El formato de moneda debe ser #.## - Precio Venta";
                lblresultado2.ForeColor = Color.Red;
                return;
            }

            utilidad = (pventa - pcompra) > 0 ? (pventa - pcompra) : 0;


            Producto objeto = new Producto()
            {
                IdProducto = Convert.ToInt32(txtid.Text),
                Codigo = txtcodigo2.Text,
                Descripcion = txtdescripcion2.Text,
                oCategoria = new Categoria() { IdCategoria = Convert.ToInt32(((OpcionCombo)cbocategoria2.SelectedItem).Valor.ToString()) },
                PrecioCompra = pcompra,
                PrecioVenta = pventa,
                Utilidad = utilidad,
                Stock = Convert.ToInt32(txtstock2.Value.ToString()),
                StockMinimo = Convert.ToInt32(txtstockminimo2.Value.ToString())
            };

            int resultado = LO_Producto.Instancia.Editar(objeto, out mensaje);

            if (resultado > 0)
            {
                if (txtrutaimagen2.Text != "")
                {

                    try
                    {
                        string path = Directory.GetParent(System.Reflection.Assembly.GetExecutingAssembly().Location).FullName;
                        path = Path.Combine(path, "Imagenes");
                        byte[] byteImagen = File.ReadAllBytes(txtrutaimagen2.Text);

                        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

                        using (MemoryStream ms = new MemoryStream(byteImagen))
                        {
                            Image imagen = Image.FromStream(ms);
                            imagen.Save(Path.Combine(path, string.Concat(txtid.Text, ".jpg")), ImageFormat.Jpeg);
                        }

                        int operaciones = LO_Producto.Instancia.ActualizarImagen(txtid.Text, string.Concat(txtid.Text, ".jpg"), out mensaje);

                    }
                    catch
                    {
                        lblresultado1.Text = "Se actualizó el producto pero la imagen no pudo ser guardada";
                        lblresultado1.ForeColor = Color.Red;
                    }
                }


                txtcodigo2.Text = "";
                txtdescripcion2.Text = "";
                cbocategoria2.SelectedIndex = 0;
                txtpreciocompra2.Text = "";
                txtprecioventa2.Text = "";
                txtstock2.Value = 0;
                txtstockminimo2.Value = 0;
                picProducto2.Image = null;
                txtrutaimagen2.Text = "";

                txtcodigo2.Select();

                lblresultado2.Text = "Se guardaron los cambios";
                lblresultado2.ForeColor = Color.Green;
            }
            else
            {
                lblresultado2.Text = mensaje;
                lblresultado2.ForeColor = Color.Red;
            }
        }

        private void btngenerarcodigo_Click(object sender, EventArgs e)
        {

            if (txtcodigo2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar el codigo";
                lblresultado2.ForeColor = Color.Red;
            }
            else
            {
                try
                {
                    BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                    Codigo.IncludeLabel = chkmostraretiqueta.Checked;
                    var imagen = Codigo.Encode(TipoBarraCodigo.TipoCodigo, txtcodigo2.Text.Trim(), Color.Black, Color.White, 400, 100);

                    byte[] barcodeimagen = Operaciones.ImageToByte(imagen);

                    SaveFileDialog savefile = new SaveFileDialog();
                    savefile.FileName = string.Format("{0}.png", txtcodigo2.Text.Trim());
                    savefile.Filter = "Imagen|*.png";
                    if (savefile.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllBytes(savefile.FileName, barcodeimagen);
                        MessageBox.Show("Codigo generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("No se pudo generar el codigo.\nMayor Detalle:\n{0}", ex.Message), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            }
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje = string.Empty;
            int index = e.RowIndex;
            if (index >= 0)
            {

                if (dgvdata.Columns[e.ColumnIndex].Name == "btneditar")
                {
                    tabControl1.SelectedTab = tabControl1.TabPages["tabModificar"];
                    txtid.Text = dgvdata.Rows[index].Cells["Id"].Value.ToString();
                    txtcodigo2.Text = dgvdata.Rows[index].Cells["Codigo"].Value.ToString();

                    buscarproducto();
                }
                else if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {
                    if (MessageBox.Show("¿Desea eliminar el producto?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = int.Parse(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                        int respuesta = LO_Producto.Instancia.Eliminar(id);
                        if (respuesta > 0)
                        {
                            dgvdata.Rows.RemoveAt(index);
                        }
                        else
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (dgvdata.Columns[e.ColumnIndex].Name == "btnsumar")
                {
                    using (var Iform = new frmControlStock())
                    {
                        Iform.ShowInTaskbar = false;
                        Iform.sumar = true;
                        Iform.id = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                        Producto prd = LO_Producto.Instancia.obtener(Iform.id, out mensaje);


                        Iform.codigo = dgvdata.Rows[index].Cells["Codigo"].Value.ToString();
                        Iform.descripcion = dgvdata.Rows[index].Cells["Descripcion"].Value.ToString();
                        Iform.stock = prd.Stock;
                        var result = Iform.ShowDialog();
                        if (result == DialogResult.OK)
                        {

                            decimal _stock = Convert.ToDecimal(Iform.nuevo_stock.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(prd.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));


                            dgvdata.Rows[index].Cells["Stock"].Value = string.Concat(_stock.ToString("0.##", new CultureInfo("es-PE")), " ", prd.oCategoria.oMedida.Descripcion);
                        }
                    }
                }
                else if (dgvdata.Columns[e.ColumnIndex].Name == "btnrestar")
                {
                    using (var Iform = new frmControlStock())
                    {
                        Iform.ShowInTaskbar = false;
                        Iform.sumar = false;
                        Iform.id = Convert.ToInt32(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                        Producto prd = LO_Producto.Instancia.obtener(Iform.id, out mensaje);


                        Iform.codigo = dgvdata.Rows[index].Cells["Codigo"].Value.ToString();
                        Iform.descripcion = dgvdata.Rows[index].Cells["Descripcion"].Value.ToString();
                        Iform.stock = prd.Stock;
                        var result = Iform.ShowDialog();
                        if (result == DialogResult.OK)
                        {
                            decimal _stock = Convert.ToDecimal(Iform.nuevo_stock.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(prd.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));

                            dgvdata.Rows[index].Cells["Stock"].Value = string.Concat(_stock.ToString("0.##", new CultureInfo("es-PE")), " ", prd.oCategoria.oMedida.Descripcion);
                        }
                    }
                }
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar.SelectedItem).Valor.ToString();

            if (dgvdata.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata.Rows)
            {
                row.Visible = true;
            }
            dgvdata.ClearSelection();
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {
            if (dgvdata.Rows.Count < 1)
            {

                MessageBox.Show("No hay datos para descargar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvdata.Columns)
                {
                    if (column.HeaderText != "" && column.Visible == true)
                        dt.Columns.Add(column.HeaderText, typeof(string));
                }


                foreach (DataGridViewRow row in dgvdata.Rows)
                {
                    if (row.Visible == true)
                        dt.Rows.Add(new object[] {
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_Productos_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
                savefile.Filter = "Excel Files|*.xlsx";
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        XLWorkbook wb = new XLWorkbook();
                        var hoja = wb.Worksheets.Add(dt, "Informe");
                        hoja.ColumnsUsed().AdjustToContents();
                        wb.SaveAs(savefile.FileName);
                        MessageBox.Show("Reporte Generado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Error al generar reporte", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }


            }
        }

        private void cbocategoria1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int id = Convert.ToInt32(((OpcionCombo)cbocategoria1.SelectedItem).Valor.ToString());
            Categoria objeto = new LO_Categoria().Listar(out mensaje).Where(c => c.IdCategoria == id).FirstOrDefault();
            if (objeto != null)
            {
                lblequivalente_nuevo1.Text = objeto.oMedida.Equivalente;
                lblequivalente_nuevo2.Text = objeto.oMedida.Equivalente;
            }

        }

        private void cbocategoria2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            int id = Convert.ToInt32(((OpcionCombo)cbocategoria2.SelectedItem).Valor.ToString());
            Categoria objeto = new LO_Categoria().Listar(out mensaje).Where(c => c.IdCategoria == id).FirstOrDefault();
            if (objeto != null)
            {
                lblequivalente_modi1.Text = objeto.oMedida.Equivalente;
                lblequivalente_modi2.Text = objeto.oMedida.Equivalente;
            }

        }

        private void lblstockminimo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string mensaje = string.Empty;
            dgvdata.Rows.Clear();

            List<Producto> lista = LO_Producto.Instancia.Listar(out mensaje).Where(p => p.Stock <= p.StockMinimo).ToList();

            int indice = 0;
            foreach (Producto c in lista)
            {
                decimal _stock = Convert.ToDecimal(c.Stock.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(c.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));

                decimal _stock_minimo = Convert.ToDecimal(c.StockMinimo.ToString(), new CultureInfo("es-PE")) / Convert.ToDecimal(c.oCategoria.oMedida.Valor.ToString(), new CultureInfo("es-PE"));


                dgvdata.Rows.Add(new object[] {
                    c.IdProducto,
                    c.Codigo,
                    c.Descripcion,
                    c.oCategoria.Descripcion,
                    c.PrecioCompra.ToString("0.00"),
                    c.PrecioVenta.ToString("0.00"),
                    c.Utilidad.ToString("0.00"),
                    string.Concat(_stock.ToString("0.##",new CultureInfo("es-PE"))," ",c.oCategoria.oMedida.Descripcion),
                    string.Concat(_stock_minimo.ToString("0.##",new CultureInfo("es-PE"))," ",c.oCategoria.oMedida.Descripcion),
                    c.NombreCarpeta,
                    c.NombreArchivo,
                    "",
                    "",
                    "",
                    ""
                });

                
                dgvdata.Rows[indice].DefaultCellStyle.BackColor = Color.MistyRose;

                indice++;

            }
        }
    }
}
