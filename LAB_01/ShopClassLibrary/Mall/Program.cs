using ShopClassLibrary;
using System.Drawing;
using System.Text;

namespace Mall
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Warehouse warehouse = new Warehouse();
            List<Product> products = new List<Product>();

            Product product1 = new Product("Пилесос", new Dolar(10, 97), 10, "Техніка");
            Product product2 = new Product("Телефон", new Hrivnia(320, 97), 15, "Техніка");
            Product product3 = new Product("Ноутбук Lenovo IdeaPad Gaming 3 15ACH6", new Euro(100, 0), 5, "Ноутбук");
            Console.WriteLine("Усі продукти:");
            Console.WriteLine($"Пилесос - Техніка  - {product1.Price.ShowInfo()}");
            Console.WriteLine($"Телефон - Техніка  - {product2.Price.ShowInfo()}");
            Console.WriteLine($"Ноутбук Lenovo IdeaPad Gaming 3 15ACH6 - Ноутбук  - {product3.Price.ShowInfo()}");


            warehouse.AddProduct(product1, "кг", product1.Count, DateTime.Now);
            warehouse.AddProduct(product2, "кг", product2.Count, DateTime.Now);
            Console.WriteLine();
            Console.WriteLine("Знижка на товар Пилесос");
            product1.DecreasePrice(new Dolar(5, 0));
            warehouse.RemoveProduct("Пилесос", 5);

            Console.WriteLine();
            Console.WriteLine("Усі продукти на складі:");
            ConsoleReport consoleReport = new ConsoleReport();
            consoleReport.GenerateReport(warehouse);
            Console.WriteLine();
            Console.WriteLine("Виведення товарів по категорії:");
            List<Product> productsByCategory = warehouse.GetProductsByCategory("Техніка");
            foreach (var product in productsByCategory)
            {
                Console.WriteLine($"{product.Name} - {product.Count} шт {product.Price.ShowInfo()}");
            }
        }
    }
}
