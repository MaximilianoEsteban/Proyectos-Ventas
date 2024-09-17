using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class FormaPagoService
    {
        private readonly FormaPagoRepository formaPagoRepository;

        public FormaPagoService(FormaPagoRepository formaPagoRepository)
        {
            this.formaPagoRepository = formaPagoRepository;
        }

        public List<FormaPagoModel> Listar()
        {

            List<FormaPagoEntity> result = formaPagoRepository.Listar();
            var listarFormaPagoModel = new List<FormaPagoModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new FormaPagoModel();

                viewModelMap.IdFormaPago = entity.IdFormaPago;
                viewModelMap.FormaPago = entity.FormaPago;
                listarFormaPagoModel.Add(viewModelMap);
            }
            return listarFormaPagoModel;
        }

        public FormaPagoModel Obtener(int IdFormaPago)
        {
            FormaPagoEntity result = formaPagoRepository.Obtener(IdFormaPago);
            var viewModel = new FormaPagoModel();
            viewModel.IdFormaPago = result.IdFormaPago;
            viewModel.FormaPago = result.FormaPago;
            return viewModel;
        }

        public void Guardar(FormaPagoModel formaPago)
        {
            var formaPagoModel = new FormaPagoEntity();
            formaPagoModel.IdFormaPago = formaPago.IdFormaPago;
            formaPagoModel.FormaPago = formaPago.FormaPago;
            formaPagoRepository.Guardar(formaPagoModel);
        }

        public void Editar(FormaPagoModel formaPago)
        {
            var formaPagoModel = new FormaPagoEntity();
            formaPagoModel.IdFormaPago = formaPago.IdFormaPago;
            formaPagoModel.FormaPago = formaPago.FormaPago;
            formaPagoRepository.Editar(formaPagoModel);
        }

        public void Eliminar(int IdFormaPago)
        {
            formaPagoRepository.Eliminar(IdFormaPago);
        }
    }
}
