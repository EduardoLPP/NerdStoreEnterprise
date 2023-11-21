using NSE.Core.DomainObjects;
using System;

namespace NSE.Catalogo.API.Models
{
    public class Produto : Entity, IAggregateRoot
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
        public decimal Valor { get; set; }
        public DateTime Cadastro { get; set; }
        public string Imagem { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }
}