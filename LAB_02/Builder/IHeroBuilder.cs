using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IHeroBuilder
    {
        IHeroBuilder SetHeight(int height);
        IHeroBuilder SetStature(string stature);
        IHeroBuilder SetHairColor(string hairColor);
        IHeroBuilder SetEyeColor(string eyeColor);
        IHeroBuilder SetClothing(string clothing);
        IHeroBuilder AddToInventory(string item);
        IHeroBuilder AddToDeed(string item);

        Hero Building();
    }
}
