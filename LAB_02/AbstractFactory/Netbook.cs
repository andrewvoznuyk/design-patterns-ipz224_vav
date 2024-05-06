using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Netbook : IPrint
    {
        public string Brand { get; }
        public int CountCore { get; }
        public int Memory { get; }
        public string DriveType { get; }
        public string Processor { get; }

        public Netbook(string brand, int countCore, int memory, string driveType, string processor)
        {
            Brand = brand;
            CountCore = countCore;
            Memory = memory;
            DriveType = driveType;
            Processor = processor;
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}, CountCore: {CountCore}, Memory: {Memory}GB, DriveType: {DriveType}, Processor: {Processor}";
        }
    }
}
