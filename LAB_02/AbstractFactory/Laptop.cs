using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Laptop : IPrint
    {
        public string Brand { get; }
        public int CountCore { get; }
        public int Memory { get; }
        public string DriveType { get; }
        public string VideoCard { get; }
        public string Processor { get; }

        public Laptop(string brand, int countCore, int memory, string driveType, string videoCard, string processor)
        {
            Brand = brand;
            CountCore = countCore;
            Memory = memory;
            DriveType = driveType;
            VideoCard = videoCard;
            Processor = processor;
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}, CountCore: {CountCore}, Memory: {Memory}GB, DriveType: {DriveType}, VideoCard: {VideoCard}, Processor: {Processor}";
        }

    }
}
