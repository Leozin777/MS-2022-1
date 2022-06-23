using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class Cliente
    {
        public Cliente(int id, string nome, string cpf)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
        }
        
        public int Id { get; set; } 
        public string Nome { get; set; }
        public string Cpf { get; set; }
    }
}