using System;

namespace ObserverPattern
{
    public class Chart : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("chart got notified.");
        }
    }
}
