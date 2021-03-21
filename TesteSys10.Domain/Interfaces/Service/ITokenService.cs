using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Service
{
    public interface ITokenService
    {
        string GetToken(int id, int idPerfil);
    }
}
