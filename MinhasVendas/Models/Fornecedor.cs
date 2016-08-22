using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MinhasVendas.Models
{
    public class Fornecedor
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public string Observacao { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}