using Carrefour.BackEnd.Entity;
using Carrefour.BackEnd.Repository;
using System.Collections.Generic;
using System;
using Carrefour.BackEnd.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Carrefour.BackEnd.Services
{
    public class UsuarioService
    {
        private readonly UsuarioRepository usuarioRepository;
        private readonly PerfilRepository perfilRepository;

        public UsuarioService(UsuarioRepository usuarioRepository, PerfilRepository perfilRepository)
        {
            this.usuarioRepository = usuarioRepository;
            this.perfilRepository = perfilRepository;
        }

        public List<UsuarioModel> Listar()
        {

            List<UsuarioQueryEntity> result = usuarioRepository.Listar();
            var listarUsuarioModel = new List<UsuarioModel>();

            foreach (var entity in result)
            {
                var viewModelMap = new UsuarioModel();

                viewModelMap.IdUsuario = entity.Usuario.IdUsuario;
                viewModelMap.Nombre = entity.Usuario.Nombre;
                viewModelMap.Apellido = entity.Usuario.Apellido;
                viewModelMap.Email = entity.Usuario.Email;
                viewModelMap.Password = entity.Usuario.Password;
                viewModelMap.IdPerfil = entity.Perfil.IdPerfil;
                viewModelMap.NombrePerfil = entity.Perfil.Nombre;
                viewModelMap.FechaCreacion= entity.Usuario.FechaCreacion;
                viewModelMap.FechaPassword = entity.Usuario.FechaPassword;                
                listarUsuarioModel.Add(viewModelMap);

            }
            return listarUsuarioModel;
        }


        public UsuarioModel Obtener(string IdUsuario)
        {

            UsuarioEntity result = usuarioRepository.Obtener(IdUsuario);            

            var viewModel = new UsuarioModel();

            if (result == null)
            {
                return null;                
            }            

            viewModel.IdUsuario = result.IdUsuario;
            viewModel.Nombre = result.Nombre;
            viewModel.Apellido = result.Apellido;
            viewModel.Email = result.Email;
            viewModel.Password = result.Password;
            viewModel.IdPerfil = result.IdPerfil;
            viewModel.NombrePerfil = result.NombrePerfil;
            viewModel.FechaCreacion = result.FechaCreacion;
            viewModel.FechaPassword = result.FechaPassword;
            return viewModel;
        }

        public void Guardar(UsuarioModel usuario)
        {
            var usuarioModel1 = new UsuarioModel();
            var usuarioModel = new UsuarioEntity();
            usuarioModel.IdUsuario = usuario.IdUsuario;
            usuarioModel.Nombre = usuario.Nombre;
            usuarioModel.Apellido = usuario.Apellido;
            usuarioModel.Email = usuario.Email;
            usuarioModel.Password = usuario.Password;
            usuarioModel1.Password1 = usuario.Password1;
            usuarioModel.IdPerfil = "1";
            var fechaAlta = DateTime.Now;
            usuarioModel.FechaCreacion = fechaAlta;
            fechaAlta = usuario.FechaCreacion;
            var fechaPass = DateTime.Now;
            usuarioModel.FechaPassword = fechaPass;
            fechaPass = usuario.FechaPassword;
                        
            if (usuarioModel.Password == usuarioModel1.Password1)
            {
                usuarioRepository.Guardar(usuarioModel);
            }

            else
            {
                throw new Exception("La confirmacion de la contraseña no coincide con la ingresada anteriormente");
            }
        }



        public void Editar(UsuarioModel usuario)
        {            
            var usuarioModel = new UsuarioEntity();
            usuarioModel.IdUsuario = usuario.IdUsuario;
            usuarioModel.Nombre = usuario.Nombre;
            usuarioModel.Apellido = usuario.Apellido;
            usuarioModel.Email = usuario.Email;
            usuarioModel.Password = usuario.Password;
            usuarioModel.IdPerfil = usuario.IdPerfil;           
            usuarioRepository.Editar(usuarioModel);
        }

        public void EditarPassword(UsuarioModel usuario)
        {
            var usuarioModel = new UsuarioEntity();
            usuarioModel.IdUsuario = usuario.IdUsuario;            
            usuarioModel.Password = usuario.Password;            
            usuarioRepository.EditarPassword(usuarioModel);
        }

        public void ResetPassword(UsuarioModel usuario)
        {
            var usuarioModel1 = new UsuarioModel();
            var usuarioModel = new UsuarioEntity();
            usuarioModel.IdUsuario = usuario.IdUsuario;
            usuarioModel.Password = usuario.Password;
            usuarioModel1.Password1 = usuario.Password1;
            
            if (usuarioModel.Password == usuarioModel1.Password1)
            {    
                usuarioRepository.ResetPassword(usuarioModel);
            }

            else
            {
                throw new Exception("La confirmacion de la contraseña no coincide con la ingresada anteriormente");
            }
        }

        public void Eliminar(string IdUsuario)
        {
            usuarioRepository.Eliminar(IdUsuario);
        }
    }
}
