using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Infra
{
    public interface IUsuarioRepository
    {
        IEnumerable<UsuarioModel> GetAll();
        UsuarioModel Get(int id);
        int Post(UsuarioModel model);
        bool Put(UsuarioModel model);
        bool Delete(int id);
    }
}
