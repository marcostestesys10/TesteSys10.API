using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSys10.Domain.Commands.Aluno
{
    public class InsertNotaAlunoCommand
    {
        public int IdAluno { get; set; }
        public int IdTurma { get; set; }
        public decimal NotaAluno { get; set; }
    }
}
