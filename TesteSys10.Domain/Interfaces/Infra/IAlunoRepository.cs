using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Infra
{
    public interface IAlunoRepository
    {
        IEnumerable<AlunoModel> GetAll();
        AlunoModel Get(int id);
        int Post(AlunoModel model);
        bool Put(AlunoModel model);
        bool Delete (AlunoModel model);
        bool InsertNotaAluno (AlunoModel model);
    }
}
