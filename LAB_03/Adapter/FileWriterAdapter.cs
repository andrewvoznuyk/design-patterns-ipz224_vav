using Adapter;

public class FileWriterAdapter : ILogger
{
    private readonly FileWriter _file;
    public FileWriterAdapter(FileWriter file) : base()
    {
        _file = file;
    }
    public void Error(string message)
    {
        _file.Write($"FileWrite {message}");
        _file.WriteLine($"FileWriteLine {message}");
    }

    public void Log(string message)
    {
        _file.Write($"FileWrite {message}");
        _file.WriteLine($"FileWriteLine {message}");
    }

    public void Warn(string message)
    {
        _file.Write($"FileWrite {message}");
        _file.WriteLine($"FileWriteLine {message}");
    }
}
