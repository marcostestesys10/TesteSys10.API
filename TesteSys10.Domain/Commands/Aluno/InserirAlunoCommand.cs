using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSys10.Domain.Commands.Aluno
{
    public class InserirAlunoCommand
    {
        public string FullName { get; set; }
        public int IdUsuario { get; set; }
        public int IdTurma { get; set; }
        public decimal NotaAluno { get; set; }
    }
}
