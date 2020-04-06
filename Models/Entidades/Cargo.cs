using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cargo")]
        public string NomeCargo { get; set; }

        public List<Funcionario> Funcionario { get; set; }
    }
}
