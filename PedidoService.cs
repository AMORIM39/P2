using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    using System.Collections.Generic;
    using System.Linq;

    public class PedidoService
    {
        private readonly PedidoRepository _repository;
        private readonly ILogger _logger;
        private readonly List<IDescontoStrategy> _estrategias;

        public PedidoService(PedidoRepository repository, ILogger logger, List<IDescontoStrategy> estrategias)
        {
            _repository = repository;
            _logger = logger;
            _estrategias = estrategias;
        }

        public void RegistrarPedido(Pedido pedido)
        {
            AplicarDescontos(pedido);
            _repository.Salvar(pedido);
            _logger.Log($"Pedido {pedido.Id} registrado para {pedido.Cliente.Nome}.");
        }

        private void AplicarDescontos(Pedido pedido)
        {
            foreach (var item in pedido.Itens)
            {
                var descontoTotal = _estrategias.Sum(e => e.Calcular(item));
                item.Produto.Preco -= descontoTotal / item.Quantidade;
            }
            pedido.ValorTotal = pedido.Itens.Sum(i => i.Subtotal());
        }

        public void GerarRelatorio()
        {
            foreach (var pedido in _repository.ListarTodos())
            {
                Console.WriteLine($"Pedido {pedido.Id} - Cliente: {pedido.Cliente.Nome} - Total: R$ {pedido.ValorTotal:F2}");
                foreach (var item in pedido.Itens)
                {
                    Console.WriteLine($"  - {item.Produto.Nome} x{item.Quantidade} - R$ {item.Subtotal():F2}");
                }
                Console.WriteLine("---");
            }
            // SRP: esta classe coordena os processos principais (registro e relatório).
            // DIP: depende de abstrações como IRepositorioDePedidos, IRegistroDeLog e IEstrategiaDeDesconto.
        }
    }

}
