using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Enums;

namespace TesteSys10.Domain.Commands.Escola
{
    public class InativarEscolaCommand
    {
        public InativarEscolaCommand(int idEscola)
        {
            IdEscola = idEscola;
            Status = StatusEnum.Inativo;
        }

        public int IdEscola { get; set; }
        public StatusEnum Status { get; set; }
    }
}
