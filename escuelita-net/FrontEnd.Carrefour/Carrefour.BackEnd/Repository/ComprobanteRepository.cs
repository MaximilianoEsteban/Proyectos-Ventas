using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class ComprobanteRepository
    {
        private readonly SqlConnection sqlConnection;
        public ComprobanteRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<ComprobanteEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Comprobante";
                var result = sqlConnection.Query<ComprobanteEntity>(query).ToList();

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }


        public ComprobanteEntity Obtener(int IdComprobante)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Comprobante WHERE IdComprobante = @IdComprobante";
                var result = sqlConnection.QueryFirstOrDefault<ComprobanteEntity>(query, new { IdComprobante = IdComprobante });

                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }


        public void Guardar(ComprobanteEntity comprobante)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Comprobante(Comprobante) 
                                VALUES(@comprobante)";
                var result = sqlConnection.Execute(query, comprobante);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }

        public void Eliminar(int IdComprobante)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Comprobante WHERE IdComprobante = @IdComprobante";
                var result = sqlConnection.Execute(sentence, new { IdComprobante = IdComprobante });
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }

        public void Editar(ComprobanteEntity comprobante)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Comprobante 
                                    SET Comprobante = @comprobante                                        
                                WHERE IdComprobante = @IdComprobante";
                var result = sqlConnection.Execute(query, comprobante);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open) sqlConnection.Close();
            }
        }
    }
}
