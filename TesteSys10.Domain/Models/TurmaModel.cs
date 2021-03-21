using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TesteSys10.Domain.Enums;

namespace TesteSys10.Domain.Models
{
    public class TurmaModel
    {
        public TurmaModel(int idTurma)
        {
            IdTurma = idTurma;
        }

        public TurmaModel(string nomeTurma)
        {
            NomeTurma = nomeTurma;
            Status = StatusEnum.Ativo;
        }

        public TurmaModel(int idTurma, string nomeTurma)
        {
            IdTurma = idTurma;
            NomeTurma = nomeTurma;
        }

        [Key]
        public int IdTurma { get; set; }
        public string NomeTurma { get; set; }
        public IEnumerable<AlunoModel> Alunos { get; set; }
        public StatusEnum Status { get; set; }
    }
}
