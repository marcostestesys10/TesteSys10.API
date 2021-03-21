using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;
using TesteSys10.Domain.ViewModel;

namespace TesteSys10.Domain.Interfaces.Infra
{
    public interface ITurmaRepository
    {
        IEnumerable<TurmaModel> GetAll();
        TurmaModel Get(int id);
        int Post(TurmaModel model);
        bool Put(TurmaModel model);
        bool Delete(TurmaModel model);
        IEnumerable<TurmaAlunoViewModel> GetRelatorioTurma(int idTurma);
        MediaTurmaAlunoViewModel GetMediaTumaAluno(int idTurma);
    }
}
