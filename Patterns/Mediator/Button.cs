namespace Mediator
{
    public class Button : UIControl
    {

        private bool _isEnabled;

        public bool isEnabled()
        {
            return _isEnabled;
        }
        public void SetEnabled(bool enabled)
        {
            _isEnabled = enabled;
            NotifyObservers();
        }
    }

}
