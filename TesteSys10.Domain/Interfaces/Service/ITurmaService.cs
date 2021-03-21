using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Turma;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Service
{
    public interface ITurmaService
    {
        IEnumerable<TurmaModel> GetAll();
        TurmaModel Get(int id);
        int Post(InserirTurmaCommand command);
        bool Put(EditarTurmaCommand command);
        bool Delete(InativarTurmaCommand command);
    }
}
