using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Turno
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Turno")]
        public string NomeTurno { get; set; }

        public List<Funcionario> Funcionario { get; set; }
    }
}
