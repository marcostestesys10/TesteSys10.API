using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSys10.Domain.Commands.Turma
{
    public class EditarTurmaCommand
    {
        public int IdTurma { get; set; }
        public string NomeTurma { get; set; }
    }
}
