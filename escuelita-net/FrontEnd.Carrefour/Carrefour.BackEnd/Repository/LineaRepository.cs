using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class LineaRepository
    {
        private readonly SqlConnection sqlConnection;
        public LineaRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<LineaEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Linea";
                var result = sqlConnection.Query<LineaEntity>(query).ToList();

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


        public LineaEntity Obtener(int lineaId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Linea WHERE Id = @lineaId";
                var result = sqlConnection.QueryFirstOrDefault<LineaEntity>(query, new { lineaId = lineaId });

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


        public void Guardar(LineaEntity linea)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Linea(descripcion) 
                                VALUES(@descripcion)";
                var result = sqlConnection.Execute(query, linea);

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

        public void Eliminar(int lineaId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Linea WHERE Id = @lineaId";
                var result = sqlConnection.Execute(sentence, new { lineaId = lineaId });
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

        public void Editar(LineaEntity linea)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Linea 
                                    SET descripcion = @descripcion                                         
                                WHERE id = @id";
                var result = sqlConnection.Execute(query, linea);

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
