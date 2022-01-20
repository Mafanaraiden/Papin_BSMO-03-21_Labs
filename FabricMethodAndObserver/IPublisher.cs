using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FabricMethodAndObserver
{
    interface IPublisher
    {
        // Добавление подписчика
        void Attach(IObserver observer);

        // Удаление подписчика
        void Detach(IObserver observer);

        // Уведомляет всех наблюдателей о событии
        void Notify();
    }

    enum State
    {

    }

    class Publisher : IPublisher
    {
        // Список подписчиков
        private List<IObserver> _observers = new List<IObserver>();

        // Состояние издателя
        private State state { get; set; }


        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void Notify()
        {
            for(int i = 0; i < _observers.Count; i++)
            {
                _observers[i].Update(this);
            }
        }
    }
}
