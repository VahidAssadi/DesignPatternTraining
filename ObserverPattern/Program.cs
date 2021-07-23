using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var publisher = new DataSource();
            var subscriber1 = new Sheet();
            var subscriber2 = new Sheet();
            var subscriber3 = new Chart();
            publisher.AddObserver(subscriber1);
            publisher.AddObserver(subscriber2);
            publisher.AddObserver(subscriber3);
            publisher.SetValue(1);
        }
    }
}
