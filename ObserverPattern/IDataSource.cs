namespace ObserverPattern
{
    public interface ISubject
    {
        void AddObserver(IObserver observer);
        int GetValue();
        void RemoveObserver(IObserver observer);
        void SetValue(int value);
    }
}