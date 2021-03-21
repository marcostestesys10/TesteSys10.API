using Canducci.Pagination;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Models;
using TesteSys10.Infra.Data;

namespace TesteSys10.Infra.Repositories.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly TesteSys10Context _context;
        public UsuarioRepository(TesteSys10Context context) => _context = context;



        public IEnumerable<UsuarioModel> GetAll() => _context.Usuarios.ToList();

        public UsuarioModel Get(int id) => _context.Usuarios.Where(p => p.IdUsuario == id).FirstOrDefault();

        public int Post(UsuarioModel model)
        {
            _context.Usuarios.Add(model);
            _context.SaveChanges();

            return model.IdUsuario;
        }

        public bool Put(UsuarioModel model)
        {
            _context.Entry(model).State = EntityState.Modified;
            _context.SaveChanges();

            return true;
        }

        public bool Delete(int id)
        {
            var user = _context.Usuarios.Where(p => p.IdUsuario == id).FirstOrDefault();
            _context.Remove(user);
            _context.SaveChanges();

            return true;
        }
    }
}
