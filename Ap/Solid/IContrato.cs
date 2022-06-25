using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Solid
{

    // ISP - Crie interfaces refinadas que sejam específicas do cliente

    public interface IContrato<t>
    where t:class
    {
        t Contrata();
        
    }
}