using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Entidades
{
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nome do Produto")]
        public string NomeProduto { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        public string Quantidade { get; set; }

        [Display(Name = "Valor Unitário")]
        public double ValorUnitario { get; set; }

        public List<Pedido> Pedidos { get; set; }

    }
}
