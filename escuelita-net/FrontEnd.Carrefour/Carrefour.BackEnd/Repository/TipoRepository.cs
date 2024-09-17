using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using System;
using System.Linq;

namespace Carrefour.BackEnd.Repository
{
    public class TipoRepository
    {
        private readonly SqlConnection sqlConnection;
        public TipoRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<TipoQueryEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"SELECT t.Id, 
                                        t.nombre AS Nombre,
                                        t.sublineaId AS SublineaId,
                                        '' AS Separator,                                        
                                        s.nombre AS Nombre 
                                 FROM dbo.Tipo t
                                 INNER JOIN SubLinea s ON s.Id = t.sublineaId";

                var result = sqlConnection.Query<TipoEntity, SubLineaEntity, TipoQueryEntity>(query,
                    (tipo, sublinea) =>
                    {

                        var tipoQueryEntity = new TipoQueryEntity();
                        tipoQueryEntity.Tipo = tipo;
                        tipoQueryEntity.SubLinea = sublinea;

                        return tipoQueryEntity;
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


        public TipoEntity Obtener(int Id)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Tipo WHERE Id = @Id";
                var result = sqlConnection.QueryFirstOrDefault<TipoEntity>(query, new { Id = Id });

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


        public void Guardar(TipoEntity tipo)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Tipo(nombre, sublineaId) 
                                VALUES(@nombre, @sublineaId)";
                var result = sqlConnection.Execute(query, tipo);

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

        public void Eliminar(int Id)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Tipo WHERE Id = @Id";
                var result = sqlConnection.Execute(sentence, new { Id = Id });
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
        
        public void Editar(TipoEntity tipo)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Tipo 
                                    SET nombre = @nombre,
                                        sublineaId = @sublineaId 
                                WHERE id = @id";
                var result = sqlConnection.Execute(query, tipo);

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
