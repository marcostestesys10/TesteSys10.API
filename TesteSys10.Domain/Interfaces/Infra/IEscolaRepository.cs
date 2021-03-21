using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Models;

namespace TesteSys10.Domain.Interfaces.Infra
{
    public interface IEscolaRepository
    {
        IEnumerable<EscolaModel> GetAll();
        bool Delete(EscolaModel model);
    }
}
