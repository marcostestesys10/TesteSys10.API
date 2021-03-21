using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TesteSys10.Domain.Enums;

namespace TesteSys10.Domain.Models
{
    public class AlunoModel
    {
        public AlunoModel(int idAluno)
        {
            IdAluno = idAluno;
        }

        public AlunoModel(int idAluno, int idTurma, decimal notaAluno)
        {
            IdAluno = idAluno;
            IdTurma = idTurma;
            NotaAluno = notaAluno;
        }

        public AlunoModel(string fullName, int idUsuario, int idTurma)
        {
            FullName = fullName;
            IdUsuario = idUsuario;
            IdTurma = idTurma;
            IdPerfil = PerfilEnum.Aluno;
            Status = StatusEnum.Ativo;
        }

        public AlunoModel(int idAluno, string fullName, int idUsuario, int idTurma)
        {
            IdAluno = idAluno;
            FullName = fullName;
            IdUsuario = idUsuario;
            IdTurma = idTurma;
        }

        [Key]
        public int IdAluno { get; set; }
        public string FullName { get; set; }
        public int IdUsuario { get; set; }
        public int IdTurma { get; set; }
        public decimal NotaAluno { get; set; }
        public PerfilEnum IdPerfil { get; set; }
        public StatusEnum Status { get; set; }
    }
}
