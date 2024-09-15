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
    public class LO_Venta
    {

        private static LO_Venta _instancia = null;

        public LO_Venta()
        {

        }

        public static LO_Venta Instancia
        {

            get
            {
                if (_instancia == null) _instancia = new LO_Venta();
                return _instancia;
            }
        }


        public int ObtenerCorrelativo(out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select count(*) + 1 from Venta");
                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    respuesta = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                    if (respuesta < 1)
                    {
                        mensaje = "No se pudo generar el correlativo";
                    }
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                mensaje = "No se pudo generar el correlativo\nMayor Detalle:\n" + ex.Message;
            }

            return respuesta;
        }

        public int Registrar(Venta obj, out string mensaje)
        {

            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;

            using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
            {
                try
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("CREATE TEMP TABLE _TEMP(id INTEGER);");
                    query.AppendLine(string.Format("Insert into Venta(NumeroDocumento,FechaRegistro,UsuarioRegistro,NombreCliente,DocumentoCliente,CorreoCliente,CantidadProductos, MontoSubTotalValor,MontoSubTotalTexto,MontoIVAValor,MontoIVATexto,MontoTotalValor,MontoTotalTexto,PagoCon,Cambio,Estado) values('{0}','{1}','{2}','{3}','{4}','{5}',{6},'{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}',{15});",
                        obj.NumeroDocumento,
                        obj.FechaRegistro,
                        obj.UsuarioRegistro,
                        obj.NombreCliente,
                        obj.DocumentoCliente,
                        obj.CorreoCliente,
                        obj.CantidadProductos,

                        obj.MontoSubTotalValor.ToString("0.00", new CultureInfo("es-PE")),
                        obj.MontoSubTotalTexto,

                        obj.MontoIVAValor.ToString("0.00", new CultureInfo("es-PE")),
                        obj.MontoIVATexto,

                        obj.MontoTotalValor.ToString("0.00", new CultureInfo("es-PE")),
                        obj.MontoTotalTexto,
                        obj.PagoCon,
                        obj.Cambio,
                        obj.Estado ? 1: 0));

                    query.AppendLine("INSERT INTO _TEMP (id) VALUES (last_insert_rowid());");

                    foreach (DetalleVenta de in obj.oListaDetalleVenta)
                    {
                        query.AppendLine(string.Format("insert into DETALLE_VENTA(IdVenta,IdProducto,Producto,Categoria,CantidadValor,CantidadTexto,PrecioValor,PrecioTexto,TotalValor,TotalTexto,Estado) values({0},{1},'{2}','{3}',{4},'{5}','{6}','{7}','{8}','{9}',{10});",
                            "(select id from _TEMP)",
                            de.IdProducto,
                            de.Producto,
                            de.Categoria,
                            de.CantidadValor,
                            de.CantidadTexto,
                            de.PrecioValor.ToString("0.00", new CultureInfo("es-PE")),
                            de.PrecioTexto,
                            de.TotalValor.ToString("0.00", new CultureInfo("es-PE")),
                            de.TotalTexto,
                            de.Estado));

                    }

                    query.AppendLine("DROP TABLE _TEMP;");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();


                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo registrar la Venta de los productos";
                    }

                    objTransaccion.Commit();

                }
                catch (Exception ex)
                {
                    objTransaccion.Rollback();
                    respuesta = 0;
                    mensaje = ex.Message;
                }
            }


            return respuesta;
        }

        public Venta Obtener(string numerodocumento)
        {
            Venta objeto = null;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    
                    conexion.Open();
                    StringBuilder query = new StringBuilder();
                    query.AppendLine("select IdVenta, NumeroDocumento, strftime('%d/%m/%Y', date(FechaRegistro))[FechaRegistro],UsuarioRegistro,NombreCliente,");
                    query.AppendLine("DocumentoCliente,CorreoCliente,CantidadProductos,MontoSubTotalValor,MontoSubTotalTexto,");
                    query.AppendLine("MontoIVAValor,MontoIVATexto,MontoTotalValor,MontoTotalTexto,PagoCon,Cambio,Estado");
                    query.AppendLine("from VENTA where NumeroDocumento = @pnumero");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pnumero", numerodocumento));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            objeto = new Venta()
                            {
                                IdVenta = Convert.ToInt32(dr["IdVenta"].ToString()),
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                CorreoCliente = dr["CorreoCliente"].ToString(),
                                CantidadProductos = Convert.ToInt32(dr["CantidadProductos"].ToString()),

                                MontoSubTotalValor = Convert.ToDecimal(dr["MontoSubTotalValor"],new CultureInfo("es-PE")),
                                MontoSubTotalTexto = dr["MontoSubTotalTexto"].ToString(),

                                MontoIVAValor = Convert.ToDecimal(dr["MontoIVAValor"], new CultureInfo("es-PE")),
                                MontoIVATexto = dr["MontoIVATexto"].ToString(),

                                MontoTotalValor = Convert.ToDecimal(dr["MontoTotalValor"],new CultureInfo("es-PE")),
                                MontoTotalTexto = dr["MontoTotalTexto"].ToString(),

                                PagoCon = dr["PagoCon"].ToString(),
                                Cambio = dr["Cambio"].ToString(),
                                Estado = Convert.ToInt32(dr["Estado"]) == 1 ? true: false
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                objeto = null;
            }
            return objeto;
        }


        public List<DetalleVenta> ListarDetalle(int idVenta)
        {
            List<DetalleVenta> oLista = new List<DetalleVenta>();

            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select IdDetalleVenta,IdVenta,IdProducto,Producto,Categoria,CantidadValor,CantidadTexto,");
                    query.AppendLine("PrecioValor,PrecioTexto,TotalValor,TotalTexto,Estado");
                    query.AppendLine("from DETALLE_VENTA where IdVenta = @pidVenta");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pidVenta", idVenta));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new DetalleVenta()
                            {
                                IdDetalleVenta = Convert.ToInt32(dr["IdDetalleVenta"].ToString()),
                                IdVenta = Convert.ToInt32(dr["IdVenta"].ToString()),
                                IdProducto = Convert.ToInt32(dr["IdProducto"].ToString()),
                                Producto = dr["Producto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                CantidadValor = Convert.ToInt32(dr["CantidadValor"].ToString()),
                                CantidadTexto = dr["CantidadTexto"].ToString(),
                                PrecioValor = Convert.ToDecimal(dr["PrecioValor"], new CultureInfo("es-PE")),
                                PrecioTexto = dr["PrecioTexto"].ToString(),
                                TotalValor = Convert.ToDecimal(dr["TotalValor"], new CultureInfo("es-PE")),
                                TotalTexto = dr["TotalTexto"].ToString(),
                                Estado = Convert.ToInt32(dr["Estado"]) == 1 ? true : false
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<DetalleVenta>();
            }


            return oLista;
        }

        public int cancelar_venta(int idventa,List<DetalleVenta> odetalleventa, out string mensaje)
        {
            mensaje = string.Empty;
            int respuesta = 0;
            SQLiteTransaction objTransaccion = null;

            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    objTransaccion = conexion.BeginTransaction();
                    StringBuilder query = new StringBuilder();


                    query.AppendLine("update VENTA set Estado = 0 where IdVenta= @pidventa;");
                    query.AppendLine("update DETALLE_VENTA set Estado = 0 where IdVenta= @pidventa;");

                    foreach (DetalleVenta item in odetalleventa) {
                        query.AppendLine(string.Format("update Producto set Stock = Stock + {0} where IdProducto = {1};",item.CantidadValor,item.IdProducto));
                    }


                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.CommandType = System.Data.CommandType.Text;
                    cmd.Parameters.Add(new SQLiteParameter("@pidventa", idventa));
                    cmd.Transaction = objTransaccion;
                    respuesta = cmd.ExecuteNonQuery();

                    if (respuesta < 1)
                    {
                        objTransaccion.Rollback();
                        mensaje = "No se pudo cancelar la venta";
                    }

                    objTransaccion.Commit();
                }
            }
            catch (Exception ex)
            {
                respuesta = 0;
                objTransaccion.Rollback();
                mensaje = "No se pudo cancelar la venta\nMayor Detalle:\n" + ex.Message;
            }

            return respuesta;
        }


        public List<VistaVenta> ResumenVenta(string fechainicio = "", string fechafin = "")
        {
            List<VistaVenta> oLista = new List<VistaVenta>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select NumeroDocumento, strftime('%d/%m/%Y', date(FechaRegistro))[FechaRegistro],UsuarioRegistro,NombreCliente,DocumentoCliente,CorreoCliente,CantidadProductos,MontoSubTotalValor,");
                    query.AppendLine("MontoIVAValor,MontoTotalValor,PagoCon,Cambio,Estado from VENTA");
                    query.AppendLine("where DATE(FechaRegistro) BETWEEN DATE(@pfechainicio) AND DATE(@pfechafin)");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pfechainicio", fechainicio));
                    cmd.Parameters.Add(new SQLiteParameter("@pfechafin", fechafin));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new VistaVenta()
                            {
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                CorreoCliente = dr["CorreoCliente"].ToString(),
                                
                                CantidadProductos = dr["CantidadProductos"].ToString(),
                                MontoSubTotalValor = dr["MontoSubTotalValor"].ToString(),
                                MontoIVAValor = dr["MontoIVAValor"].ToString(),
                                MontoTotalValor = dr["MontoTotalValor"].ToString(),

                                PagoCon = dr["PagoCon"].ToString(),
                                Cambio = dr["Cambio"].ToString(),
                                Estado = dr["Estado"].ToString() == "1"? "Activo" : "Cancelado"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<VistaVenta>();
            }
            return oLista;
        }


        public List<VistaDetalleVenta> ResumenDetalle(string fechainicio = "", string fechafin = "")
        {
            List<VistaDetalleVenta> oLista = new List<VistaDetalleVenta>();
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(Conexion.cadena))
                {
                    conexion.Open();
                    StringBuilder query = new StringBuilder();

                    query.AppendLine("select v.NumeroDocumento,strftime('%d/%m/%Y', date(v.FechaRegistro))[FechaRegistro],v.UsuarioRegistro,v.NombreCliente,v.DocumentoCliente,v.CorreoCliente,");
                    query.AppendLine("dv.Producto,dv.Categoria,dv.PrecioValor[PrecioVenta],dv.CantidadValor[CantidadValor],REPLACE(m.Equivalente,'.','')[MedidaMinima],dv.TotalValor[Total],dv.Estado");
                    query.AppendLine("from VENTA v");
                    query.AppendLine("inner join DETALLE_VENTA dv on dv.IdVenta = v.IdVenta");
                    query.AppendLine("inner join Producto p on dv.IdProducto = p.IdProducto");
                    query.AppendLine("inner join Categoria c on c.IdCategoria = p.IdCategoria");
                    query.AppendLine("inner join MEDIDA m on m.IdMedida = c.IdMedida");
                    query.AppendLine("where DATE(v.FechaRegistro) BETWEEN DATE(@pfechainicio) AND DATE(@pfechafin)");

                    SQLiteCommand cmd = new SQLiteCommand(query.ToString(), conexion);
                    cmd.Parameters.Add(new SQLiteParameter("@pfechainicio", fechainicio));
                    cmd.Parameters.Add(new SQLiteParameter("@pfechafin", fechafin));
                    cmd.CommandType = System.Data.CommandType.Text;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oLista.Add(new VistaDetalleVenta()
                            {
                                NumeroDocumento = dr["NumeroDocumento"].ToString(),
                                FechaRegistro = dr["FechaRegistro"].ToString(),
                                UsuarioRegistro = dr["UsuarioRegistro"].ToString(),
                                NombreCliente = dr["NombreCliente"].ToString(),
                                DocumentoCliente = dr["DocumentoCliente"].ToString(),
                                CorreoCliente = dr["CorreoCliente"].ToString(),
                                Producto = dr["Producto"].ToString(),
                                Categoria = dr["Categoria"].ToString(),
                                PrecioVenta = dr["PrecioVenta"].ToString(),
                                CantidadValor = dr["CantidadValor"].ToString(),
                                MedidaMinima = dr["MedidaMinima"].ToString(),
                                Total = dr["Total"].ToString(),
                                Estado = dr["Estado"].ToString() == "1" ? "Activo" : "Cancelado"
                            });
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                oLista = new List<VistaDetalleVenta>();
            }
            return oLista;
        }


    }
}
