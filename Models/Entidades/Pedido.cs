using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Data da Compra")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "(0:dd-MM-yyyy)", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Campo de datas é obrigatório")]
        public DateTime DataCompra { get; set; }

        [ForeignKey ("ClienteId")]
        [Display(Name = "Cliente" )]
        public int ClienteId { get; set; }
        [Required(ErrorMessage = "Nome do Cliente é obrigatório")]
        public Cliente Cliente { get; set; }

        [ForeignKey("FunicionarioId")]
        [Display(Name = "Funcionário")]
        public int FunicionarioId { get; set; }
        [Required(ErrorMessage = "Nome do Funcionário é obrigatório")]
        public Funcionario Funcionario { get; set; }

        [ForeignKey("ProdutoId")]
        [Display(Name = "Produtos")]
        public int ProdutoId { get; set; }
        public Produto Produtos { get; set; }

        public double ValorTotal { get; set; }

    }
}
