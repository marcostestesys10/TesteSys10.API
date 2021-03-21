using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteSys10.Domain.Enums;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Models;
using TesteSys10.Infra.Data;

namespace TesteSys10.Infra.Repositories.Aluno
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly TesteSys10Context _context;
        public AlunoRepository(TesteSys10Context context) => _context = context;


        public AlunoModel Get(int id) => _context.Alunos.Where(p => p.IdAluno == id).FirstOrDefault();

        public IEnumerable<AlunoModel> GetAll() => _context.Alunos.ToList();

        public int Post(AlunoModel model)
        {
            _context.Alunos.Add(model);
            _context.SaveChanges();

            return model.IdAluno;
        }

        public bool Put(AlunoModel model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public bool Delete(AlunoModel model)
        {
            model.Status = StatusEnum.Inativo;
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public bool InsertNotaAluno(AlunoModel model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }
    }
}
