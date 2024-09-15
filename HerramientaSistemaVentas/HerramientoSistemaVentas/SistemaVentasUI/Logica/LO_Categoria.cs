using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Logica
{
    public class LO_Categoria
    {
        private static LO_Categoria _instancia = null;

        public LO_Categoria()
        {

        }

        public static LO_Categoria Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new LO_Categoria();
                return _instancia;
            }
        }


        public List<Categoria> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Categoria> oLista = new List<Categoria>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select c.IdCategoria,c.Descripcion,m.IdMedida,m.Descripcion[DesMedida],m.Equivalente,strftime('%d/%m/%Y', date(c.FechaRegistro))[FechaRegistro] from CATEGORIA c");
                    query.AppendLine("inner join MEDIDA m on m.IdMedida = c.IdMedida");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Categoria()
                            {
                                IdCategoria = int.Parse(dr["IdCategoria"].ToString()),
                                Descripcion = dr["Descripcion"].ToString(),
                                oMedida = new Medida() {
                                    IdMedida = int.Parse(dr["IdMedida"].ToString()),
                                    Descripcion = dr["DesMedida"].ToString(),
                                    Equivalente = dr["Equivalente"].ToString()
                                },
                                FechaRegistro = dr["FechaRegistro"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Categoria>();
                mensaje = ex.Message;
            }
            return oLista;
        }




        public int Existe(string descripcion, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*)[resultado] from CATEGORIA where upper(Descripcion) = upper(@pdescripcion) and IdCategoria != @defaultid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pdescripcion", descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@defaultid", defaultid));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta > 0)
                        mensaje = "La categoria ya existe";

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }

            }
            return respuesta;
        }


        public int Guardar(Categoria objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into CATEGORIA(Descripcion,IdMedida,FechaRegistro) VALUES(@p1,@p2,@p3);");
                    query.AppendLine("select last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@p1", objeto.Descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@p2", objeto.oMedida.IdMedida));
                    cmd.Parameters.Add(new SQLiteParameter("@p3", objeto.FechaRegistro));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar la categoria";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }

        public int Editar(Categoria objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("update CATEGORIA set Descripcion = @p1,IdMedida = @p2 where IdCategoria = @pid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@p1", objeto.Descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@p2", objeto.oMedida.IdMedida));
                    cmd.Parameters.Add(new SQLiteParameter("@pid", objeto.IdCategoria));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo guardar los cambios";
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
                    query.AppendLine("delete from CATEGORIA where IdCategoria= @id;");
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





    }
}
