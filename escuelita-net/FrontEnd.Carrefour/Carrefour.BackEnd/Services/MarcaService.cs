using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class MarcaService
    {
        private readonly MarcaRepository marcaRepository;

        public MarcaService(MarcaRepository marcaRepository)
        {
            this.marcaRepository = marcaRepository;
        }

        public List<MarcaModel> Listar()
        {

            List<MarcaEntity> result = marcaRepository.Listar();
            var listarMarcaModel = new List<MarcaModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new MarcaModel();

                viewModelMap.Id = entity.Id;
                viewModelMap.NombreMarca = entity.NombreMarca;
                listarMarcaModel.Add(viewModelMap);

            }
            return listarMarcaModel;
        }
                

        public MarcaModel Obtener(int Id)
        {

            MarcaEntity result = marcaRepository.Obtener(Id);
            var viewModel = new MarcaModel();
            viewModel.Id = result.Id;
            viewModel.NombreMarca = result.NombreMarca;
            return viewModel;
        }

        public void Guardar(MarcaModel marca)
        {
            var marcaModel = new MarcaEntity();
            marcaModel.Id = marca.Id;
            marcaModel.NombreMarca = marca.NombreMarca;
            marcaRepository.Guardar(marcaModel);
        }

        public void Editar(MarcaModel marca)
        {
            var marcaModel = new MarcaEntity();
            marcaModel.Id = marca.Id;
            marcaModel.NombreMarca = marca.NombreMarca;
            marcaRepository.Editar(marcaModel);
        }

        public void Eliminar(int marcaId)
        {
            marcaRepository.Eliminar(marcaId);
        }
                
    }
}
