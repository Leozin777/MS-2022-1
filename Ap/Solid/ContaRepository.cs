using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class ContaRepository : IBaseRepository<Conta>
    {
        List<Conta> Contas = new List<Conta>();

        public List<Conta> GetAll()
        {
            return Contas;
        }

        public Conta GetById(int id)
        {
            return Contas.Find(i => i.Id == id);
        }

        public void Save(Conta T)
        {
            Contas.Add(T);
        }
    }
}