using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public class ConsoleReport : IReport
    {
        public void GenerateReport(Warehouse warehouse)
        {
            if (warehouse == null) throw new ArgumentNullException(nameof(warehouse), "Склад не може бути null");

            var inventory = warehouse.GetProducts();
            foreach (var product in inventory)
            {
                Console.WriteLine($"Товар: {product.Product.Name}, Ціна: {product.Product.Price.ShowInfo()}, К-сть: {product.Count}, Дата: {product.Date}");
            }
        }
    }
}
