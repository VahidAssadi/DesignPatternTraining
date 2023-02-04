using System.Collections.Generic;

namespace ObserverPattern
{
    public class DataSource : ISubject
    {
        private int _value;

        private readonly List<IObserver> _observers = new List<IObserver>();

        public DataSource()
        {
           
        }
        public void SetValue(int value)
        {

            _value = value;
            NotifyObservers();

        }

        private void NotifyObservers()
        {
            foreach (var subscriber in _observers)
            {
                subscriber.Notify();
            }
        }

        public int GetValue()
        {
            return _value;
        }


        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }
        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
