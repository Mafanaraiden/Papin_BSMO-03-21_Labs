using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndObserver
{
    interface IStrategy
    {
        void ResponseToRequest();
    }

    class DeclineRequest : IStrategy
    {
        public void ResponseToRequest()
        {
            Console.WriteLine("Заказ отклонен");
        }
    }

    class AcceptRequest : IStrategy
    {
        public void ResponseToRequest()
        {
            Console.WriteLine("Заказ принят");
        }
    }
}
