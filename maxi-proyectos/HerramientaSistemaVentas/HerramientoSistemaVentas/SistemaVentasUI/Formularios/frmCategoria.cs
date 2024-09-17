using ClosedXML.Excel;
using SistemaVentasUI.Logica;
using SistemaVentasUI.Modelo;
using SistemaVentasUI.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentasUI.Formularios
{
    public partial class frmCategoria : Form
    {
        public frmCategoria()
        {
            InitializeComponent();
        }


        private void listar_categoria() {
            string mensaje = string.Empty;
            dgvdata.Rows.Clear();

            List<Categoria> lista1 = LO_Categoria.Instancia.Listar(out mensaje);
            foreach (Categoria c in lista1)
            {
                dgvdata.Rows.Add(new object[] {
                    c.IdCategoria,
                    c.Descripcion,
                    c.oMedida.Descripcion,
                    c.FechaRegistro,
                    "",
                    ""
                });
            }

        }

        private void frmCategoria_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            listar_categoria();


            List<Medida> lista2 = LO_Medida.Instancia.Listar(out mensaje);
            foreach (Medida m in lista2) {
                cbomedida1.Items.Add(new OpcionCombo() { Valor = m.IdMedida, Texto = m.Descripcion });
                cbomedida2.Items.Add(new OpcionCombo() { Valor = m.IdMedida, Texto = m.Descripcion });
            }
            cbomedida1.DisplayMember = "Texto";
            cbomedida1.ValueMember = "Valor";
            if(lista2.Count > 0) cbomedida1.SelectedIndex = 0;

            cbomedida2.DisplayMember = "Texto";
            cbomedida2.ValueMember = "Valor";
            if (lista2.Count > 0)  cbomedida2.SelectedIndex = 0;

            tabControl1.SelectedTab = tabControl1.TabPages["tabCatalogo"];

            cbobuscar.Items.Add(new OpcionCombo() { Valor = "Descripcion", Texto = "Descripcion" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "Medida", Texto = "Medida" });
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;


        }

   
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabCatalogo":
                    listar_categoria();
                    break;

                case "tabNuevo":
                    txtdescripcion1.Text = "";
                    cbomedida1.SelectedIndex = 0;
                    lblresultado1.Visible = false;
                    break;

                case "tabModificar":

                    txtidcategoria.Text = "";
                    txtdescripcion2.Text = "";
                    cbomedida2.SelectedIndex = 0;
                    lblresultado2.Visible = false;
                    break;
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.editar_17.Width;
                var h = Properties.Resources.editar_17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editar_17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
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

        private void btnguardarnuevo_Click(object sender, EventArgs e)
        {
            lblresultado1.Visible = true;
            string mensaje = string.Empty;

            if (txtdescripcion1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar la descripción";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            int existe = LO_Categoria.Instancia.Existe(txtdescripcion1.Text.Trim(), 0, out mensaje);
            if (existe > 0)
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            int idgenerado = LO_Categoria.Instancia.Guardar( new Categoria() {
                Descripcion = txtdescripcion1.Text.Trim(),
                oMedida = new Medida() { IdMedida = Convert.ToInt32(((OpcionCombo)cbomedida1.SelectedItem).Valor.ToString()) },
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd", new CultureInfo("en-US"))
            } , out mensaje);

            if (idgenerado > 0)
            {
                txtdescripcion1.Text = "";
                cbomedida1.SelectedIndex = 0;

                lblresultado1.Text = "La categoria fue registrada";
                lblresultado1.ForeColor = Color.Green;
            }
            else {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
            }

        }

        private void buscarcategoria() {
            string mensaje = string.Empty;
            List<Categoria> lista = LO_Categoria.Instancia.Listar(out mensaje);
            
            Categoria ocat = lista.Where(c => c.IdCategoria.ToString().Equals(txtidcategoria.Text.ToString().Trim()) ).FirstOrDefault();

            if (ocat != null)
            {
                txtdescripcion2.Text = ocat.Descripcion;

                int encontrado = 0;
                foreach (OpcionCombo oc in cbomedida2.Items)
                {
                    if (Convert.ToInt32(oc.Valor.ToString()) == ocat.oMedida.IdMedida) break;
                    encontrado++;
                }
                cbomedida2.SelectedIndex = encontrado;

                lblresultado2.Visible = false;
            }
            else {
                txtdescripcion2.Text = "";
                cbomedida2.SelectedIndex = 0;

                lblresultado2.Text = "No se encontraron resultados";
                lblresultado2.Visible = true;
                lblresultado2.ForeColor = Color.Red;
            }

        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mensaje = string.Empty;
            int index = e.RowIndex;
            if (index >= 0) {

                if (dgvdata.Columns[e.ColumnIndex].Name == "btneditar")
                {
                    tabControl1.SelectedTab = tabControl1.TabPages["tabModificar"];
                    txtidcategoria.Text = dgvdata.Rows[index].Cells["Id"].Value.ToString();
                    buscarcategoria();
                }
                else if(dgvdata.Columns[e.ColumnIndex].Name == "btneliminar") {

                    if (MessageBox.Show("¿Desea eliminar la categoria?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = int.Parse(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                        int respuesta = LO_Categoria.Instancia.Eliminar(id);
                        if (respuesta > 0)
                        {
                            dgvdata.Rows.RemoveAt(index);
                        }
                        else
                            MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                }

            }

        }

        private void btnbuscarcategoria_Click(object sender, EventArgs e)
        {
            buscarcategoria();
        }

        private void btnguardarmodificar_Click(object sender, EventArgs e)
        {
            lblresultado2.Visible = true;
            string mensaje = string.Empty;

            if (txtidcategoria.Text.Trim() == "") {
                lblresultado2.Text = "Debe buscar una categoria primero";
                lblresultado2.ForeColor = Color.Red;
                return;
            }


            int existe = LO_Categoria.Instancia.Existe(txtdescripcion1.Text.Trim(), Convert.ToInt32(txtidcategoria.Text.Trim()), out mensaje);
            if (existe > 0)
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
                return;
            }



            int filasafectadas = LO_Categoria.Instancia.Editar(new Categoria()
            {
                IdCategoria = Convert.ToInt32(txtidcategoria.Text.Trim()),
                Descripcion = txtdescripcion2.Text.Trim(),
                oMedida = new Medida() { IdMedida = Convert.ToInt32(((OpcionCombo)cbomedida2.SelectedItem).Valor.ToString()) }
            }, out mensaje);

            if (filasafectadas > 0)
            {
                txtidcategoria.Text = "";
                txtdescripcion2.Text = "";
                cbomedida2.SelectedIndex = 0;

                lblresultado2.Text = "Se guardaron los cambios";
                lblresultado2.ForeColor = Color.Green;
            }
            else
            {
                lblresultado2.Text = mensaje;
                lblresultado2.ForeColor = Color.Red;
            }
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
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_Categorias_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void txtidcategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) {
                buscarcategoria();
            }
        }
    }
}
