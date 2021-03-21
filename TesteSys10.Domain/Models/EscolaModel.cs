using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TesteSys10.Domain.Enums;

namespace TesteSys10.Domain.Models
{
    public class EscolaModel
    {
        public EscolaModel(int idEscola)
        {
            IdEscola = idEscola;

            Turmas = new List<TurmaModel>();
        }

        [Key]
        public int IdEscola { get; set; }
        public string Title { get; set; }
        IEnumerable<TurmaModel> Turmas { get; set; }
        public StatusEnum Status { get; set; }
    }
}
