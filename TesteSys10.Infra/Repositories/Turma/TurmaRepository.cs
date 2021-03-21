using Canducci.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteSys10.Domain.Enums;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Models;
using TesteSys10.Domain.ViewModel;
using TesteSys10.Infra.Data;

namespace TesteSys10.Infra.Repositories.Turma
{
    public class TurmaRepository : ITurmaRepository
    {
        private readonly TesteSys10Context _context;
        public TurmaRepository(TesteSys10Context context) => _context = context;

        public TurmaModel Get(int id) => _context.Turmas.Where(p => p.IdTurma == id).FirstOrDefault();

        public IEnumerable<TurmaModel> GetAll() => _context.Turmas.ToList();

        public int Post(TurmaModel model)
        {
            _context.Turmas.Add(model);
            _context.SaveChanges();

            return model.IdTurma;
        }

        public bool Put(TurmaModel model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public bool Delete(TurmaModel model)
        {
            model.Status = StatusEnum.Inativo;
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<TurmaAlunoViewModel> GetRelatorioTurma(int idTurma)
        {
            int? page = 0;
            int pageSize = 10;

            var viewModel = _context.Turmas.Join(
                _context.Alunos,
                turma => turma.IdTurma,
                aluno => aluno.IdTurma,
                (turma, aluno) => new TurmaAlunoViewModel
                {
                    IdTurma = turma.IdTurma,
                    NomeTurma = turma.NomeTurma,
                    NomeAluno = aluno.FullName,
                    NotaAluno = aluno.NotaAluno
                }).
                AsNoTracking()
                .OrderBy(c => c.IdTurma)
                .Skip((page ?? 0) * pageSize)
                    .Take(pageSize)
                    .Where(c => c.IdTurma == idTurma)
                    .ToList();

            return viewModel;
        }

        public MediaTurmaAlunoViewModel GetMediaTumaAluno(int idTurma)
        {
            decimal mediaNotaAluno = (from notaAluno in _context.Alunos
                                        where notaAluno.IdTurma == idTurma
                                        select notaAluno.NotaAluno)
                                        .Average();


            var viewModel = _context.Turmas.Join(
                _context.Alunos,
                turma => turma.IdTurma,
                aluno => aluno.IdTurma,
                (turma, aluno) => new MediaTurmaAlunoViewModel
                {
                    IdTurma = turma.IdTurma,
                    NomeTurma = turma.NomeTurma,
                    MediaTurma = mediaNotaAluno
                }).Where(c => c.IdTurma == idTurma).FirstOrDefault();

            return viewModel;
        }
    }
}
