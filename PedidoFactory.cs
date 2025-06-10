using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    using System.Collections.Generic;

    public class PedidoFactory
    {
        public Pedido CriarPedido(int id, Cliente cliente, List<ItemPedido> itens)
        {
            return new Pedido(id, cliente, itens);
        }
        // Factory Pattern: encapsula a lógica de criação de pedidos em uma única classe.
    }


}
