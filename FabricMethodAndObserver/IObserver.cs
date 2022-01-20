using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FabricMethodAndObserver
{
    interface IObserver
    {
        void Update(IPublisher publisher);
    }


}
