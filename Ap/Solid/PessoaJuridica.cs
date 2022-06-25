using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class PessoaJuridica : Pessoa, IContrato <Pessoa>
    {
        public PessoaJuridica(int id, string nome) : base(id, nome)
        {
        }

        public Pessoa Contrata()
        {
            throw new NotImplementedException();
        }
    }
}