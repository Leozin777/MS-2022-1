using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(int id, Cliente cliente) : base(id, cliente)
        {
        }

        public virtual void AplicaTaxa()
        {
            this.Saldo = this.Saldo - Taxa; 
        }
    }
}