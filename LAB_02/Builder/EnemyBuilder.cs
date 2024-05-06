using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : IHeroBuilder
    {
        protected Hero enemy = new Hero();
        public IHeroBuilder AddToInventory(string item)
        {
           enemy.Inventory.Add(item);
            return this;

        }

        public Hero Building()
        {
            Hero _ = enemy;
            enemy = new Hero();
            return _;

        }

        public IHeroBuilder SetClothing(string clothing)
        {
           enemy.Clothing = clothing;
            return this;
        }

        public IHeroBuilder SetEyeColor(string eyeColor)
        {
           enemy.EyeColor = eyeColor;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
           enemy.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetHeight(int height)
        {
           enemy.Height = height;
            return this;
        }

        public IHeroBuilder SetStature(string stature)
        {
           enemy.Stature = stature;
            return this;
        }

        public IHeroBuilder AddToDeed(string item)
        {
           enemy.Deed.Add(item);
            return this;

        }
    }
}
