using Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lightweight
{
    public class HTML_Layout
    {
        public static string GetTextFromFile(string filePath)
        {

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File '{filePath}' not found.");
                return null;
            }


            try
            {

                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading the file: {ex.Message}");
                return null;
            }

        }
        // Method without lightweight
        public static Composite.LightElementNode ConvertTextToHTML(string text)
        {

            string[] lines = string.IsNullOrWhiteSpace(text) ? new string[0] : text.Split('\n');

            var block = new Composite.LightElementNode("div", "block", "normal", new List<string>(), new List<LightNode>());

            block.Children.Add(new Composite.LightElementNode("h1", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($"{lines[0].Trim()} \n") }));

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();
                LightNode node;

                if (string.IsNullOrWhiteSpace(line))
                {
                    node = new Composite.LightElementNode("p", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode("<br>  \n") });
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = new Composite.LightElementNode("blockquote", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($" {line} \n") });
                }
                else if (line.Length < 20)
                {
                    node = new Composite.LightElementNode("h2", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($" {line} \n") });
                }
                else
                {
                    node = new Composite.LightElementNode("p", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($"{line} \n") });
                }

                block.Children.Add(node);
            }

            return block;
        }


        // Method using a lightweight
        public static LightElementNode ConvertTextToHTMLLightweight(string text)
        {
            string[] lines = string.IsNullOrWhiteSpace(text) ? new string[0] : text.Split('\n');
            var block = LightElementNode.GetElementNode("div", "block", "normal", new List<string>(), new List<LightNode>());

            block.Children.Add(LightElementNode.GetElementNode("h1", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($"{lines[0].Trim()} \n") }));

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i].TrimEnd();
                LightNode node;

                if (string.IsNullOrWhiteSpace(line))
                {
                    node = LightElementNode.GetElementNode("p", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode("<br>  \n") });
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    node = LightElementNode.GetElementNode("blockquote", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($" {line} \n") });
                }
                else if (line.Length < 20)
                {
                    node = LightElementNode.GetElementNode("h2", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($" {line} \n") });
                }
                else
                {
                    node = LightElementNode.GetElementNode("p", "block", "normal", new List<string>(), new List<LightNode> { new LightTextNode($"{line} \n") });
                }

                block.Children.Add(node);
            }

            return block;
        }

    }
}
