using System;

namespace Mediator
{
    public class ArticleDialogBox
    {
        //we should tell to these ui control that this article dialog box is interested to know about their state changes
        private readonly Button _savebutton = new Button();
        private readonly ListBox _articlelistBox = new ListBox();
        private readonly TextBox _titleTextBox = new TextBox();
        public ArticleDialogBox()
        {
            _articlelistBox.AddEventHandler += ArticleSelected;
            _titleTextBox.AddEventHandler += TitleChanged;

        }

        public void SimulateUserInteraction()
        {
            _articlelistBox.SetSelection("article one");
            _titleTextBox.SetContent("");
            _titleTextBox.SetContent("Article two");
            Console.WriteLine("textbox:"+_titleTextBox.GetContent());
            Console.WriteLine("button:"+_savebutton.isEnabled());
            Console.WriteLine("listbox:"+_articlelistBox.GetSelection());
        }
        private void TitleChanged(object sender, EventArgs args)
        {
            var content = _titleTextBox.GetContent();
            var isEmpty = string.IsNullOrEmpty(content);
            _savebutton.SetEnabled(!isEmpty);
        }
        private void ArticleSelected(object sender, EventArgs args)
        {
            _titleTextBox.SetContent(_articlelistBox.GetSelection());
            _savebutton.SetEnabled(true);
        }
    }

}
