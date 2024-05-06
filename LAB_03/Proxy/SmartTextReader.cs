namespace Proxy
{
    public class SmartTextReader : IProxy
    {
        public char[][] ReadText(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                char[][] charArray = new char[lines.Length][];

                for (int i = 0; i < lines.Length; i++)
                {
                    charArray[i] = lines[i].ToCharArray();
                }

                return charArray;
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception}");
                return null;
            }
        }
    }
}
