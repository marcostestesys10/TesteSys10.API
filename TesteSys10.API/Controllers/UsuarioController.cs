using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Service;

namespace TesteSys10.API.Controllers
{
    [Route("api/[controller]")]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioService _usuarioService;
        public UsuarioController(IUsuarioService usuarioService) => _usuarioService = usuarioService;


        [HttpGet,]
        public IActionResult ListAll() => Response(_usuarioService.GetAll());

        [HttpGet("{id}")]
        public IActionResult Get(int id) => Response(_usuarioService.Get(id));

        [HttpPost]
        public IActionResult Post([FromBody] InserirUsuarioCommand command) => Response(_usuarioService.Post(command));

        [HttpPut]
        public IActionResult Put([FromBody] EditarUsuarioCommand command) => Response(_usuarioService.Put(command));

        [HttpDelete]
        public IActionResult Delete([FromBody] int id) => Response(_usuarioService.Delete(id));
    }
}
