namespace Mediator
{
    public class TextBox : UIControl
    {
        private string _content;
        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content)
        {
            _content = content;
            NotifyObservers();
        }
    }

}
