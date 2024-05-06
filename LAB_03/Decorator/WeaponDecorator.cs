using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WeaponDecorator : BaseDecorator
    {
        public string Weapon {  get; set; }
        public WeaponDecorator(IHero hero, string weapon) : base(hero)
        {
            Weapon = weapon;
        }

        public override void Show()
        {
            _hero.Show();
            Console.WriteLine($"Weapon: {Weapon}");

        }
    }
}
