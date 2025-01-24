using System;

namespace Serializacao.Models
{
    public class Venda
    {
        // Construtor da classe Venda
        public Venda(int id, string produto, decimal preco, DateTime dataVenda, decimal desconto)
        {
            Id = id;            // Corrigi para "Id" para ficar consistente
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
            Desconto = desconto;
        }
        
        // Propriedades da classe
        public int Id { get; set; }            // Mudado para "Id" para consistência
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public decimal? Desconto { get; set; }  // A propriedade "Desconto" pode ser nula, por isso o uso do tipo nullable (decimal?)
    }
}
