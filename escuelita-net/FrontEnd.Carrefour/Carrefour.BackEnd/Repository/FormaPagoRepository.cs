using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class FormaPagoRepository
    {
        private readonly SqlConnection sqlConnection;
        public FormaPagoRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<FormaPagoEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.FormaPago";
                var result = sqlConnection.Query<FormaPagoEntity>(query).ToList();

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


        public FormaPagoEntity Obtener(int IdFormaPago)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.FormaPago WHERE IdFormaPago = @IdFormaPago";
                var result = sqlConnection.QueryFirstOrDefault<FormaPagoEntity>(query, new { IdFormaPago = IdFormaPago });

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


        public void Guardar(FormaPagoEntity formaPago)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.FormaPago(FormaPago) 
                                VALUES(@formaPago)";
                var result = sqlConnection.Execute(query, formaPago);

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

        public void Eliminar(int IdFormaPago)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.FormaPago WHERE IdFormaPago = @IdFormaPago";
                var result = sqlConnection.Execute(sentence, new { IdFormaPago = IdFormaPago });
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

        public void Editar(FormaPagoEntity formaPago)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.FormaPago 
                                    SET FormaPago = @formaPago                                         
                                WHERE IdFormaPago = @idFormaPago";
                var result = sqlConnection.Execute(query, formaPago);

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
