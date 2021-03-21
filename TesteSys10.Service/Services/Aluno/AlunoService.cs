using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Aluno;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Interfaces.Service;
using TesteSys10.Domain.Models;

namespace TesteSys10.Service.Services.Aluno
{
    public class AlunoService : IAlunoService
    {
        private readonly IAlunoRepository _alunoRepository;
        public AlunoService(IAlunoRepository alunoRepository) => _alunoRepository = alunoRepository;


        public AlunoModel Get(int id) => _alunoRepository.Get(id);

        public IEnumerable<AlunoModel> GetAll() => _alunoRepository.GetAll();

        public int Post(InserirAlunoCommand command)
        {
            var model = new AlunoModel(command.FullName, command.IdUsuario, command.IdTurma);

            return _alunoRepository.Post(model);
        }

        public bool Put(EditarAlunoCommand command)
        {
            var model = new AlunoModel(command.IdAluno, command.FullName, command.IdUsuario, command.IdTurma);

            return _alunoRepository.Put(model);
        }

        public bool Delete(InativarAlunoCommand command)
        {
            var escola = new AlunoModel(command.IdAluno);

            return _alunoRepository.Delete(escola);
        }

        public bool InsertNovaAluno(InsertNotaAlunoCommand command)
        {
            var model = new AlunoModel(command.IdAluno, command.IdTurma, command.NotaAluno);

            return _alunoRepository.InsertNotaAluno(model);
        }
    }
}
