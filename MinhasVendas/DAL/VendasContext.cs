using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity

namespace MinhasVendas.DAL
{
    public class VendasContext : DbContext
    {
        public VendasContext() : base("VendasContext")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<TipoProduto> TipoProdutos { get; set; }
        public DbSet<TipoPagamento> TipoPagamentos { get; set; }
    }
}