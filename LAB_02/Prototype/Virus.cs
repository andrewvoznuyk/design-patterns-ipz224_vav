using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus : IPrototype
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Virus> Children { get; set; }
        public Virus()
        {
            Children = new List<Virus>();
        }
        public Virus(int weight, int age, string name, string type, List<Virus> children)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Type = type;
            Children = children;
        }

        public IPrototype Clone()
        {
            var clonedChildren = new List<Virus>();

            foreach (var child in Children)
            {
                clonedChildren.Add((Virus)child.Clone());
            }

            return new Virus(Weight, Age, Name, Type, clonedChildren);
        }
        public void DisplayInfoConsole(string prefix = "")
        {
            Console.WriteLine($"{prefix}Name: {Name}, Type: {Type}, Weight: {Weight}, Age: {Age}");
            foreach (var child in Children)
            {
                child.DisplayInfoConsole(prefix + "  ");
            }
        }
    }
}
