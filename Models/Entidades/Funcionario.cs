using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Funcionario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Display(Name = "Nome do Funcionário")]
        public string NomeFuncionario { get; set; }


        [Required(ErrorMessage = "PIS é obrigatório")]
        public string PIS { get; set; }


        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }


        [Required(ErrorMessage = "Salário é obrigatório")]
        [Display(Name = "Salário")]
        public double Salario { get; set; }


        [ForeignKey("CargoId")]
        [Display(Name = "Cargo")]
        public int CargoId { get; set; }
        [Required(ErrorMessage = "Cargo é obrigatório")]
        public Cargo Cargo { get; set; }


        [ForeignKey("SetorId")]
        [Display(Name = "Setor")]
        public int SetorId { get; set; }
        [Required(ErrorMessage = "Setor é obrigatório")]
        public Setor Setor { get; set; }


        [ForeignKey("TurnoId")]
        [Display(Name = "Turno")]
        public int TurnoId { get; set; }
        [Required(ErrorMessage = "Turno é obrigatório")]
        public Turno Turno { get; set; }


        public List<Pedido> Pedidos { get; set; }

    }
}
