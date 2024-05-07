namespace MementoClassLibrary
{
    public class History
    {
        private Stack<TextDocument> history;

        public History()
        {
            history = new Stack<TextDocument>();
        }

        public void Save(TextDocument document)
        {
            TextDocument snapshot = new TextDocument(document.Content);
            history.Push(snapshot);
        }

        public TextDocument Undo()
        {
            if (history.Count > 0)
            {
                return history.Pop();
            }
            return null;
        }

    }
}
