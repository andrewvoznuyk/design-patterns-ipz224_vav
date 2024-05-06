using AbstractFactory;
using Builder;
using FactoryMethod;
using Prototype;
using Singleton;

namespace Consoles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IOrder factory = new WebSite();
            Subscription websiteSub = factory.BuySubscription();
            websiteSub.PrintSubConsole();

            factory = new MobileApp();
            Subscription mobileAppSub = factory.BuySubscription();
            mobileAppSub.PrintSubConsole();

            factory = new ManagerCall();
            Subscription managerCallSub = factory.BuySubscription();
            managerCallSub.PrintSubConsole();
            Console.WriteLine();

            Authenticator auth1 = Authenticator.Instance;
            Authenticator auth2 = Authenticator.Instance;
            Authenticator extendedAuth = ExtendedAuthenticator.GetInstance();
            Console.WriteLine($"Comparison of class instances: {auth1 == auth2}");
            Console.WriteLine($"Comparison of class instance and extend class: {extendedAuth == auth1}");
            Console.WriteLine();

            IDevice iProneFactory = new IProneFactory();
            IDevice kiaomiFactory = new KiaomiFactory();
            IDevice balaxyFactory = new BalaxyFactory();
            ShowInfo(iProneFactory);
            ShowInfo(balaxyFactory);
            ShowInfo(kiaomiFactory);
            Console.WriteLine();

            Virus grandpaVirus = new Virus(100, 5, "Grandparent Virus", "Type S", new List<Virus>());
            Virus parentVirus1 = new Virus(80, 3, "Covid-19", "Type A", new List<Virus>());
            Virus parentVirus2 = new Virus(90, 4, "Covid-20", "Type B", new List<Virus>());

            grandpaVirus.Children.Add(parentVirus1);
            grandpaVirus.Children.Add(parentVirus2);

            Virus childVirus1 = new Virus(60, 1, "Covid younger - 19", "Type B", new List<Virus>());
            Virus childVirus2 = new Virus(70, 2, "Covid younger - 20", "Type C", new List<Virus>());

            parentVirus1.Children.Add(childVirus1);
            parentVirus1.Children.Add(childVirus2);
            Virus clonVirus = (Virus)grandpaVirus.Clone();

            Console.WriteLine("Original Virus:");
            grandpaVirus.DisplayInfoConsole();
            Console.WriteLine("Clone Virus:");
            clonVirus.DisplayInfoConsole();
            Console.WriteLine();

            var heroBuild = new HeroBuilder();
            var enemyBuild = new EnemyBuilder();

            var heroDirector = new HeroDirector(heroBuild);
            var enemyDirector = new HeroDirector(enemyBuild);

            var hero = heroDirector.ConstructCharacter(170, "Sports", "Black", "Green", "Armor", new List<string> { "Axe", "Potion", "Bow" }, new List<string> { "Saved the princess", "Killed the dragon", "Defeated the demon king" });
            var enemy = enemyDirector.ConstructCharacter(180, "Strong", "Bald", "Black", "Kilt", new List<string> { "Claymore", "Magic shield" }, new List<string> { "Burned down the village", "Captured the king" });



            Console.WriteLine("Hero:");
            hero.PrintInfo();


            Console.WriteLine("\nEnemy:");
            enemy.PrintInfo();

            Console.ReadLine();

        }
        private static void ShowInfo(IDevice Factory)
        {
            Console.WriteLine(Factory.CreateEBook().ShowInfo());
            Console.WriteLine(Factory.CreateSmartphone().ShowInfo());
            Console.WriteLine(Factory.CreateLaptop().ShowInfo());
            Console.WriteLine(Factory.CreateNetbook().ShowInfo());
            Console.WriteLine();
        }

    }
}
