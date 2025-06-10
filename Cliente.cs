using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_CAIO
{
    public class Cliente
    {
        public int Id { get; }
        public string Nome { get; }
        public string Email { get; }
        public string Cpf { get; }

        public Cliente(int id, string nome, string email, string cpf)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Cpf = cpf;
        }
        // LSP (Princípio de Substituição de Liskov): Cliente sendo usado aonde se espera uma Pessoa 
    }

}
