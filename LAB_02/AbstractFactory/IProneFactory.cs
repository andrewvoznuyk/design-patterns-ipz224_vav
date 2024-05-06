using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class IProneFactory : IDevice
    {
        public EBook CreateEBook()
        {
            return new EBook("IProne", 256, "3000 x 1500");
        }

        public Laptop CreateLaptop()
        {
            return new Laptop("IProne", 16, 1000, "SSD", "AMD", "Двоядерний AMD Athlon Silver 3050U (2.3 — 3.2 ГГц)");
        }

        public Netbook CreateNetbook()
        {
            return new Netbook("IProne", 8, 128, "HHD", "Двоядерний AMD Athlon Silver 3050U (2.3 — 3.2 ГГц)");
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone("IProne", "IProne ProMax", "IProne OS", "2796 x 1290");
        }
    }
}
