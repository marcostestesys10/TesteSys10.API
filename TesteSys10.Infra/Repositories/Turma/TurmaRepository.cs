using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteSys10.Domain.Enums;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Models;
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
    }
}
