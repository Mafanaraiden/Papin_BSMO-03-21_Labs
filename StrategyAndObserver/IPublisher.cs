using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAndObserver
{
    enum State
    {
        LookingForTaxi,
        InACar
    }

    interface IPublisher
    {
        void Add(IObserver observer);
        void Remove(IObserver observer);
        void Notify();
    }

    class TaxiUser : IPublisher
    {
        // Переменная состояния
        // Изначально пользователь ищет такси
        private State _state = State.LookingForTaxi;
        // Список наблюдателей
        private List<IObserver> _observers = new List<IObserver>();

        public void Add(IObserver observer) => _observers.Add(observer);

        public void Notify()
        {
            if (_state == State.LookingForTaxi) _state = State.InACar;
            else _state = State.LookingForTaxi;

            foreach (var obs in _observers)
            {        
                obs.Update(this);
            }
        }

        public void Remove(IObserver observer) => _observers.Remove(observer);

        public TaxiUser() { }

    }
}
