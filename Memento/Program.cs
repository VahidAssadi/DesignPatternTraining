using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }


    public class Editor
    {
        private string _content;


        public string GetContent()
        {
            return _content;
        }

        public void SetContent(string content) {
            _content = content;
        }
    }
}
