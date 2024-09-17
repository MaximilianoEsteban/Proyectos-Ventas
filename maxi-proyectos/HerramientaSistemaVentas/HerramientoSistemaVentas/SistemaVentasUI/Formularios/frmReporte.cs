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
    public partial class frmReporte : Form
    {
        public frmReporte()
        {
            InitializeComponent();
        }

        private void frmReporte_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn cl in dgvdata1.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnseleccionar")
                {
                    cbobuscar1.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar1.DisplayMember = "Texto";
            cbobuscar1.ValueMember = "Valor";
            cbobuscar1.SelectedIndex = 0;

            foreach (DataGridViewColumn cl in dgvdata2.Columns)
            {
                if (cl.Visible == true && cl.Name != "btnseleccionar")
                {
                    cbobuscar2.Items.Add(new OpcionCombo() { Valor = cl.Name, Texto = cl.HeaderText });
                }
            }
            cbobuscar2.DisplayMember = "Texto";
            cbobuscar2.ValueMember = "Valor";
            cbobuscar2.SelectedIndex = 0;
        }

        private void btnbuscar1_Click(object sender, EventArgs e)
        {
            dgvdata1.Rows.Clear();

            DateTime dt1 = Convert.ToDateTime(txtfechainicio1.Value.ToString("dd/MM/yyyy"));
            DateTime dt2 = Convert.ToDateTime(txtfechafin1.Value.ToString("dd/MM/yyyy"));
            List<VistaVenta> lista = LO_Venta.Instancia.ResumenVenta(dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")), dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")));

            foreach (VistaVenta vr in lista)
            {

                dgvdata1.Rows.Add(new object[] {
                    vr.Estado,
                    vr.NumeroDocumento,
                    vr.FechaRegistro,
                    vr.UsuarioRegistro,
                    vr.NombreCliente,
                    vr.DocumentoCliente,
                    vr.CorreoCliente,
                    vr.CantidadProductos,
                    vr.MontoSubTotalValor,
                    vr.MontoIVAValor,
                    vr.MontoTotalValor,
                    vr.PagoCon,
                    vr.Cambio
                });
            }
        }

        private void btnbusqueda1_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar1.SelectedItem).Valor.ToString();

            if (dgvdata1.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata1.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnborrar1_Click(object sender, EventArgs e)
        {
            txtbuscar.Text = "";
            foreach (DataGridViewRow row in dgvdata1.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnexportar1_Click(object sender, EventArgs e)
        {
            if (dgvdata1.Rows.Count < 1)
            {

                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvdata1.Columns)
                    dt.Columns.Add(column.HeaderText, typeof(string));

                foreach (DataGridViewRow row in dgvdata1.Rows)
                {
                    if (row.Visible == true)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString()
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_Venta_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void btnbuscar2_Click(object sender, EventArgs e)
        {
            dgvdata2.Rows.Clear();

            DateTime dt1 = Convert.ToDateTime(txtfechainicio1.Value.ToString("dd/MM/yyyy"));
            DateTime dt2 = Convert.ToDateTime(txtfechafin1.Value.ToString("dd/MM/yyyy"));
            List<VistaDetalleVenta> lista = LO_Venta.Instancia.ResumenDetalle(dt1.ToString("yyyy-MM-dd", new CultureInfo("en-US")), dt2.ToString("yyyy-MM-dd", new CultureInfo("en-US")));

            foreach (VistaDetalleVenta vr in lista)
            {

                dgvdata2.Rows.Add(new object[] {
                    vr.Estado,
                    vr.NumeroDocumento,
                    vr.FechaRegistro,
                    vr.UsuarioRegistro,
                    vr.NombreCliente,
                    vr.DocumentoCliente,
                    vr.CorreoCliente,
                    vr.Producto,
                    vr.Categoria,
                    vr.PrecioVenta,
                    vr.CantidadValor,
                    vr.MedidaMinima,
                    vr.Total
                });
            }
        }

        private void btnbusqueda2_Click(object sender, EventArgs e)
        {
            string columnaFiltro = ((OpcionCombo)cbobuscar2.SelectedItem).Valor.ToString();

            if (dgvdata2.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvdata2.Rows)
                {
                    if (row.Cells[columnaFiltro].Value.ToString().Trim().ToUpper().Contains(txtbuscar2.Text.ToUpper()))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
        }

        private void btnborrar2_Click(object sender, EventArgs e)
        {

            txtbuscar2.Text = "";
            foreach (DataGridViewRow row in dgvdata2.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnexportar2_Click(object sender, EventArgs e)
        {
            if (dgvdata2.Rows.Count < 1)
            {

                MessageBox.Show("No hay datos para exportar", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DataTable dt = new DataTable();
                foreach (DataGridViewColumn column in dgvdata2.Columns)
                    dt.Columns.Add(column.HeaderText, typeof(string));

                foreach (DataGridViewRow row in dgvdata2.Rows)
                {
                    if (row.Visible == true)
                        dt.Rows.Add(new object[] {
                            row.Cells[0].Value.ToString(),
                            row.Cells[1].Value.ToString(),
                            row.Cells[2].Value.ToString(),
                            row.Cells[3].Value.ToString(),
                            row.Cells[4].Value.ToString(),
                            row.Cells[5].Value.ToString(),
                            row.Cells[6].Value.ToString(),
                            row.Cells[7].Value.ToString(),
                            row.Cells[8].Value.ToString(),
                            row.Cells[9].Value.ToString(),
                            row.Cells[10].Value.ToString(),
                            row.Cells[11].Value.ToString(),
                            row.Cells[12].Value.ToString()
                        });
                }

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.FileName = string.Format("Reporte_Detalle_Venta_{0}.xlsx", DateTime.Now.ToString("ddMMyyyyHHmmss"));
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (tabControl1.SelectedTab.Name)
            {
                case "tabVenta":
                    dgvdata1.Rows.Clear();
                    txtbuscar.Text = "";
                    break;

                case "tabDetalle":
                    dgvdata2.Rows.Clear();
                    txtbuscar2.Text = "";
                    break;
            }
        }
    }
}
