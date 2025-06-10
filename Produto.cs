using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public class Produto
    {
        public int Id { get; }
        public string Nome { get; }
        public double Preco { get; set; }
        public string Categoria { get; }

        public Produto(int id, string nome, double preco, string categoria)
        {
            if (preco <= 0)
                throw new ArgumentException("O preço do produto deve ser maior que zero.");

            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }
        // SRP (Princípio da Responsabilidade Única): A classe representa o produto e sua validação.
    }
}

