using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public class Warehouse
    {
        private List<Warehouse> products;

        public Product Product { get; set; }
        public string Unit { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }

        public Warehouse(Product product, string unit, int number, DateTime date)
        {
            if (number < 0)
                throw new ArgumentException("Число не може бути від'ємне");

            Unit = unit;
            Product = product;
            Count = number;
            Date = date;
            products = new List<Warehouse>();
        }
        public Warehouse() { products = new List<Warehouse>(); }
        public void AddProduct(Product product, string unit, int count, DateTime date)
        {
            var existingItem = products.FirstOrDefault(item => item.Product.Name == product.Name);
            if (existingItem != null)
            {
                existingItem.Count += count;
                existingItem.Date = date;
            }
            else
            {
                products.Add(new Warehouse(product, unit, count, date));
            }
        }

        public void RemoveProduct(string itemName, int count)
        {
            var existingItem = products.FirstOrDefault(item => item.Product.Name == itemName);
            if (existingItem != null)
            {
                if (existingItem.Count >= count)
                {
                    existingItem.Count -= count;
                }
                else
                {
                    throw new InvalidOperationException($"Недостатньо {itemName} на складі.");
                }
            }
            else
            {
                throw new InvalidOperationException($"{itemName} немає на складі.");
            }
        }
        public List<Warehouse> GetProducts()
        {
            return products;
        }
        public List<Product> GetProductsByCategory(string category)
        {
            return products.Where(p => p.Product.Category == category)
                           .Select(p => p.Product)
                           .ToList();
        }

    }
}
