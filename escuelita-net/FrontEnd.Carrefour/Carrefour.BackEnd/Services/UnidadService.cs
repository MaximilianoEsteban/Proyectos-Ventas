using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class UnidadService
    {
        private readonly UnidadRepository unidadRepository;

        public UnidadService(UnidadRepository unidadRepository)
        {
            this.unidadRepository = unidadRepository;
        }

        public List<UnidadModel> Listar()
        {

            List<UnidadEntity> result = unidadRepository.Listar();
            var listarUnidadModel = new List<UnidadModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new UnidadModel();

                viewModelMap.Id = entity.Id;
                viewModelMap.Descripcion = entity.Descripcion;
                listarUnidadModel.Add(viewModelMap);

            }
            return listarUnidadModel;
        }


        public UnidadModel Obtener(int Id)
        {

            UnidadEntity result = unidadRepository.Obtener(Id);
            var viewModel = new UnidadModel();
            viewModel.Id = result.Id;
            viewModel.Descripcion = result.Descripcion;
            return viewModel;
        }

        public void Guardar(UnidadModel unidad)
        {
            var unidadModel = new UnidadEntity();
            unidadModel.Id = unidad.Id;
            unidadModel.Descripcion = unidad.Descripcion;
            unidadRepository.Guardar(unidadModel);
        }

        public void Editar(UnidadModel unidad)
        {
            var unidadModel = new UnidadEntity();
            unidadModel.Id = unidad.Id;
            unidadModel.Descripcion = unidad.Descripcion;
            unidadRepository.Editar(unidadModel);
        }

        public void Eliminar(int Id)
        {
            unidadRepository.Eliminar(Id);
        }
    }
}
