using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Service
{
    public interface IUsuarioService
    {
        IEnumerable<UsuarioModel> GetAll();
        UsuarioModel Get(int id);
        int Post(InserirUsuarioCommand command);
        bool Put(EditarUsuarioCommand command);
        bool Delete(int id);
    }
}
