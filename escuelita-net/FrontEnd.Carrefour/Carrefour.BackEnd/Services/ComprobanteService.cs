using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class ComprobanteService
    {
        private readonly ComprobanteRepository comprobanteRepository;

        public ComprobanteService(ComprobanteRepository comprobanteRepository)
        {
            this.comprobanteRepository = comprobanteRepository;
        }

        public List<ComprobanteModel> Listar()
        {

            List<ComprobanteEntity> result = comprobanteRepository.Listar();
            var listarComprobanteModel = new List<ComprobanteModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new ComprobanteModel();

                viewModelMap.IdComprobante = entity.IdComprobante;
                viewModelMap.Comprobante = entity.Comprobante;
                listarComprobanteModel.Add(viewModelMap);

            }
            return listarComprobanteModel;
        }

        public ComprobanteModel Obtener(int IdComprobante)
        {
            ComprobanteEntity result = comprobanteRepository.Obtener(IdComprobante);
            var viewModel = new ComprobanteModel();
            viewModel.IdComprobante = result.IdComprobante;
            viewModel.Comprobante = result.Comprobante;
            return viewModel;
        }

        public void Guardar(ComprobanteModel comprobante)
        {
            var comprobanteModel = new ComprobanteEntity();
            comprobanteModel.IdComprobante = comprobante.IdComprobante;
            comprobanteModel.Comprobante = comprobante.Comprobante;
            comprobanteRepository.Guardar(comprobanteModel);
        }

        public void Editar(ComprobanteModel comprobante)
        {
            var comprobanteModel = new ComprobanteEntity();
            comprobanteModel.IdComprobante = comprobante.IdComprobante;
            comprobanteModel.Comprobante = comprobante.Comprobante;
            comprobanteRepository.Editar(comprobanteModel);
        }

        public void Eliminar(int IdComprobante)
        {
            comprobanteRepository.Eliminar(IdComprobante);
        }
    }
}
