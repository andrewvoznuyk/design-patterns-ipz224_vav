using System.IO;

namespace StrategyClassLibrary
{
    public class Image
    {
        private IStrategy _strategy;

        public Image(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public byte[] LoadImage(string href)
        {
            if (File.Exists(href))
            {
                return _strategy.LoadImage(href);
            }
            else
            {
                return _strategy.LoadImage(href);
            }
        }
    }
}
