using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class PessoaFisica : Pessoa, ITrabalho
    {
        public PessoaFisica(int id, string nome, string cpf) : base(id, nome)
        {
            this.Cpf = cpf;
        }

        // DIP - Este método depende da abstração e não da classe concreta
        public string Classe(ITrabalho itrabalho)
        {
            return itrabalho.IrProTrab();
        }


        //OCP - a classe PessoaFisica extende a Classe Pessoa, qualquer adição será feita aq e não na classe Pessoa
        public string Cpf { get; set; }
    }
}