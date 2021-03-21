using System;
using System.Collections.Generic;
using System.Text;
using TesteSys10.Domain.Commands.Aluno;
using TesteSys10.Domain.Commands.Escola;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Interfaces.Service;
using TesteSys10.Domain.Models;

namespace TesteSys10.Service.Services.Escola
{
    public class EscolaService : IEscolaService
    {
        private readonly IEscolaRepository _escolaRepository;
        public EscolaService(IEscolaRepository escolaRepository) => _escolaRepository = escolaRepository;


        public bool Delete(InativarEscolaCommand command)
        {
            var escola = new EscolaModel(command.IdEscola);

            return _escolaRepository.Delete(escola);
        }

        public IEnumerable<EscolaModel> GetAll()
        {
            return _escolaRepository.GetAll();
        }
    }
}
