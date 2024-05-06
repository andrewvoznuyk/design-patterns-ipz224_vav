using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class HeroDirector
    {
        private readonly IHeroBuilder _builder;

        public HeroDirector(IHeroBuilder builder)
        {
            _builder = builder;
        }

        public Hero ConstructCharacter(int height, string stature, string hairColor, string eyeColor, string clothing, List<string> inventory,List<string> deed)
        {
            var builder = _builder
                .SetHeight(height)
                .SetStature(stature)
                .SetHairColor(hairColor)
                .SetEyeColor(eyeColor)
                .SetClothing(clothing);

            foreach (var item in inventory)
            {
                builder = builder.AddToInventory(item);
            }
            foreach (var item in deed)
            {
                builder = builder.AddToDeed(item);
            }


            return builder.Building();
        }
    }
}
