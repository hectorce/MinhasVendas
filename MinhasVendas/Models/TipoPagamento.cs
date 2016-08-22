using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasVendas.Models
{
    public class TipoPagamento
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Prazo { get; set; }
        public int Desconto { get; set; }
    }
}