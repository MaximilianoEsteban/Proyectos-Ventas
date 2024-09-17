using Carrefour.BackEnd.Entity;
using System.Collections.Generic;
using System.Data.SqlClient;
using System;
using Dapper;
using System.Linq;
using System.Reflection;

namespace Carrefour.BackEnd.Repository
{
    public class SubLineaRepository
    {
        private readonly SqlConnection sqlConnection;
        public SubLineaRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<SubLineaQueryEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"SELECT s.Id,
                                        s.nombre AS Nombre,
                                        s.lineaId AS LineaId,                                       
									   '' AS Separator,
                                        l.descripcion AS Descripcion									   
                                FROM dbo.SubLinea s
                                INNER JOIN Linea l ON l.Id = s.lineaId";

                var result = sqlConnection.Query<SubLineaEntity, LineaEntity, SubLineaQueryEntity >(query,
                    (subLinea, linea) =>
                    {

                        var subLineaQueryEntity = new SubLineaQueryEntity();
                        subLineaQueryEntity.SubLinea = subLinea;
                        subLineaQueryEntity.Linea = linea;                        

                        return subLineaQueryEntity;
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


        public SubLineaEntity Obtener(int subLineaId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.SubLinea WHERE Id = @subLineaId";
                var result = sqlConnection.QueryFirstOrDefault<SubLineaEntity>(query, new { subLineaId = subLineaId });

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


        public void Guardar(SubLineaEntity sublinea)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.SubLinea(nombre, lineaId) 
                                VALUES(@nombre, @lineaId)";
                var result = sqlConnection.Execute(query, sublinea);

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

        public void Eliminar(int subLineaId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.SubLinea WHERE Id = @subLineaId";
                var result = sqlConnection.Execute(sentence, new { subLineaId = subLineaId });
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

        public void Editar(SubLineaEntity sublinea)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.SubLinea 
                                    SET nombre = @nombre, 
                                        lineaId = @lineaId 
                                WHERE id = @id";
                var result = sqlConnection.Execute(query, sublinea);

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
