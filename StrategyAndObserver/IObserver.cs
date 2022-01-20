using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndObserver
{
    interface IObserver
    {
        void Update(IPublisher publisher);
        void Decide(IStrategy strategy);
    }

    class TaxiDriver : IObserver
    {
        private IStrategy _strategy;

        // Выполнение стратегии
        public void Update(IPublisher publisher)
        {
            _strategy.ResponseToRequest();
        }

        // Выбор стратегии
        public void Decide(IStrategy strategy) => this._strategy = strategy;
    }
}
