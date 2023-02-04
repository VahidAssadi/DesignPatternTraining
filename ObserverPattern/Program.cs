using Builder;
using DesignPattern.Decorator;
using System;

namespace DesignPattern.Builder
{
    class Program
    {
        static void Main(string[] args)
        {

            IIceCream icecream = new SimpleICeCream();
            icecream.GetPrice();
            IIceCream iceCreamWithChocolate = new ChocolateDecorator(icecream);
            var chocoandpeste = new PesteDecorator(iceCreamWithChocolate);
            Console.WriteLine("Standard basic product:" + chocoandpeste.GetPrice().ToString());

        }
    }
}
