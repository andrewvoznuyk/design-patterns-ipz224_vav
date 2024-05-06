using System;
using System.IO;

namespace Proxy
{
    public class SmartTextChecker : IProxy
    {
        private SmartTextReader file;

        public SmartTextChecker()
        {
            file = new SmartTextReader();
        }

        public char[][] ReadText(string path)
        {
            try
            {
                Console.WriteLine($"Opening file: {path}");

                char[][] content = file.ReadText(path);

                if (content != null)
                {
                    Console.WriteLine($"Successfully read file: {path}");

                    int totalLines = content.Length;
                    int totalCharacters = content.Sum(line => line.Length);
                    Console.WriteLine($"Total lines: {totalLines}");
                    Console.WriteLine($"Total characters: {totalCharacters}");
                }
                else
                {
                    Console.WriteLine($"Failed to read file: {path}");
                }

                Console.WriteLine($"Closing file: {path}");

                return content;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception}");
                return null;
            }
        }
    }
}
