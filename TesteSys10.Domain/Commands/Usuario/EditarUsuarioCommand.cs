using System;
using System.Collections.Generic;
using System.Text;

namespace TesteSys10.Domain.Commands.Usuario
{
    public class EditarUsuarioCommand
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public int IdPerfil { get; set; }
    }
}
