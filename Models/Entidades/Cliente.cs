using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Nome é obrigatório")]
        public string NomeCliente { get; set; }

        [Required(ErrorMessage = "CPF é obrigatório")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Telefone é obrigatório")]
        public string Telefone { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Endereço é obrigatório")]
        public string Endereco { get; set; }

        [Display(Name = "Número da casa")]
        [Required(ErrorMessage = "nº da casa é obrigatório")]
        public string NumCasa { get; set; }

        public string Complemeto { get; set; }

        [Required(ErrorMessage = "Bairro é obrigatório")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Cidade é obrigatório")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "UF é obrigatório")]
        public string Uf { get; set; }

        public List<Pedido> Pedidos { get; set; }
    }
}
