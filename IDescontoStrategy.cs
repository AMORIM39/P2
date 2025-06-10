using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public interface IDescontoStrategy
    {
        double Calcular(ItemPedido item);
    }
    // OCP (Aberto para extensão, fechado para modificação).
    // Strategy Pattern: Interface que define como aplicar descontos em pedidos.
}
