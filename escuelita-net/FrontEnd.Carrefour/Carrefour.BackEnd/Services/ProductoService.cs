using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class ProductoService
    {
        private readonly ProductoRepository productoRepository;
        private readonly MarcaRepository marcaRepository;
        private readonly TipoRepository tipoRepository;

        public ProductoService(ProductoRepository productoRepository, MarcaRepository marcaRepository, TipoRepository tipoRepository)
        {
            this.productoRepository = productoRepository;
            this.marcaRepository = marcaRepository;
            this.tipoRepository = tipoRepository;
        }

        public List<ProductoModel> Listar()
        {

            List<ProductoQueryEntity> result = productoRepository.Listar();
            var listarProductoModel = new List<ProductoModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new ProductoModel();

                viewModelMap.Id = entity.Producto.Id;
                viewModelMap.Nombre = entity.Producto.Nombre;
                viewModelMap.MarcaId = entity.Producto.MarcaId;
                viewModelMap.NombreMarca = entity.Marca.NombreMarca;
                viewModelMap.TipoId = entity.Tipo.Id;
                viewModelMap.NombreTipo = entity.Tipo.Nombre;
                viewModelMap.Precio = entity.Producto.Precio;
                viewModelMap.Stock = entity.Producto.Stock;
                viewModelMap.UnidadId = entity.Unidad.Id;
                viewModelMap.Descripcion = entity.Unidad.Descripcion;
                listarProductoModel.Add(viewModelMap);

            }
            return listarProductoModel;
        }


        public ProductoModel Obtener(int Id)
        {

            ProductoEntity result = productoRepository.Obtener(Id);
            var viewModel = new ProductoModel();
            viewModel.Id = result.Id;
            viewModel.Nombre = result.Nombre;
            viewModel.MarcaId = result.MarcaId;            
            viewModel.TipoId = result.TipoId;
            viewModel.Precio = result.Precio;
            viewModel.Stock = result.Stock;
            viewModel.UnidadId = result.UnidadId;
            return viewModel;
        }

        public void Guardar(ProductoModel producto)
        {
            ValidarMarca(producto);
            ValidarTipo(producto);
            var productoModel = new ProductoEntity();
            productoModel.Id = producto.Id;
            productoModel.Nombre = producto.Nombre;
            productoModel.MarcaId = producto.MarcaId;
            productoModel.TipoId = producto.TipoId;
            productoModel.Precio = producto.Precio;
            productoModel.Stock = producto.Stock;
            productoModel.UnidadId = producto.UnidadId;
            productoRepository.Guardar(productoModel);
        }

        public void Editar(ProductoModel producto)
        {
            ValidarMarca(producto);
            ValidarTipo(producto);
            var productoModel = new ProductoEntity();
            productoModel.Id = producto.Id;
            productoModel.Nombre = producto.Nombre;
            productoModel.MarcaId = producto.MarcaId;
            productoModel.TipoId = producto.TipoId;
            productoModel.Precio = producto.Precio;
            productoModel.Stock = producto.Stock;
            productoModel.UnidadId = producto.UnidadId;
            productoRepository.Editar(productoModel);
        }

        private void ValidarMarca(ProductoModel producto)
        {
            var marcaExistente = this.marcaRepository.Obtener((int)producto.MarcaId);
            if (marcaExistente == null)
            {
                throw new Exception("La marca indicada no existe en BD");
            }
        }

        private void ValidarTipo(ProductoModel producto)
        {
            var tipoExistente = this.tipoRepository.Obtener((int)producto.TipoId);
            if (tipoExistente == null)
            {
                throw new Exception("El tipo indicada no existe en BD");
            }
        }

        public void Eliminar(int productoId)
        {            
            productoRepository.Eliminar(productoId);
        }
        
    }
}
