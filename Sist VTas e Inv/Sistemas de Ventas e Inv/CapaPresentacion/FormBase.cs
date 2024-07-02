using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual bool Guardar()
        {
            return false;
        }

        public virtual void Editar()
        {

        }

        public virtual void Eliminar()
        {

        }

        public virtual void Buscar()
        {

        }
    }
}
