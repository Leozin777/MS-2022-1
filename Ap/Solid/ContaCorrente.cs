using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class ContaCorrente : Conta
    {
        public ContaCorrente(int id, Cliente cliente) : base(id, cliente)
        {
        }

        public override void AplicaTaxa()
        {
            this.Saldo = this.Saldo - 15; 
        }

    }
}