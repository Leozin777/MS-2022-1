using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public class ClienteRepository : IBaseRepository<Cliente>
    {
        List<Cliente> Clientes = new List<Cliente>();

        public List<Cliente> GetAll()
        {
            return Clientes;
        }

        public Cliente GetById(int id)
        {
            return Clientes.Find(i => i.Id == id);
        }

        public void Save(Cliente T)
        {
            Clientes.Add(T);
        }
    }
}