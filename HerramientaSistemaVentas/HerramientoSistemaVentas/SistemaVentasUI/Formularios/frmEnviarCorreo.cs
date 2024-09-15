using SistemaVentasUI.Utilidades;
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
    public partial class frmEnviarCorreo : Form
    {
        public frmEnviarCorreo()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {

            string Themessage = @"<html>
                          <body>
                            <table border=""1"" width=""100%"">
                                <tr>
                                    <td >
                                        </br>
                                        <center><label style=""font-style:arial; color:black; font-weight:bold; font-size:18pt""> 
                                            Hola, este es un mensaje de prueba</label>
                                        </center>
                                        </br></br>

                                        <center> <img style=""width:90px;height:90px"" src=""!imagen!""/></center>

                                        </br></br>
                        
                                        <center>
                                            <label style=""font-style:arial; color:black; font-weight:bold; font-size:12pt""> 
                                            developed by: Codigo Estudiante
                                            </label> </br><label style=""font-style:arial; color:black; font-weight:bold; font-size:12pt""> 
                                            find us: Youtube
                                            </label>
                                        </center>
                                        </br>
                                    </td>
                                </tr>
                            </table>
                            </body>
                            </html>";



            bool respuesta = Operaciones.EnviarCorreo3(txtcorreo.Text, "Pruebas - Venta Fácil CE", Themessage);


            if (respuesta)
            {
                lblresultado5.Text = "El correo fue enviado";
                lblresultado5.Visible = true;
                lblresultado5.ForeColor = Color.Green;
            }
            else {
                lblresultado5.Text = "Error al enviar correo";
                lblresultado5.Visible = true;
                lblresultado5.ForeColor = Color.Red;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
