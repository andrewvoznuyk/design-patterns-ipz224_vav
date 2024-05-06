using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class EBook : IPrint
    {
        public string Brand { get; }
        public int Memory { get; }
        public string ScreenSize { get; }
        public EBook(string brand, int memory, string screenSize)
        {
            Brand = brand;
            Memory = memory;
            ScreenSize = screenSize;
        }

        public string ShowInfo()
        {
            return $"Brand: {Brand}, Memory: {Memory}GB, Screen Size: {ScreenSize}";
        }

    }
}
