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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void listar_usuarios()
        {
            string mensaje = string.Empty;
            dgvdata.Rows.Clear();

            List<Usuario> lista1 = LO_Usuario.Instancia.Listar(out mensaje);
            foreach (Usuario c in lista1)
            {
                dgvdata.Rows.Add(new object[] {
                    c.IdUsuario,
                    c.NombreUsuario,
                    c.NumeroDocumento,
                    c.NombreCompleto,
                    c.IdRol == 1 ? "Administrador":"Empleado",
                    c.FechaRegistro,
                    c.Clave,
                    "",
                    ""
                });
            }

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            string mensaje = string.Empty;

            listar_usuarios();


            cbobuscar.Items.Add(new OpcionCombo() { Valor = "NombreUsuario", Texto = "Nombre Usuario" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "NumeroDocumento", Texto = "Numero Documento" });
            cbobuscar.Items.Add(new OpcionCombo() { Valor = "NombreCompleto", Texto = "Nombre Completo" });
            cbobuscar.DisplayMember = "Texto";
            cbobuscar.ValueMember = "Valor";
            cbobuscar.SelectedIndex = 0;

            cborol1.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Administrador" });
            cborol1.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Empleado" });
            cborol1.DisplayMember = "Texto";
            cborol1.ValueMember = "Valor";
            cborol1.SelectedIndex = 0;

            cborol2.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Administrador" });
            cborol2.Items.Add(new OpcionCombo() { Valor = 2, Texto = "Empleado" });
            cborol2.DisplayMember = "Texto";
            cborol2.ValueMember = "Valor";
            cborol2.SelectedIndex = 0;

            tabControl1.SelectedTab = tabControl1.TabPages["tabCatalogo"];
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Name)
            {
                case "tabCatalogo":
                    listar_usuarios();
                    break;

                case "tabNuevo":
                    txtusuario1.Text = "";
                    txtnrodocumento1.Text = "";
                    txtnombrecompleto1.Text = "";
                    cborol1.SelectedIndex = 0;
                    txtclave1.Text = "";
                    txtconfirmclave1.Text = "";

                    txtusuario1.Select();
                    lblresultado1.Visible = false;
                    break;

                case "tabModificar":
                    txtid.Text = "";

                    txtusuario2.Text = "";
                    txtnrodocumento2.Text = "";
                    txtnombrecompleto2.Text = "";
                    cborol2.SelectedIndex = 0;
                    txtclave2.Text = "";
                    txtconfirmclave2.Text = "";
                    lblresultado2.Visible = false;
                    break;
            }
        }

        private void dgvdata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (e.ColumnIndex == 7)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.editar_17.Width;
                var h = Properties.Resources.editar_17.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.editar_17, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
            if (e.ColumnIndex == 8)
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

            if (txtusuario1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar el usuario";
                lblresultado1.ForeColor = Color.Red;
                return;
            }
            if (txtnrodocumento1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar el numero de documento del usuario";
                lblresultado1.ForeColor = Color.Red;
                return;
            }
            if (txtnombrecompleto1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar el nombre del usuario";
                lblresultado1.ForeColor = Color.Red;
                return;
            }
            if (txtclave1.Text.Trim() == "")
            {
                lblresultado1.Text = "Debe ingresar la contraseña del usuario";
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            if (txtclave1.Text.Trim() != txtconfirmclave1.Text.Trim())
            {
                lblresultado1.Text = "Las constraseñas no coinciden";
                lblresultado1.ForeColor = Color.Red;
                return;
            }


            int existe = LO_Usuario.Instancia.Existe(txtusuario1.Text.Trim(), 0, out mensaje);
            if (existe > 0)
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
                return;
            }

            int idgenerado = LO_Usuario.Instancia.Guardar(new Usuario()
            {
                NombreUsuario = txtusuario1.Text.Trim(),
                NumeroDocumento = txtnrodocumento1.Text.Trim(),
                NombreCompleto = txtnombrecompleto1.Text.Trim(),
                IdRol = Convert.ToInt32(((OpcionCombo)cborol1.SelectedItem).Valor.ToString()),
                Clave = txtclave1.Text.Trim(),
                FechaRegistro = DateTime.Now.ToString("yyyy-MM-dd", new CultureInfo("en-US"))
            }, out mensaje);

            if (idgenerado > 0)
            {
                txtusuario1.Text = "";
                txtnrodocumento1.Text = "";
                txtnombrecompleto1.Text = "";
                cborol1.SelectedIndex = 0;
                txtclave1.Text = "";
                txtconfirmclave1.Text = "";
                txtusuario1.Select();

                lblresultado1.Text = "El usuario fue registrado";
                lblresultado1.ForeColor = Color.Green;
            }
            else
            {
                lblresultado1.Text = mensaje;
                lblresultado1.ForeColor = Color.Red;
            }
        }

        private void buscarusuario()
        {
            string mensaje = string.Empty;
            List<Usuario> lista = LO_Usuario.Instancia.Listar(out mensaje);

            Usuario obj = lista.Where(c => c.NombreUsuario.ToString().Equals(txtusuario2.Text.ToString().Trim())).FirstOrDefault();

            if (obj != null)
            {
                txtid.Text = obj.IdUsuario.ToString();

                txtnrodocumento2.Text = obj.NumeroDocumento;
                txtnombrecompleto2.Text = obj.NombreCompleto;
                int encontrado = 0;
                foreach (OpcionCombo oc in cborol2.Items)
                {
                    if (Convert.ToInt32(oc.Valor.ToString()) == obj.IdRol) break;
                    encontrado++;
                }
                cborol2.SelectedIndex = encontrado;
                txtclave2.Text = obj.Clave;
                txtconfirmclave2.Text = obj.Clave;


                lblresultado2.Visible = false;
            }
            else
            {
                txtid.Text = "";
                txtnrodocumento2.Text = "";
                txtnombrecompleto2.Text = "";
                cborol2.SelectedIndex = 0;
                txtclave2.Text = "";
                txtconfirmclave2.Text = "";

                lblresultado2.Text = "No se encontraron resultados";
                lblresultado2.Visible = true;
                lblresultado2.ForeColor = Color.Red;
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
                    txtusuario2.Text = dgvdata.Rows[index].Cells["NombreUsuario"].Value.ToString();
                    buscarusuario();
                }
                else if (dgvdata.Columns[e.ColumnIndex].Name == "btneliminar")
                {

                    if (MessageBox.Show("¿Desea eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = int.Parse(dgvdata.Rows[index].Cells["Id"].Value.ToString());
                        int respuesta = LO_Usuario.Instancia.Eliminar(id);
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

        private void btnbuscarusuario_Click(object sender, EventArgs e)
        {
            buscarusuario();
        }

        private void btnguardarmodificar_Click(object sender, EventArgs e)
        {

            lblresultado2.Visible = true;

            string mensaje = string.Empty;

            if (txtid.Text.Trim() == "") {
                lblresultado2.Text = "No se encontro usuario";
                lblresultado2.ForeColor = Color.Red;
                return;
            }

           
            if (txtusuario2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar el usuario";
                lblresultado2.ForeColor = Color.Red;
                return;
            }
            if (txtnrodocumento2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar el numero de documento del usuario";
                lblresultado2.ForeColor = Color.Red;
                return;
            }
            if (txtnombrecompleto2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar el nombre del usuario";
                lblresultado2.ForeColor = Color.Red;
                return;
            }
            if (txtclave2.Text.Trim() == "")
            {
                lblresultado2.Text = "Debe ingresar la contraseña del usuario";
                lblresultado2.ForeColor = Color.Red;
                return;
            }

            if (txtclave2.Text.Trim() != txtconfirmclave2.Text.Trim())
            {
                lblresultado2.Text = "Las constraseñas no coinciden";
                lblresultado2.ForeColor = Color.Red;
                return;
            }

            int existe = LO_Usuario.Instancia.Existe(txtusuario2.Text.Trim(), Convert.ToInt32(txtid.Text.Trim()), out mensaje);
            if (existe > 0)
            {
                lblresultado2.Text = mensaje;
                lblresultado2.ForeColor = Color.Red;
                return;
            }



            int filasafectadas = LO_Usuario.Instancia.Editar(new Usuario()
            {
                IdUsuario = Convert.ToInt32(txtid.Text),
                NombreUsuario = txtusuario2.Text.Trim(),
                NumeroDocumento = txtnrodocumento2.Text.Trim(),
                NombreCompleto = txtnombrecompleto2.Text.Trim(),
                IdRol = Convert.ToInt32(((OpcionCombo)cborol2.SelectedItem).Valor.ToString()),
                Clave = txtclave2.Text.Trim(),
            }, out mensaje);

            if (filasafectadas > 0)
            {
                txtid.Text = "";
                txtusuario2.Text = "";
                txtnrodocumento2.Text = "";
                txtnombrecompleto2.Text = "";
                cborol2.SelectedIndex = 0;
                txtclave2.Text = "";
                txtconfirmclave2.Text = "";
                txtusuario2.Select();

                lblresultado2.Text = "Se guardaron los cambios";
                lblresultado2.ForeColor = Color.Green;
            }
            else
            {
                lblresultado2.Text = mensaje;
                lblresultado2.ForeColor = Color.Red;
            }
        }
    }
}
