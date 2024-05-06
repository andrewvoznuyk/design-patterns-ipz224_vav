using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public class Product : IAmount
    {
        public string Name { get; set; }
        public IMoney Price { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }


        public Product(string name, IMoney money, int count, string category)
        {
            Name = name;
            Price = money;
            Count = count;
            Category = category;
        }


        public void DecreasePrice(IMoney amount)
        {
            if (amount.Fullprice <= 0)
            {
                Console.WriteLine("Знижка не має бути не від'ємною.");
            }
            else if (amount.Fullprice >= Price.Fullprice)
            {
                Console.WriteLine("Знижка має бути меншою за ціну.");
            }
            else
            {
                Price.Fullprice -= amount.Fullprice;
                Console.WriteLine($"Ціна товару {Name} зменшилася на {amount.Fullprice}. Нова ціна: {Price.Fullprice}");
            }
        }
    }
}
