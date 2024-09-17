using Carrefour.BackEnd.Entity;
using Dapper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class VentasRepository
    {
        private readonly SqlConnection sqlConnection;
        public VentasRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public void Guardar(VentaCabeceraEntity ventaCabecera, List<VentaDetalleEntity> listaVentaDetalle)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
            var transaction = this.sqlConnection.BeginTransaction();
            try
            {
                string queryCabecera = @"INSERT INTO dbo.VentaCabecera
                                         (Fecha, IdUsuario, IdComprobante) 
                                         VALUES
                                         (@fecha, @idUsuario , @idComprobante)";

                var resultCabecera = sqlConnection.Execute(queryCabecera, ventaCabecera, transaction);

                string queryListaVentaDetalle = @"INSERT INTO dbo.VentaDetalle 
                                                  (IdVenta, IdProducto, IdFormaPago, Cantidad, PrecioUnidadVenta, ImporteTotal) 
                                                  VALUES
                                                  (@idVenta, @idProducto, @formaPago, @cantidad, @precioUnidadVenta, @importeTotal)";                              

                var resultListaVentaDetalle = sqlConnection.Execute(queryListaVentaDetalle, listaVentaDetalle, transaction);

                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }

        public void Editar(VentaCabeceraEntity ventaCabecera, VentaDetalleEntity ventaDetalle)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
            var transaction = this.sqlConnection.BeginTransaction();
            try
            {
                string queryCabecera = @"UPDATE dbo.VentaCabecera 
                                            SET Fecha = @Fecha,
                                                IdUsuario = @idUsuario,
                                                IdComprobante = @idComprobante
                                            WHERE IdVenta = @IdVenta";
                var resultCabecera = sqlConnection.Execute(queryCabecera, ventaCabecera, transaction);

                string queryDetalle = @"UPDATE dbo.VentaDetalle 
                                           SET IdVenta = @idVenta, 
                                               IdProducto = @idProducto, 
                                               IdFormaPago = @idFormaPago,
                                               Cantidad = @cantidad, 
                                               PrecioUnitarioVenta = @precioUnitarioVenta, 
                                               ImporteTotal = @importeTotal
                                       WHERE IdVentaDetalle = @IdVentaDetalle";
                var result = sqlConnection.Execute(queryDetalle, ventaDetalle, transaction);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }

        public void Eliminar(int IdVenta, int IdVentaDetalle)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();
            var transaction = this.sqlConnection.BeginTransaction();
            try
            {
                string sentenceCabecera = "DELETE FROM dbo.VentaCabecera WHERE IdVenta = @IdVenta";
                var resultCabecera = sqlConnection.Execute(sentenceCabecera, new { IdVenta = IdVenta }, transaction);

                string sentenceDetalle = "DELETE FROM dbo.VentaDetalle WHERE IdVentaDetalle = @IdVentaDetalle";
                var resultDetalle = sqlConnection.Execute(sentenceDetalle, new { IdVentaDetalle = IdVentaDetalle }, transaction);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }
    }
}
