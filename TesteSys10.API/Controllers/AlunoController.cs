using Microsoft.AspNetCore.Mvc;
using TesteSys10.Domain.Commands.Aluno;
using TesteSys10.Domain.Interfaces.Service;

namespace TesteSys10.API.Controllers
{
    [Route("api/[controller]")]
    public class AlunoController : BaseController
    {
        private readonly IAlunoService _alunoService;
        public AlunoController(IAlunoService alunoService) => _alunoService = alunoService;


        [HttpGet]
        public IActionResult ListAll() => Response(_alunoService.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Response(_alunoService.Get(id));

        [HttpPost]
        public IActionResult Post([FromBody] InserirAlunoCommand command) => Response(_alunoService.Post(command));

        [HttpPut("InsertNotaAluno")]
        public IActionResult PutNotaAluno([FromBody] InserirAlunoCommand command) => Response(_alunoService.Post(command));

        [HttpPut]
        public IActionResult Put([FromBody] EditarAlunoCommand command) => Response(_alunoService.Put(command));

        [HttpPut("InativarAluno")]
        public IActionResult Delete([FromBody] InativarAlunoCommand command) => Response(_alunoService.Delete(command));
    }
}
