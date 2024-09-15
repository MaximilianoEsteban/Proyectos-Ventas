using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Logica
{
    public class LO_Medida
    {
        private static LO_Medida _instancia = null;

        public LO_Medida()
        {

        }

        public static LO_Medida Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new LO_Medida();
                return _instancia;
            }
        }


        public List<Medida> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Medida> oLista = new List<Medida>();

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    
                    string query = "select IdMedida,Descripcion from MEDIDA";
                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Medida()
                            {
                                IdMedida = int.Parse(dr["IdMedida"].ToString()),
                                Descripcion = dr["Descripcion"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Medida>();
                mensaje = ex.Message;
            }
            return oLista;
        }
    }
}
