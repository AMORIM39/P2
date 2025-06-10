using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public class DescontoCategoria : IDescontoStrategy
    {
        public double Calcular(ItemPedido item)
        {
            return item.Produto.Categoria == "Eletrônicos" ? item.Subtotal() * 0.1 : 0;
        }
    }
}
