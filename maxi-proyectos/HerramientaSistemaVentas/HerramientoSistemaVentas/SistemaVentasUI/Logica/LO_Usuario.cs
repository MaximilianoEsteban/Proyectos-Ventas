using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Logica
{
    public class LO_Usuario
    {

        private static LO_Usuario _instancia = null;

        public LO_Usuario()
        {

        }

        public static LO_Usuario Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new LO_Usuario();
                return _instancia;
            }
        }

        //public int resetear()
        //{
        //    int respuesta = 0;
        //    try
        //    {
        //        using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
        //        {
        //            conexion.Open();
        //            StringBuilder query = new StringBuilder();
        //            query.AppendLine("update USUARIO set NombreUsuario = 'Admin', Clave = '123' where IdUsuario = 1;");
        //            SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
        //            cmd.CommandType = System.Data.CommandType.Text;

        //            respuesta = cmd.ExecuteNonQuery();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        respuesta = 0;
        //    }

        //    return respuesta;
        //}


        public List<Usuario> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Usuario> oLista = new List<Usuario>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {


                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdUsuario,NombreUsuario,NumeroDocumento,NombreCompleto,IdRol,strftime('%d/%m/%Y', date(FechaRegistro))[FechaRegistro],Clave from USUARIO");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Usuario()
                            {
                                IdUsuario = int.Parse(dr["IdUsuario"].ToString()),
                                NombreUsuario = dr["NombreUsuario"].ToString(),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                NombreCompleto = dr["NombreCompleto"].ToString(),
                                IdRol = Convert.ToInt32(dr["IdRol"].ToString()),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                Clave = dr["Clave"].ToString(),
                                
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Usuario>();
                mensaje = ex.Message;
            }
            return oLista;
        }

        public int Existe(string usuario, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*)[resultado] from USUARIO where upper(NombreUsuario) = upper(@pnombreusuario) and IdUsuario != @defaultid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnombreusuario", usuario));
                    cmd.Parameters.Add(new SQLiteParameter("@defaultid", defaultid));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta > 0)
                        mensaje = "El usuario ya existe";

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }

            }
            return respuesta;
        }

        public int Guardar(Usuario objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into USUARIO(NombreUsuario,NumeroDocumento,NombreCompleto,IdRol,FechaRegistro,Clave) values (@p1,@p2,@p3,@p4,@p5,@p6);");
                    query.AppendLine("select last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@p1", objeto.NombreUsuario));
                    cmd.Parameters.Add(new SQLiteParameter("@p2", objeto.NumeroDocumento));
                    cmd.Parameters.Add(new SQLiteParameter("@p3", objeto.NombreCompleto));
                    cmd.Parameters.Add(new SQLiteParameter("@p4", objeto.IdRol));
                    cmd.Parameters.Add(new SQLiteParameter("@p5", objeto.FechaRegistro));
                    cmd.Parameters.Add(new SQLiteParameter("@p6", objeto.Clave));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar el usuario";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }

        public int Editar(Usuario objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update USUARIO set NombreUsuario = @p1,NumeroDocumento = @p2,NombreCompleto = @p3,IdRol = @p4, Clave = @p5 where IdUsuario = @pid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@p1", objeto.NombreUsuario));
                    cmd.Parameters.Add(new SQLiteParameter("@p2", objeto.NumeroDocumento));
                    cmd.Parameters.Add(new SQLiteParameter("@p3", objeto.NombreCompleto));
                    cmd.Parameters.Add(new SQLiteParameter("@p4", objeto.IdRol));
                    cmd.Parameters.Add(new SQLiteParameter("@p5", objeto.Clave));
                    cmd.Parameters.Add(new SQLiteParameter("@pid", objeto.IdUsuario));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo editar el usuario";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }
            return respuesta;
        }


        public int Eliminar(int id)
        {
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("delete from USUARIO where IdUsuario= @id;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
            }
            return respuesta;
        }


        public int resetear()
        {
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update USUARIO set NombreUsuario = 'CodigoEstudiante', Clave = '12345' where IdUsuario = 1;");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
            }

            return respuesta;
        }


    }
}
