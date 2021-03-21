using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Aluno;
using TesteSys10.Domain.Commands.Escola;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Service
{
    public interface IEscolaService
    {
        IEnumerable<EscolaModel> GetAll();
        bool Delete(InativarEscolaCommand command);
    }
}
