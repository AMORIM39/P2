using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public class DescontoQuantidade : IDescontoStrategy
    {
        public double Calcular(ItemPedido item)
        {
            return item.Quantidade >= 3 ? item.Subtotal() * 0.05 : 0;
        }
    }
}
