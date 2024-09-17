using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class UsuarioRepository
    {
        private readonly SqlConnection sqlConnection;
        public UsuarioRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }   

        public List<UsuarioQueryEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"SELECT u.IdUsuario,
                                        u.Nombre,
                                        u.Apellido,
                                        u.Email,
                                        u.Password,
                                        u.IdPerfil,
                                        u.FechaCreacion,
                                        u.FechaPassword,
									    '' AS Separator,
                                        p.IdPerfil,
                                        p.Nombre  									   
                                FROM dbo.Usuario u
                                INNER JOIN Perfil p ON p.IdPerfil = u.IdPerfil";

                var result = sqlConnection.Query<UsuarioEntity, PerfilEntity, UsuarioQueryEntity>(query,
                    (usuario, perfil) =>
                    {

                        var usuarioQueryEntity = new UsuarioQueryEntity();
                        usuarioQueryEntity.Usuario = usuario;                        
                        usuarioQueryEntity.Perfil = perfil;                        

                        return usuarioQueryEntity;
                    }
                    , splitOn: "Separator").ToList();

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


        public UsuarioEntity Obtener(string IdUsuario)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"SELECT u.IdUsuario,
                                        u.Nombre,
                                        u.Apellido,
                                        u.Email,
                                        u.Password,
                                        u.IdPerfil,
                                        u.FechaCreacion,
                                        u.FechaPassword,
									    '' AS Separator,
                                        p.IdPerfil,
                                        p.Nombre AS NombrePerfil									   
                                FROM dbo.Usuario u
                                INNER JOIN Perfil p ON p.IdPerfil = u.IdPerfil
                                WHERE IdUsuario = @IdUsuario";
                var result = sqlConnection.QueryFirstOrDefault<UsuarioEntity>(query, new { IdUsuario = IdUsuario });

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


        public void Guardar(UsuarioEntity usuario)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Usuario(IdUsuario, Nombre, Apellido, Email, Password, IdPerfil, FechaCreacion, FechaPassword) 
                                VALUES(@idUsuario, @nombre, @apellido, @email, @password, @idPerfil, @fechaCreacion, @fechaPassword)";
                var result = sqlConnection.Execute(query, usuario);

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

        public void Eliminar(string IdUsuario)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Usuario WHERE IdUsuario = @IdUsuario";
                var result = sqlConnection.Execute(sentence, new { IdUsuario = IdUsuario });
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

        public void Editar(UsuarioEntity usuario)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Usuario 
                                    SET Nombre = @nombre,                                        
                                        Apellido = @apellido, 
                                        Email = @email, 
                                        Password = @password,
                                        IdPerfil = @idPerfil,
                                        FechaCreacion = @fechaCreacion,
                                        FechaPassword = @fechaPassword 
                                WHERE IdUsuario = @idUsuario";
                var result = sqlConnection.Execute(query, usuario);

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

        public void EditarPassword(UsuarioEntity usuario)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Usuario 
                                    SET Password = @Password                                        
                                WHERE IdUsuario = @IdUsuario";
                var result = sqlConnection.Execute(query, usuario);

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

        public void ResetPassword(UsuarioEntity usuario)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Usuario 
                                    SET Password = @Password                                        
                                WHERE IdUsuario = @IdUsuario";
                var result = sqlConnection.Execute(query, usuario);

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
