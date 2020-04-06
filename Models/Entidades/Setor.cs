using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Setor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Setor")]
        public string NomeSetor { get; set; }

        public List<Funcionario> Funcionario { get; set; }

    }
}
