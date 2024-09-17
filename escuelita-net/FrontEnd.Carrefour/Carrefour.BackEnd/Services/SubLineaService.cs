using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class SubLineaService
    {
        private readonly SubLineaRepository subLineaRepository;
        private readonly LineaRepository lineaRepository;

        public SubLineaService(SubLineaRepository subLineaRepository, LineaRepository lineaRepository)
        {
            this.subLineaRepository = subLineaRepository;
            this.lineaRepository = lineaRepository;
        }

        public List<SubLineaModel> Listar()
        {

            List<SubLineaQueryEntity> result = subLineaRepository.Listar();
            var listarSubLineaModel = new List<SubLineaModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new SubLineaModel();

                viewModelMap.Id = entity.SubLinea.Id;
                viewModelMap.Nombre = entity.SubLinea.Nombre;
                viewModelMap.LineaId = entity.Linea.Id;
                viewModelMap.DescripcionLinea = entity.Linea.Descripcion;                
                listarSubLineaModel.Add(viewModelMap);

            }
            return listarSubLineaModel;
        }


        public SubLineaModel Obtener(int Id)
        {

            SubLineaEntity result = subLineaRepository.Obtener(Id);
            var viewModel = new SubLineaModel();
            viewModel.Id = result.Id;
            viewModel.LineaId = result.LineaId;
            viewModel.Nombre = result.Nombre;
            return viewModel;
        }

        public void Guardar(SubLineaModel sublinea)
        {
            ValidarSublinea(sublinea);
            var sublineaModel = new SubLineaEntity();
            sublineaModel.Id = sublinea.Id;
            sublineaModel.LineaId = sublinea.LineaId;
            sublineaModel.Nombre = sublinea.Nombre;
            subLineaRepository.Guardar(sublineaModel);
        }

       
              
        public void Editar(SubLineaModel sublinea)
        {
            ValidarSublinea(sublinea);
            var sublineaModel = new SubLineaEntity();
            sublineaModel.Id = sublinea.Id;
            sublineaModel.LineaId = sublinea.LineaId;
            sublineaModel.Nombre = sublinea.Nombre;
            subLineaRepository.Editar(sublineaModel);
        }

        private void ValidarSublinea(SubLineaModel subLinea)
        {
            var lineaExistente = this.lineaRepository.Obtener(subLinea.LineaId);
            if(lineaExistente == null)
            {
                throw new Exception("La linea indicada no existe en BD");
            }
        }

        public void Eliminar(int Id)
        {
            subLineaRepository.Eliminar(Id);
        }
    }
}
