using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLibrary
{
    public class TextEditor
    {
        private TextDocument currentDocument;
        private History history;

        public TextEditor()
        {
            currentDocument = new TextDocument("");
            history = new History();
        }

        public void Save()
        {
            history.Save(currentDocument);
        }

        public void Undo()
        {
            TextDocument previousDocument = history.Undo();
            if (previousDocument != null)
            {
                currentDocument = previousDocument;
                Console.WriteLine("Undo successful.");
            }
            else
            {
                Console.WriteLine("Nothing to undo.");
            }
        }

        public void SetContent(string content)
        {
            currentDocument.Content = content;
        }

        public string GetContent()
        {
            return currentDocument.Content;
        }

    }
}
