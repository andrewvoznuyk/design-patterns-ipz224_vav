namespace Builder
{
    public class HeroBuilder : IHeroBuilder
    {
        protected Hero hero = new Hero();
        public HeroBuilder() 
        {
            hero = new Hero();
        }
        public IHeroBuilder AddToInventory(string item)
        {
            hero.Inventory.Add(item);
             return this;

        }
        public IHeroBuilder SetClothing(string clothing)
        {
           hero.Clothing = clothing;
            return this;
        }

        public IHeroBuilder SetEyeColor(string eyeColor)
        {
           hero.EyeColor = eyeColor;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
           hero.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetHeight(int height)
        {
           hero.Height = height;
            return this;
        }

        public IHeroBuilder SetStature(string stature)
        {
           hero.Stature = stature;
            return this;
        }
        public Hero Building()
        {
            Hero _ = hero;
            hero = new Hero();
            return _;

        }

        public IHeroBuilder AddToDeed(string item)
        {
           hero.Deed.Add(item);
            return this;
        }
    }
}
