using System;

namespace Mediator
{


    public abstract class UIControl
    {      
        public event EventHandler AddEventHandler;
        protected void NotifyObservers()
        {
            OnUIControlChanged();
        }
        private void OnUIControlChanged()
        {
            //if (AddEventHandler != null)
            //{
            //    AddEventHandler(this, EventArgs.Empty);
            //}
            // Raise the ui control event
            AddEventHandler?.Invoke(this, EventArgs.Empty);

        }
    }

}
