using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{
    public interface IBaseRepository<t>
    where t:class
    {
        void Save(t T);
        t GetById(int id);
        List<t> GetAll();
    }
}