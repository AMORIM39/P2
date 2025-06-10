using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    using System.Collections.Generic;

    public class PedidoRepository
    {
        private readonly List<Pedido> _pedidos = new();

        public void Salvar(Pedido pedido)
        {
            _pedidos.Add(pedido);
        }

        public List<Pedido> ListarTodos() => _pedidos;
    }
}
