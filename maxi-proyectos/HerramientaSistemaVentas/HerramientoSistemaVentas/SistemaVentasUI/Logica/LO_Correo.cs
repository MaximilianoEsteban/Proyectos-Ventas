using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Logica
{
    public class LO_Correo
    {

        private static LO_Correo _instancia = null;

        public LO_Correo()
        {

        }

        public static LO_Correo Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new LO_Correo();
                return _instancia;
            }
        }

        public Correo ObtenerCorreo()
        {
            Correo obj = new Correo();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select IdCorreo,Email,Clave from CORREO where IdCorreo = 1";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            obj = new Correo()
                            {
                                IdCorreo = int.Parse(dr["IdCorreo"].ToString()),
                                Email = dr["Email"].ToString(),
                                Clave = dr["Clave"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                obj = new Correo();
            }
            return obj;
        }

        public int Guardar(string email,string clave, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update CORREO set Email = @pemail, Clave=@pclave");
                    query.AppendLine("where IdCorreo = 1;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pemail", email));
                    cmd.Parameters.Add(new SQLiteParameter("@pclave", clave));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar el correo";

                }
            }
            catch (Exception ex)
            {

                respuesta = 0;
                mensaje = ex.Message;
            }

            return respuesta;
        }


    }
}
