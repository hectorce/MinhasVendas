using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasVendas.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public int Quantidade { get; set; }
        public double PrecoCompra { get; set; }
        public double PrecoVenda { get; set; }
    }
}