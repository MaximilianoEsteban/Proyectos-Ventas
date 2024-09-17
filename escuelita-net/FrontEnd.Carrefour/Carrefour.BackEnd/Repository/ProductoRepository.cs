using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Carrefour.BackEnd.Repository
{
    public class ProductoRepository
    {
        private readonly SqlConnection sqlConnection;
        public ProductoRepository(SqlConnection connection)
        {
            this.sqlConnection = connection;
        }

        public List<ProductoQueryEntity> Listar()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"SELECT p.Id,
                                       p.Nombre,
                                       p.marcaId as MarcaId,
                                       p.tipoId as TipoId,
                                       p.Precio,
                                       p.Stock,
                                       p.UnidadId,
									   '' AS Separator,
                                       m.NombreMarca,
									   '' AS Separator,
                                       t.Nombre AS Nombre,
									   '' AS Separator,
                                       u.Descripcion
                                FROM dbo.Producto p
                                INNER JOIN Marca m ON m.Id = p.marcaId
                                INNER JOIN Tipo t ON t.Id = p.tipoId
                                INNER JOIN Unidad u ON u.Id = p.unidadId";

                var result = sqlConnection.Query<ProductoEntity, MarcaEntity, TipoEntity, UnidadEntity, ProductoQueryEntity>(query,
                    (producto, marca, tipo, unidad) =>
                            {

                                var productoQueryEntity = new ProductoQueryEntity();
                                productoQueryEntity.Producto = producto;
                                productoQueryEntity.Marca = marca;
                                productoQueryEntity.Tipo = tipo;
                                productoQueryEntity.Unidad = unidad;

                                return productoQueryEntity;
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


        public ProductoEntity Obtener(int productoId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = "SELECT * FROM dbo.Producto WHERE Id = @productoId";
                var result = sqlConnection.QueryFirstOrDefault<ProductoEntity>(query, new { productoId = productoId });

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


        public void Guardar(ProductoEntity producto)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"INSERT INTO dbo.Producto(nombre, marcaId, precio, stock, tipoId, unidadId) 
                                VALUES(@nombre, @marcaId, @precio, @stock, @tipoId, @unidadId)";
                var result = sqlConnection.Execute(query, producto);

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

        public void Eliminar(int productoId)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string sentence = "DELETE FROM dbo.Producto WHERE Id = @productoId";
                var result = sqlConnection.Execute(sentence, new { productoId = productoId });
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

        public void Editar(ProductoEntity producto)
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) sqlConnection.Open();

            try
            {
                string query = @"UPDATE dbo.Producto 
                                    SET nombre = @nombre, 
                                        marcaId = @marcaId, 
                                        precio = @precio, 
                                        stock = @stock, 
                                        tipoId = @tipoId, 
                                        unidadId = @unidadId 
                                WHERE id = @id";
                var result = sqlConnection.Execute(query, producto);

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
