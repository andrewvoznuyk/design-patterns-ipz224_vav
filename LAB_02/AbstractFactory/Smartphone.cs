using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Smartphone : IPrint
    {
        public string Brand { get; }
        public string Model { get; }
        public string System { get; }
        public string ScreenSize { get; }

        public Smartphone(string brand, string model, string system, string screenSize)
        {
            Brand = brand;
            Model = model;
            System = system;
            ScreenSize = screenSize;
        }
        public string ShowInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, System: {System}, ScreenSize: {ScreenSize}";
        }
    }
}
