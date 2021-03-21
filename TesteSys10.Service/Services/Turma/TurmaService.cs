using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Turma;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Enums;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Interfaces.Service;
using TesteSys10.Domain.Models;
using TesteSys10.Domain.ViewModel;

namespace TesteSys10.Service.Services.Turma
{
    public class TurmaService : ITurmaService
    {
        private readonly ITurmaRepository _turmaRepository;
        public TurmaService(ITurmaRepository turmaRepository) => _turmaRepository = turmaRepository;


        public TurmaModel Get(int id) => _turmaRepository.Get(id);

        public IEnumerable<TurmaModel> GetAll() => _turmaRepository.GetAll();

        public int Post(InserirTurmaCommand command)
        {
            var model = new TurmaModel(command.NomeTurma);

            return _turmaRepository.Post(model);
        }

        public bool Put(EditarTurmaCommand command)
        {
            var model = new TurmaModel(command.IdTurma, command.NomeTurma);

            return _turmaRepository.Put(model);
        }
        public bool Delete(InativarTurmaCommand command)
        {
            var turma = new TurmaModel(command.IdTurma);
            return _turmaRepository.Delete(turma);
        }

        public IEnumerable<TurmaAlunoViewModel> GetRelatorioTurma(int idTurma) => _turmaRepository.GetRelatorioTurma(idTurma);

        public MediaTurmaAlunoViewModel GetMediaTumaAluno(int idTurma) => _turmaRepository.GetMediaTumaAluno(idTurma);
    }
}
