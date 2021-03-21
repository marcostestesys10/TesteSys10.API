using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TesteSys10.Domain.Models
{
    public class UsuarioModel
    {
        public UsuarioModel(string fullName, int age, DateTime birthDate, string document, int idPerfil)
        {
            FullName = fullName;
            Age = age;
            BirthDate = birthDate;
            Document = document;
            IdPerfil = idPerfil;

            CreatedAt = DateTime.Now;
        }

        public UsuarioModel(int id, string fullName, int age, DateTime birthDate, string document, int idPerfil)
        {
            IdUsuario = id;
            FullName = fullName;
            Age = age;
            BirthDate = birthDate;
            Document = document;
            IdPerfil = idPerfil;

            CreatedAt = DateTime.Now;
        }

        [Key]
        public int IdUsuario { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public DateTime CreatedAt { get; set; }
        public int IdPerfil { get; set; }
        public PerfilModel Perfil { get; set; }
    }
}
