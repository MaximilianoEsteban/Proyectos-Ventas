using SistemaVentasUI.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentasUI.Logica
{
    public class LO_Producto
    {

        private static LO_Producto _instancia = null;

        public LO_Producto()
        {

        }

        public static LO_Producto Instancia
        {
            get
            {
                if (_instancia == null) _instancia = new LO_Producto();
                return _instancia;
            }
        }

        public Producto obtener(int id, out string mensaje)
        {
            mensaje = string.Empty;
            Producto objeto = new Producto();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdProducto, p.Codigo,p.Descripcion,c.IdCategoria,c.Descripcion[DesCategoria],p.PrecioCompra,p.PrecioVenta,p.Utilidad,p.Stock,");
                    query.AppendLine("p.StockMinimo,p.NombreCarpeta,p.NombreArchivo,m.IdMedida,m.Descripcion[DesMedida],m.Equivalente,m.Valor");
                    query.AppendLine("from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");
                    query.AppendLine("inner join MEDIDA m on m.IdMedida = c.IdMedida");
                    query.AppendLine("where p.IdProducto = @pid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pid", id));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objeto = new Producto()
                            {
                                IdProducto = int.Parse(dr["IdProducto"].ToString()),
                                Codigo = dr["Codigo"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new Categoria() {
                                    IdCategoria = int.Parse(dr["IdCategoria"].ToString()),
                                    Descripcion = dr["DesCategoria"].ToString(),
                                    oMedida = new Medida() {
                                        IdMedida = int.Parse(dr["IdMedida"].ToString()),
                                        Equivalente = dr["Equivalente"].ToString(),
                                        Descripcion = dr["DesMedida"].ToString(),
                                        Valor = int.Parse(dr["Valor"].ToString())
                                    }
                                },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"], new CultureInfo("es-PE")),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"], new CultureInfo("es-PE")),
                                Utilidad = Convert.ToDecimal(dr["Utilidad"], new CultureInfo("es-PE")),
                                Stock = Convert.ToInt32(dr["Stock"]),
                                StockMinimo = Convert.ToInt32(dr["StockMinimo"]),
                                NombreCarpeta = dr["NombreCarpeta"].ToString(),
                                NombreArchivo = dr["NombreArchivo"].ToString()
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objeto = new Producto();
                mensaje = ex.Message;
            }


            return objeto;
        }


        public List<Producto> Listar(out string mensaje)
        {
            mensaje = string.Empty;
            List<Producto> oLista = new List<Producto>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();

                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select p.IdProducto, p.Codigo,p.Descripcion,c.IdCategoria,c.Descripcion[DesCategoria],p.PrecioCompra,p.PrecioVenta,p.Utilidad,p.Stock,");
                    query.AppendLine("p.StockMinimo,p.NombreCarpeta,p.NombreArchivo,m.IdMedida,m.Equivalente,m.Descripcion[DesMedida],m.Valor");
                    query.AppendLine("from PRODUCTO p");
                    query.AppendLine("inner join CATEGORIA c on c.IdCategoria = p.IdCategoria");
                    query.AppendLine("inner join MEDIDA m on m.IdMedida = c.IdMedida");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new Producto()
                            {
                                IdProducto = int.Parse(dr["IdProducto"].ToString()),
                                Codigo = dr["Codigo"].ToString(),
                                Descripcion = dr["Descripcion"].ToString(),
                                oCategoria = new Categoria() {
                                    IdCategoria = int.Parse(dr["IdCategoria"].ToString()),
                                    Descripcion = dr["DesCategoria"].ToString(),
                                    oMedida = new Medida()
                                    {
                                        IdMedida = int.Parse(dr["IdMedida"].ToString()),
                                        Equivalente = dr["Equivalente"].ToString(),
                                        Descripcion = dr["DesMedida"].ToString(),
                                        Valor = int.Parse(dr["Valor"].ToString())
                                    }
                                },
                                PrecioCompra = Convert.ToDecimal(dr["PrecioCompra"], new CultureInfo("es-PE")),
                                PrecioVenta = Convert.ToDecimal(dr["PrecioVenta"],new CultureInfo("es-PE")),
                                Utilidad = Convert.ToDecimal(dr["Utilidad"],new CultureInfo("es-PE")),
                                Stock = Convert.ToInt32(dr["Stock"]),
                                StockMinimo = Convert.ToInt32(dr["StockMinimo"]),
                                NombreCarpeta = dr["NombreCarpeta"].ToString(),
                                NombreArchivo = dr["NombreArchivo"].ToString()
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<Producto>();
                mensaje = ex.Message;
            }


            return oLista;
        }



        public int Existe(string codigo, int defaultid, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*)[resultado] from PRODUCTO where upper(Codigo) = upper(@pcodigo) and IdProducto != @defaultid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pcodigo", codigo));
                    cmd.Parameters.Add(new SQLiteParameter("@defaultid", defaultid));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta > 0)
                        mensaje = "El codigo de producto ya existe";

                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }

            }
            return respuesta;
        }


        public int Guardar(Producto objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("insert into PRODUCTO(Codigo,Descripcion,IdCategoria,PrecioCompra,PrecioVenta,Utilidad,Stock,StockMinimo)");
                    query.AppendLine("values (@pcodigo,@pdescripcion,@pidcategoria,@ppcompra,@ppventa,@putilidad,@pstock,@pstockminimo);");
                    query.AppendLine("select last_insert_rowid();");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pcodigo", objeto.Codigo));
                    cmd.Parameters.Add(new SQLiteParameter("@pdescripcion", objeto.Descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@pidcategoria", objeto.oCategoria.IdCategoria));
                    cmd.Parameters.Add(new SQLiteParameter("@ppcompra", objeto.PrecioCompra.ToString("0.00",new CultureInfo("es-PE"))));
                    cmd.Parameters.Add(new SQLiteParameter("@ppventa", objeto.PrecioVenta.ToString("0.00", new CultureInfo("es-PE"))));
                    cmd.Parameters.Add(new SQLiteParameter("@putilidad", objeto.Utilidad.ToString("0.00", new CultureInfo("es-PE") )));
                    cmd.Parameters.Add(new SQLiteParameter("@pstock", objeto.Stock));
                    cmd.Parameters.Add(new SQLiteParameter("@pstockminimo", objeto.StockMinimo));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());
                    if (respuesta < 1)
                        mensaje = "No se pudo registrar el producto";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }

        public int ActualizarImagen(string idproducto,string nombrearchivo, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {

                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update PRODUCTO set NombreArchivo = @pnombrearchivo where IdProducto = @pidproducto");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pidproducto", idproducto));
                    cmd.Parameters.Add(new SQLiteParameter("@pnombrearchivo", nombrearchivo));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo guardar la imagen del producto";
                }
                catch (Exception ex)
                {
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }

            return respuesta;
        }


        public int Editar(Producto objeto, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("update PRODUCTO set Codigo = @pcodigo, Descripcion = @pdescrip,");
                    query.AppendLine("IdCategoria = @pidcategoria, PrecioCompra = @ppcompra, PrecioVenta = @ppventa,");
                    query.AppendLine("Utilidad = @putilidad, Stock = @pstock, StockMinimo = @pstockminimo");
                    query.AppendLine("where IdProducto = @pid");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pcodigo", objeto.Codigo));
                    cmd.Parameters.Add(new SQLiteParameter("@pdescrip", objeto.Descripcion));
                    cmd.Parameters.Add(new SQLiteParameter("@pidcategoria", objeto.oCategoria.IdCategoria));
                    cmd.Parameters.Add(new SQLiteParameter("@ppcompra", objeto.PrecioCompra.ToString("0.00", new CultureInfo("es-PE"))));
                    cmd.Parameters.Add(new SQLiteParameter("@ppventa", objeto.PrecioVenta.ToString("0.00", new CultureInfo("es-PE"))));
                    cmd.Parameters.Add(new SQLiteParameter("@putilidad", objeto.Utilidad.ToString("0.00", new CultureInfo("es-PE"))));
                    cmd.Parameters.Add(new SQLiteParameter("@pstock", objeto.Stock));
                    cmd.Parameters.Add(new SQLiteParameter("@pstockminimo", objeto.StockMinimo));
                    cmd.Parameters.Add(new SQLiteParameter("@pid", objeto.IdProducto));
                    cmd.CommandType = System.Data.CommandType.Text;

                    respuesta = cmd.ExecuteNonQuery();
                    if (respuesta < 1)
                        mensaje = "No se pudo editar el producto";
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
                    query.AppendLine("delete from PRODUCTO where IdProducto= @id;");
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



        public int Control(int id,int stock,bool sumar)
        {
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    if (sumar)
                    {
                        query.AppendLine("update PRODUCTO set stock = stock + @pstock where IdProducto= @id;");
                    }
                    else {
                        query.AppendLine("update PRODUCTO set stock = stock - @pstock where IdProducto= @id;");
                    }
                    

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@id", id));
                    cmd.Parameters.Add(new SQLiteParameter("@pstock", stock));
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
