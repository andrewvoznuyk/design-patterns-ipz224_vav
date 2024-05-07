using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoClassLibrary
{
    public class TextDocument
    {
        public string Content { get; set; }

        public TextDocument(string content)
        {
            Content = content;
        }
    }
}
