using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class LineaService
    {
        private readonly LineaRepository lineaRepository;

        public LineaService(LineaRepository lineaRepository)
        {
            this.lineaRepository = lineaRepository;
        }

        public List<LineaModel> Listar()
        {

            List<LineaEntity> result = lineaRepository.Listar();
            var listarLineaModel = new List<LineaModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new LineaModel();

                viewModelMap.Id = entity.Id;
                viewModelMap.Descripcion = entity.Descripcion;
                listarLineaModel.Add(viewModelMap);

            }
            return listarLineaModel;
        }


        public LineaModel Obtener(int Id)
        {

            LineaEntity result = lineaRepository.Obtener(Id);
            var viewModel = new LineaModel();
            viewModel.Id = result.Id;
            viewModel.Descripcion = result.Descripcion;
            return viewModel;
        }

        public void Guardar(LineaModel linea)
        {
            var lineaModel = new LineaEntity();
            lineaModel.Id = linea.Id;
            lineaModel.Descripcion = linea.Descripcion;
            lineaRepository.Guardar(lineaModel);
        }

        public void Editar(LineaModel linea)
        {
            var lineaModel = new LineaEntity();
            lineaModel.Id = linea.Id;
            lineaModel.Descripcion = linea.Descripcion;
            lineaRepository.Editar(lineaModel);
        }

        public void Eliminar(int lineaId)
        {
            lineaRepository.Eliminar(lineaId);
        }
    }
}
