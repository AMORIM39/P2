using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public class Pedido
    {
        public int Id { get; }
        public Cliente Cliente { get; }
        public List<ItemPedido> Itens { get; }
        public DateTime Data { get; }
        public double ValorTotal { get; set; }

        public Pedido(int id, Cliente cliente, List<ItemPedido> itens)
        {
            Id = id;
            Cliente = cliente;
            Itens = itens;
            Data = DateTime.Now;
            ValorTotal = itens.Sum(i => i.Subtotal());
        }
        // SRP(Princípio da Responsabilidade Única): Pedido representa os dados e ações básicas de um pedido.
    }

}
