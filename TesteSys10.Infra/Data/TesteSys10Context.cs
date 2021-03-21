using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Models;

namespace TesteSys10.Infra.Data
{
    public class TesteSys10Context : DbContext
    {
        public TesteSys10Context(DbContextOptions<TesteSys10Context> options): base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<PerfilModel> Perfis { get; set; }
        public DbSet<EscolaModel> Escola{ get; set; }
        public DbSet<TurmaModel> Turmas { get; set; }
        public DbSet<AlunoModel> Alunos { get; set; }
    }
}
