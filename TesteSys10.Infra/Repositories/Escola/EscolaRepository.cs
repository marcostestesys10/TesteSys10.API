using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Models;
using TesteSys10.Infra.Data;

namespace TesteSys10.Infra.Repositories.Escola
{
    public class EscolaRepository : IEscolaRepository
    {
        private readonly TesteSys10Context _context;
        public EscolaRepository(TesteSys10Context context) => _context = context;


        public bool Delete(EscolaModel model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public IEnumerable<EscolaModel> GetAll()
        {
            return _context.Escola.ToList();
        }
    }
}
