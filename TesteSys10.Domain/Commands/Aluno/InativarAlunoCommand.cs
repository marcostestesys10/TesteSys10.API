using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Enums;

namespace TesteSys10.Domain.Commands.Aluno
{
    public class InativarAlunoCommand
    {
        public InativarAlunoCommand(int idAluno)
        {
            IdAluno = IdAluno;
            Status = StatusEnum.Inativo;
        }

        public int IdAluno { get; set; }
        public StatusEnum Status { get; set; }
    }
}

