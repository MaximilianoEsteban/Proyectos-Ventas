using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class UnidadRepository
    {
        private readonly SqlConnection sqlConnection;
        public UnidadRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<UnidadEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Unidad";
                var result = sqlConnection.Query<UnidadEntity>(query).ToList();

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


        public UnidadEntity Obtener(int unidadId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Unidad WHERE Id = @unidadId";
                var result = sqlConnection.QueryFirstOrDefault<UnidadEntity>(query, new { unidadId = unidadId });

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


        public void Guardar(UnidadEntity unidad)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Unidad(descripcion) 
                                VALUES(@descripcion)";
                var result = sqlConnection.Execute(query, unidad);

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

        public void Eliminar(int unidadId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Unidad WHERE Id = @unidadId";
                var result = sqlConnection.Execute(sentence, new { unidadId = unidadId });
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

        public void Editar(UnidadEntity unidad)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Unidad 
                                    SET descripcion = @descripcion                                         
                                WHERE id = @id";
                var result = sqlConnection.Execute(query, unidad);

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
