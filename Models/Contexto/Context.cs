using AlimentosMarfim.Models.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlimentosMarfim.Models.Contexto
{
    public class Context : DbContext
    {

        public DbSet<Setor> Setor { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=DBAlimetosMarfim;Integrated Security=True");
        }

    }
}
