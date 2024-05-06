namespace Adapter
{
    public class FileWriter
    {
        private readonly string _filepath;
        public FileWriter(string filepath)
        {
            _filepath = filepath;
        }
        public void Write(string message)
        {
            File.AppendAllText(_filepath, message);
            Console.WriteLine($"{message}");
        }
        public void WriteLine(string message)
        {
            File.AppendAllText(_filepath, message + Environment.NewLine);
            Console.WriteLine($"{message}");
        }
    }

}
