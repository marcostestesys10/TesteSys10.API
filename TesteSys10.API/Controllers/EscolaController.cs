using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSys10.Domain.Commands.Aluno;
using TesteSys10.Domain.Commands.Escola;
using TesteSys10.Domain.Commands.Turma;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Service;
using TesteSys10.Domain.Models;

namespace TesteSys10.API.Controllers
{
    [Route("api/[controller]")]
    public class EscolaController : BaseController
    {
        private readonly IEscolaService _escolaService;
        public EscolaController(IEscolaService escolaService) => _escolaService = escolaService;


        [HttpGet]
        public IActionResult ListAll() => Response(_escolaService.GetAll());

        [HttpPut("InativarEscola")]
        public IActionResult Delete([FromBody] InativarEscolaCommand command) => Response(_escolaService.Delete(command));
    }
}
