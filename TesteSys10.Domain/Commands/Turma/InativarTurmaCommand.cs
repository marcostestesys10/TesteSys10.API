using TesteSys10.Domain.Enums;

namespace TesteSys10.Domain.Commands.Turma
{
    public class InativarTurmaCommand
    {
        public InativarTurmaCommand(int idTurma)
        {
            IdTurma = idTurma;
            Status = StatusEnum.Inativo;
        }

        public int IdTurma { get; set; }
        public StatusEnum Status { get; set; }
    }
}
