using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Models;
using Carrefour.BackEnd.Repository;
using System.Collections.Generic;

namespace Carrefour.BackEnd.Services
{
    public class PerfilService
    {
        private readonly PerfilRepository perfilRepository;

        public PerfilService(PerfilRepository perfilRepository)
        {
            this.perfilRepository = perfilRepository;
        }

        public List<PerfilModel> Listar()
        {

            List<PerfilEntity> result = perfilRepository.Listar();
            var listarPerfilModel = new List<PerfilModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new PerfilModel();

                viewModelMap.IdPerfil = entity.IdPerfil;
                viewModelMap.Nombre = entity.Nombre;
                listarPerfilModel.Add(viewModelMap);

            }
            return listarPerfilModel;
        }


        public PerfilModel Obtener(string IdPerfil)
        {

            PerfilEntity result = perfilRepository.Obtener(IdPerfil);
            var viewModel = new PerfilModel();
            viewModel.IdPerfil = result.IdPerfil;
            viewModel.Nombre = result.Nombre;
            return viewModel;
        }

        public void Guardar(PerfilModel perfil)
        {
            var perfilModel = new PerfilEntity();
            perfilModel.IdPerfil = perfil.IdPerfil;
            perfilModel.Nombre = perfil.Nombre;
            perfilRepository.Guardar(perfilModel);
        }

        public void Editar(PerfilModel perfil)
        {
            var perfilModel = new PerfilEntity();
            perfilModel.IdPerfil = perfil.IdPerfil;
            perfilModel.Nombre = perfil.Nombre;
            perfilRepository.Editar(perfilModel);
        }

        public void Eliminar(string IdPerfil)
        {
            perfilRepository.Eliminar(IdPerfil);
        }
    }
}
