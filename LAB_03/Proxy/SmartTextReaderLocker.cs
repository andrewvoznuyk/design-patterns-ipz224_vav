using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Proxy
{
    public class SmartTextReaderLocker : IProxy
    {
        private SmartTextReader _reader;
        private SmartTextChecker _checker;
        private readonly string _regexPattern;

        public SmartTextReaderLocker(string regex)
        {
            _reader = new SmartTextReader();
            _checker = new SmartTextChecker();
            _regexPattern = regex;
        }

        public char[][] ReadText(string path)
        {
            try
            {
                if (!Regex.IsMatch(path, _regexPattern))
                {
                    Console.WriteLine("Access denied!");
                    return null;
                }
                return _checker.ReadText(path);
            }
            catch (Exception exception)
            {
                Console.WriteLine($"Error: {exception}");
                return null;
            }
        }
    }
}
