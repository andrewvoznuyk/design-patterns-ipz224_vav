using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class KiaomiFactory : IDevice
    {
        public EBook CreateEBook()
        {
            return new EBook("Kiaomi", 32, "2000 x 1500");
        }

        public Laptop CreateLaptop()
        {
            return new Laptop("Kiaomi", 8, 1000, "SSD", "AMD", "Восьмиядерний Intel Core i5-12450H (2.0 - 4.4 ГГц)");
        }

        public Netbook CreateNetbook()
        {
            return new Netbook("Kiaomi", 8, 256, "HHD", "Восьмиядерний Intel Core i5-12450H (2.0 - 4.4 ГГц)");
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Kiaomi", "Kiaomi ProMax", "Kiaomi OS", "2796 x 1290");
        }
    }
}
