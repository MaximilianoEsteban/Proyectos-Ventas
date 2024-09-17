using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Entity;

namespace Carrefour.BackEnd.Repository
{
    public class MarcaRepository
    {
        private readonly SqlConnection sqlConnection;
        public MarcaRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<MarcaEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Marca";
                var result = sqlConnection.Query<MarcaEntity>(query).ToList();

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

       
        public MarcaEntity Obtener(int marcaId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Marca WHERE Id = @marcaId";
                var result = sqlConnection.QueryFirstOrDefault<MarcaEntity>(query, new { marcaId = marcaId });

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


        public void Guardar(MarcaEntity marca)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Marca(nombreMarca) 
                                VALUES(@nombreMarca)";
                var result = sqlConnection.Execute(query, marca);

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

        public void Eliminar(int marcaId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Marca WHERE Id = @marcaId";
                var result = sqlConnection.Execute(sentence, new { marcaId = marcaId });
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

        public void Editar(MarcaEntity marca)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Marca 
                                    SET nombreMarca = @nombreMarca                                        
                                WHERE id = @id";
                var result = sqlConnection.Execute(query, marca);

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
