namespace Builder
{
    public class Hero
    {
        public int Height { get; set; }
        public string Stature { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> Deed { get; set; } = new List<string>();

        public void PrintInfo()
        {
            Console.WriteLine($"Height: {Height}");
            Console.WriteLine($"Build: {Stature}");
            Console.WriteLine($"Hair Color: {HairColor}");
            Console.WriteLine($"Eye Color: {EyeColor}");
            Console.WriteLine($"Clothing: {Clothing}");
            if (Inventory != null)
            {
                Console.WriteLine("Inventory:");
                foreach (var item in Inventory)
                {
                    Console.WriteLine($"-{item}");
                }
            }
            if (Deed != null)
            {
                Console.WriteLine("List:");
                foreach (var item in Deed)
                {
                    Console.WriteLine($"-{item}");
                }
            }
        }
    }
}