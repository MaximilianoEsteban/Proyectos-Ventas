using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Logica
{
    class LO_MonedaImporte
    {


        private static LO_MonedaImporte _instancia = null;

        public LO_MonedaImporte()
        {

        }

        public static LO_MonedaImporte Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new LO_MonedaImporte();
                return _instancia;
            }
        }

        public MonedaImporte Obtener()
        {
            MonedaImporte objeto = new MonedaImporte();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    string query = "select Simbolo,Porcentaje from MONEDA_IMPORTE where Id = 1";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objeto = new MonedaImporte()
                            {
                                Simbolo = dr["Simbolo"].ToString(),
                                Porcentaje = int.Parse(dr["Porcentaje"].ToString())
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objeto = new MonedaImporte();
            }
            return objeto;
        }

        public int Guardar(object valor,bool simbolo, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    if (simbolo)
                        query.AppendLine("update MONEDA_IMPORTE set Simbolo = @pvalue where Id = 1;");
                    else
                        query.AppendLine("update MONEDA_IMPORTE set Porcentaje = @pvalue where Id = 1;");



                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pvalue", valor));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo actualizar el " + (simbolo ? "Simbolo": "Porcentaje");

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
