using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Aluno;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Service
{
    public interface IAlunoService
    {
        IEnumerable<AlunoModel> GetAll();
        AlunoModel Get(int id);
        int Post(InserirAlunoCommand command);
        bool Put(EditarAlunoCommand command);
        bool Delete(InativarAlunoCommand command);
        bool InsertNovaAluno(InsertNotaAlunoCommand command);
    }
}
