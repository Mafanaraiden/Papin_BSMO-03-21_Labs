using System;

namespace AbstractFabric
{
    // Абстрактная фабрика
    interface IFabric
    {
        IVacuumCleaner GetVacuum();
        IFan GetFan();
    }

    // Конкретная фабрика 1
    class ForHouse : IFabric
    {
        public IFan GetFan() =>  new DomesticFan();

        public IVacuumCleaner GetVacuum() => new DomesticVacuum();
    }

    // Конкретная фабрика 2
    class ForIndustry : IFabric
    {
        public IFan GetFan() => new IndustrialFan();

        public IVacuumCleaner GetVacuum() => new IndustrialVacuum();
    }

    // Абстрактный продукт 1
    interface IVacuumCleaner
    {
        void Execute();
    }

    class DomesticVacuum : IVacuumCleaner
    {
        public void Execute()
        {
            Console.WriteLine("Пылесос работает");
        }
    }

    class IndustrialVacuum : IVacuumCleaner
    {
        public void Execute()
        {
            Console.WriteLine("Промышленный пылесос работает");
        }
    }

    // Абстрактный продукт 2
    interface IFan
    {
        void Execute();
    }

    class DomesticFan : IFan
    {
        public void Execute()
        {
            Console.WriteLine("Домашний фен работает");
        }
    }

    class IndustrialFan : IFan
    {
        public void Execute()
        {
            Console.WriteLine("Промышленный фен работает");
        }
    }

    class Director
    {
        private IFabric _f;

        public void setFabric(IFabric f) => this._f = f;
        public void ExecuteVacuum() => this._f.GetVacuum().Execute();
        public void ExecuteFan() => this._f.GetFan().Execute();
    }


    class Program
    {
        static void Main(string[] args)
        {
            var dir = new Director();

            IFabric fabric = new ForHouse();
            dir.setFabric(fabric);
            dir.ExecuteFan();
            dir.ExecuteVacuum();

            fabric = new ForIndustry();
            dir.setFabric(fabric);
            dir.ExecuteFan();
            dir.ExecuteVacuum();
        }
    }
}
