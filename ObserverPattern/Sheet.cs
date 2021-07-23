using System;

namespace ObserverPattern
{
    public class Sheet : IObserver
    {
        public void Notify()
        {
            Console.WriteLine("spreadsheet got notified.");
        }
    }
}
