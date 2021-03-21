using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using TesteSys10.Domain.Commands.Usuario;
using TesteSys10.Domain.Interfaces.Infra;
using TesteSys10.Domain.Interfaces.Service;
using TesteSys10.Domain.Models;

namespace TesteSys10.Service.Services.Token
{
    public class TokenService : ITokenService
    {
        public string GetToken(int id, int idPerfil)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, id.ToString()),
                    new Claim(ClaimTypes.Role, idPerfil.ToString())
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static class Settings
        {
            public static string Secret = "fedaf7d8863b48e197b9287d492b708e";
        }
    }
}
