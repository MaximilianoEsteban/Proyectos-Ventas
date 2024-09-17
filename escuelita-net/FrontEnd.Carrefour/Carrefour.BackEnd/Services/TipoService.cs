using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class TipoService
    {
        private readonly TipoRepository tipoRepository;
        private readonly SubLineaRepository subLineaRepository;

        public TipoService(TipoRepository tipoRepository, SubLineaRepository subLineaRepository)
        {
            this.tipoRepository = tipoRepository;
            this.subLineaRepository = subLineaRepository;
        }

        public List<TipoModel> Listar()
        {

            List<TipoQueryEntity> result = tipoRepository.Listar();
            var listarTipoModel = new List<TipoModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new TipoModel();
                viewModelMap.Id = entity.Tipo.Id;
                viewModelMap.Nombre = entity.Tipo.Nombre;
                viewModelMap.SubLineaId = entity.SubLinea.Id;
                viewModelMap.NombreSublinea = entity.SubLinea.Nombre;
                listarTipoModel.Add(viewModelMap);
            }
            return listarTipoModel;
        }


        public TipoModel Obtener(int Id)
        {

            TipoEntity result = tipoRepository.Obtener(Id);
            var viewModel = new TipoModel();
            viewModel.Id = result.Id;
            viewModel.SubLineaId = result.SubLineaId;
            viewModel.Nombre = result.Nombre;
            return viewModel;
        }

        public void Guardar(TipoModel tipo)
        {
            ValidarSublinea(tipo);
            var tipoModel = new TipoEntity();
            tipoModel.Id = tipo.Id;
            tipoModel.SubLineaId = tipo.SubLineaId;
            tipoModel.Nombre = tipo.Nombre;
            tipoRepository.Guardar(tipoModel);
        }

        public void Editar(TipoModel tipo)
        {
            ValidarSublinea(tipo);
            var tipoModel = new TipoEntity();
            tipoModel.Id = tipo.Id;
            tipoModel.SubLineaId = tipo.SubLineaId;
            tipoModel.Nombre = tipo.Nombre;
            tipoRepository.Editar(tipoModel);
        }

        private void ValidarSublinea(TipoModel tipo)
        {
            var sublineaExistente = this.subLineaRepository.Obtener(tipo.SubLineaId);
            if (sublineaExistente == null)
            {
                throw new Exception("La sublinea indicada no existe en BD");
            }
        }

        public void Eliminar(int Id)
        {
            tipoRepository.Eliminar(Id);
        }
    }
}
