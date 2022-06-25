using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public abstract class Pessoa
    {
        //SRP - Classe Pessoa tem somente uma responsabilidade que é passar os atributos e o construtor para as classes filhas
        protected Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; } 
        public string Nome { get; set; }
    }
}

