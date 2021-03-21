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
    public class TokenController : BaseController
    {
        private readonly ITokenService _tokenService;
        public TokenController(ITokenService tokenService) => _tokenService = tokenService;

        [HttpGet("{id}/{idPerfil}")]
        public IActionResult Get(int id, int idPerfil) => Response(_tokenService.GetToken(id, idPerfil));

    }
}
