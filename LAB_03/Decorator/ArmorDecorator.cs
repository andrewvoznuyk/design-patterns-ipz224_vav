namespace Decorator
{
    public class ArmorDecorator : BaseDecorator
    {
        public string Armor { get; set; }
        public ArmorDecorator(IHero hero, string armor) : base(hero)
        {
            Armor = armor;
        }

        public override void Show()
        {
            _hero.Show();
            Console.WriteLine($"Armor: {Armor}");

        }
    }
}
