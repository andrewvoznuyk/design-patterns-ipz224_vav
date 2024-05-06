using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Hero : IHero
    {
        public string Name { get; set; }
        protected List<IHero> Inventory { get; set; }
        public Hero(string name)
        {
            Name = name;
            Inventory = new List<IHero>();
        }

        public void AddToInventory(IHero item)
        {
            Inventory.Add(item);
        }

       
        public virtual void Show()
        {
            Console.WriteLine($"Name: {Name}");
        }
    }
}
