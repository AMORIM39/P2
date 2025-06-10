using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public class ItemPedido
    {
        public Produto Produto { get; }
        public int Quantidade { get; }

        public ItemPedido(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;
        }

        public double Subtotal() => Produto.Preco * Quantidade;
    }
    // SRP (Princípio da Responsabilidade Única): representa um  item dentro do pedido com quantidade e produto.
}
