using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSys10.Domain.Commands.Turma;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Service;

namespace TesteSys10.API.Controllers
{
    [Route("api/[controller]")]
    public class TurmaController : BaseController
    {
        private readonly ITurmaService _turmaService;
        public TurmaController(ITurmaService turmaService) => _turmaService = turmaService;


        [HttpGet,]
        public IActionResult ListAll() => Response(_turmaService.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Response(_turmaService.Get(id));

        [HttpPost]
        public IActionResult Post([FromBody] InserirTurmaCommand command) => Response(_turmaService.Post(command));

        [HttpPut]
        public IActionResult Put([FromBody] EditarTurmaCommand command) => Response(_turmaService.Put(command));

        [HttpPut("InativarTurma")]
        public IActionResult Delete([FromBody] InativarTurmaCommand command) => Response(_turmaService.Delete(command));
    }
}
