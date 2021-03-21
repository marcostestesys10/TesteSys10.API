using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Interfaces.Service;
using TesteSys10.Domain.Models;

namespace TesteSys10.Service.Services.Usuario
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;

        public UsuarioService(IUsuarioRepository usuarioRepository) => _usuarioRepository = usuarioRepository;


        public bool Delete(int id)
        {
            return _usuarioRepository.Delete(id);
        }

        public IEnumerable<UsuarioModel> GetAll()
        {
            return _usuarioRepository.GetAll();
        }

        public UsuarioModel Get(int id)
        {
            return _usuarioRepository.Get(id);
        }


        public int Post(InserirUsuarioCommand command)
        {
            var model = new UsuarioModel(command.FullName,
                                         command.Age, 
                                         command.BirthDate, 
                                         command.Document, 
                                         command.IdPerfil);

            return _usuarioRepository.Post(model);
        }

        public bool Put(EditarUsuarioCommand command)
        {
            var model = new UsuarioModel(command.Id,
                                         command.FullName,
                                         command.Age,
                                         command.BirthDate,
                                         command.Document,
                                         command.IdPerfil);

            return _usuarioRepository.Put(model);
        }
    }
}
