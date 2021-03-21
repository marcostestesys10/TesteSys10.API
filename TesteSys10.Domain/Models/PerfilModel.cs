using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteSys10.Domain.Models
{
    public class PerfilModel
    {
        [Key]
        public int IdPerfil { get; set; }
        public string Description { get; set; }
    }
}
