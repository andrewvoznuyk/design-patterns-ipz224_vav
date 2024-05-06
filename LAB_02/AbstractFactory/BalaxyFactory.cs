namespace AbstractFactory
{
    public class BalaxyFactory : IDevice
    {
        public EBook CreateEBook()
        {
            return new EBook("Balaxy", 256, "3000 x 1500");
        }

        public Laptop CreateLaptop()
        {
            return new Laptop("Balaxy", 4, 2000, "SSD", "AMD", "Чотириядерний AMD Ryzen 3 5300U (2.6 - 3.8 ГГц)");
        }

        public Netbook CreateNetbook()
        {
            return new Netbook("Balaxy", 4, 256, "HHD", "Чотириядерний AMD Ryzen 3 5300U (2.6 - 3.8 ГГц)");
        }

        public Smartphone CreateSmartphone()
        {
            return new Smartphone("Balaxy", "Balaxy ProMax", "Balaxy OS", "2796 x 1290");
        }
    }
}
