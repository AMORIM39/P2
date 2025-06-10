using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{

    public class Program
    {
        public static void Main()
        {
            var notebook = new Produto(1, "Notebook", 3000.0, "Eletrônicos");
            var caderno = new Produto(2, "Caderno", 20.0, "Papelaria");

            var maria = new Cliente(1, "Maria", "maria@email.com", "12345678900");

            var item1 = new ItemPedido(notebook, 1);
            var item2 = new ItemPedido(caderno, 5);

            var factory = new PedidoFactory();
            var pedido = factory.CriarPedido(1, maria, new List<ItemPedido> { item1, item2 });

            var repo = new PedidoRepository();
            var logger = new ConsoleLogger();
            var estrategias = new List<IDescontoStrategy> { new DescontoCategoria(), new DescontoQuantidade() };

            var service = new PedidoService(repo, logger, estrategias);
            service.RegistrarPedido(pedido);
            service.GerarRelatorio();
        }
    }
}

