using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class PerfilRepository
    {
        private readonly SqlConnection sqlConnection;
        public PerfilRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<PerfilEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"SELECT IdPerfil,
                                        Nombre 
                                 FROM dbo.Perfil";
                var result = sqlConnection.Query<PerfilEntity>(query).ToList();

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

        public PerfilEntity Obtener(string IdPerfil)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Perfil WHERE IdPerfil = @IdPerfil";
                var result = sqlConnection.QueryFirstOrDefault<PerfilEntity>(query, new { IdPerfil = IdPerfil });

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

        public void Guardar(PerfilEntity perfil)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Perfil(Nombre) 
                                VALUES(@Nombre)";
                var result = sqlConnection.Execute(query, perfil);

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

        public void Eliminar(string IdPerfil)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Perfil WHERE IdPerfil = @IdPerfil";
                var result = sqlConnection.Execute(sentence, new { IdPerfil = IdPerfil });
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

        public void Editar(PerfilEntity perfil)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Perfil 
                                    SET Nombre = @Nombre                                        
                                WHERE IdPerfil = @IdPerfil";
                var result = sqlConnection.Execute(query, perfil);

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
