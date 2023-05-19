using System;

namespace Dekorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var pizzaBase = new LargePizza();
            var cheese = new CheesePizzaDecorator(pizzaBase);
            var ham = new HamPizzaDecorator(cheese);
            ham = new HamPizzaDecorator(ham);

            Console.WriteLine(ham.CalculatePrice());
        }
    }
}
