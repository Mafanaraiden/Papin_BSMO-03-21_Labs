using System;

namespace Lab2
{
    //Абстрактаная фабрика
    abstract class Thing
    {
        //Фабричный метод
        public abstract IMovement FactoryMethod();
        public void DoingFactoryMethod()
        {
            var product = FactoryMethod();
            product.Operation(name);
        }
        //Геттер и сеттер имени или клички
        public string Name{ get => name; set => name = value; }
        //Конструктор с именем
        public Thing(string name) => Name = name; 
        //Имя или кличка
        private string name;
    }

    //Абстрактный продукт
    interface IMovement
    {
        void Operation(string name);
    }
    
    //Конкретная фабрика 1
    class Human : Thing
    {
        public Human(string name) : base(name) { }
        public override IMovement FactoryMethod()
        {
            return new Walk();
        }
    }

    //Конкретная фабрика 2
    class Fish : Thing
    {
        public Fish(string name) : base(name) { }
        public override IMovement FactoryMethod()
        {
            return new Swim();
        }
    }

    //Конкретная фабрика 3
    class Bird : Thing
    {
        public Bird(string name) : base(name) { }
        public override IMovement FactoryMethod()
        {
            return new Fly();
        }
    }

    //Конкретный продукт 1
    class Fly : IMovement
    {
        public void Operation(string name)
        {
            Console.WriteLine(name + " летит");
        }
    }

    //Конкретный продукт 2
    class Walk : IMovement
    {
        public void Operation(string name)
        {
            Console.WriteLine(name + " идёт");
        }
    }

    //Конкретный продукт 3
    class Swim : IMovement
    {
        public void Operation(string name)
        {
            Console.WriteLine(name + " плывёт");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var human = new Human("Человек А");
            human.DoingFactoryMethod();

            var bird = new Bird("Птица В");
            bird.DoingFactoryMethod();

            var fish = new Fish("Рыба С");
            fish.DoingFactoryMethod();
        }
    }
}
