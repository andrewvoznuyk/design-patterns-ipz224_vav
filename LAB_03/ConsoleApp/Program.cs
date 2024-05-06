using Adapter;
using Bridge;
using Composite;
using Decorator;
using Lightweight;
using Proxy;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new Logger();

            logger.Log("Console Log message.");
            logger.Error("Console Error message.");
            logger.Warn("Console Warn message.");

            FileWriter fileWriter = new FileWriter("C:\\Users\\user\\Desktop\\LAB_Andriy Vozniuk\\LAB_03\\text.txt");
            FileWriterAdapter fileWriterAdapter = new FileWriterAdapter(fileWriter);
            Console.WriteLine();
            fileWriterAdapter.Log("Log message");
            Console.WriteLine();
            fileWriterAdapter.Error("Error message");
            Console.WriteLine();
            fileWriterAdapter.Warn("Warn message");
            Console.WriteLine();
            IHero warrior = new Warrior("Conan");
            IHero mage = new Mage("Gandalf");
            IHero paladin = new Palladin("Arthur");

            warrior = new ArtifactDecorator(warrior, "Enchanted sword");
            warrior = new ArmorDecorator(warrior, "Heavy armor");
            warrior.Show();
            Console.WriteLine();
            mage = new ArmorDecorator(mage, "Old hat");
            mage = new WeaponDecorator(mage, "Elder stick");
            mage = new WeaponDecorator(mage, "Enchanted stick");

            mage.Show();
            Console.WriteLine();

            paladin = new WeaponDecorator(paladin, "Heavy shield");
            paladin = new ArmorDecorator(paladin, "Light armor");
            paladin = new ArtifactDecorator(paladin, "Restoration Stone");
            paladin.Show();

            Console.WriteLine();
            IShape vectorRenderer = new Vector();
            IShape rasterRenderer = new Raster();

            Shape circle = new Circle(vectorRenderer);
            Shape circle2 = new Circle(rasterRenderer);
            Shape square = new Square(rasterRenderer);
            Shape triangle = new Triangle(vectorRenderer);

            circle.Draw();
            circle2.Draw();
            square.Draw();
            triangle.Draw();

            Console.WriteLine();
            string filePath = "file1.txt";
            File.WriteAllText(filePath, "Andriy Vozniuk IPZ-22-4");

            IProxy proxy = new SmartTextChecker();
            char[][] chars = proxy.ReadText(filePath);
            Console.WriteLine();


            IProxy locker = new SmartTextReaderLocker("file1.jpg");

            Console.WriteLine("Attempting to read file with SmartTextReaderLocker:");
            char[][] content = locker.ReadText(filePath);

            if (content != null)
            {
                Console.WriteLine("Content of the file:");
                foreach (var line in content)
                {
                    Console.WriteLine(string.Join("", line));
                }
            }
            else
            {
                Console.WriteLine("Failed to read file.");
            }
            Console.WriteLine();
            var textNode1 = new LightTextNode("Hello ");
            var textNode2 = new LightTextNode("World");

            var divElement = new Composite.LightElementNode(
                tagName: "div",
                displayType: "block",
                closingType: "double",
                cssClasses: new List<string> { "container" },
                children: new List<LightNode> { textNode1, textNode2 }
            );

            string html = divElement.OuterHTML;
            string node = divElement.InnerHTML;

            Console.WriteLine(html);
            Console.WriteLine(node);
            string Path = "C:\\Users\\user\\Desktop\\LAB_Andriy Vozniuk\\LAB_03\\book.txt";
            string text = HTML_Layout.GetTextFromFile(Path);

            try
            {
                var rootNode2 = HTML_Layout.ConvertTextToHTMLLightweight(text);
                long memoryUsage = CalculateMemory.CalculateSize(rootNode2);
                Console.WriteLine($"Memory Lightweight: {memoryUsage} ");

                var rootNode = HTML_Layout.ConvertTextToHTML(text);
                memoryUsage = CalculateMemory.CalculateSize(rootNode);
                Console.WriteLine($"Memory: {memoryUsage} ");

            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
