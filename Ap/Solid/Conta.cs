using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public abstract class Conta
    {
        protected Conta(int id, Cliente cliente)
        {
            this.Id = id;
            this.Cliente = cliente;
        }

        public double Taxa = 10;

        public virtual void AplicaTaxa()
        {
            this.Saldo = this.Saldo - Taxa; 
        }

        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public double Saldo;

        public double GetSaldo()
        {
            return this.Saldo;
        }
        public void SetSaldo()
        {
            this.Saldo = 0;
        }
    }
}