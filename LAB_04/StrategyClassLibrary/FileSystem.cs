namespace StrategyClassLibrary
{
    public class FileSystem : IStrategy
    {
        public byte[] LoadImage(string href)
        {
            return File.ReadAllBytes(href);
        }

    }
}
