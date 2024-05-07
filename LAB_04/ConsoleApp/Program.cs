using AirTrafficControlLibrary;
using CoRClassLibrary;
using StrategyClassLibrary;
using Image = StrategyClassLibrary.Image;
using MementoClassLibrary;
using ObserverClassLibrary;
namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var problemLevel = new FirstLevel();

            problemLevel.SetNext(new SecondLevel())
                .SetNext(new ThirdLevel())
                .SetNext(new FourthLevel()
                .SetNext(new FifthLevel()));

            var problems = new List<string> { "Program failure",
            "Connection problem",
            "Black lines sometimes appear on the device",
            "The device is not responding",
            "Complex problems that need support",
            "Software problem"};


            problems.ForEach(problem =>
            {
                Console.WriteLine(problem);
                problemLevel.Request(new UserRequest { UserProblem = problem });
                Console.WriteLine();

            });
            Console.WriteLine();


            List<Runway> runways = new List<Runway> { new Runway("Kyiv-Paris"), new Runway("Lviv-Brazil") };

            var aircraft1 = new Aircraft("PlaneA");
            var aircraft2 = new Aircraft("PlaneB");
            List<Aircraft> aircrafts = new List<Aircraft> { aircraft1, aircraft2 };

            var commandCentre = new CommandCentre(runways, aircrafts);

            Console.WriteLine("Land and takeoff:");
            commandCentre.AircraftLandingRequests(aircraft1);
            commandCentre.AircraftTakeOffRequests(aircraft1);

            Console.WriteLine("Cant takeoff:");
            commandCentre.AircraftTakeOffRequests(aircraft2);

            Console.WriteLine("Land and takeoff:");
            commandCentre.AircraftLandingRequests(aircraft2);
            commandCentre.AircraftTakeOffRequests(aircraft2);

            Console.WriteLine("Already landed:");
            commandCentre.AircraftLandingRequests(aircraft1);
            commandCentre.AircraftLandingRequests(aircraft1);

            Console.WriteLine("No available runways:");
            commandCentre.AircraftLandingRequests(aircraft2);
            var aircraft3 = new Aircraft("PlaneC");
            commandCentre.AircraftLandingRequests(aircraft3);

            Console.WriteLine();

            var button = new LightElementNode("button", "block", "closing", new List<string> { "btn", "btn-primary" }, new List<LightNode> { new LightTextNode("Click on this button") });

            button.AddEventListener("click", () => Console.WriteLine("Button clicked!"));
            button.TriggerEvent("click");
            button.TriggerEvent("click");
            button.TriggerEvent("click");
            button.TriggerEvent("doubleclick");
            button.TriggerEvent("click");
            button.TriggerEvent("doubleclick");

            button.AddEventListener("doubleclick", () => Console.WriteLine("Button doubleclicked!"));
            button.TriggerEvent("doubleclick");
            button.TriggerEvent("click");
            button.TriggerEvent("move");
            Console.WriteLine();


            IStrategy fileSystemStrategy = new FileSystem();
            Image imageFromFile = new Image(fileSystemStrategy);
            byte[] imageDataFromFile = imageFromFile.LoadImage("C:\\Users\\user\\Desktop\\LAB_Andriy Vozniuk\\LAB_04\\dog.jpg");

            Console.WriteLine("Image from file system loaded. Image data length: " + imageDataFromFile.Length);
            Console.WriteLine("File path: " + "C:\\Users\\user\\Desktop\\LAB_Andriy Vozniuk\\LAB_04\\dog.jpg");

            IStrategy networkStrategy = new Network();
            Image imageFromNetwork = new Image(networkStrategy);
            byte[] imageDataFromNetwork = imageFromNetwork.LoadImage("https://www.akc.org/wp-content/uploads/2017/11/Golden-Retriever-Puppy.jpg");

            Console.WriteLine("Image from network loaded. Image data length: " + imageDataFromNetwork.Length);
            Console.WriteLine("Network resource: " + "https://www.akc.org/wp-content/uploads/2017/11/Golden-Retriever-Puppy.jpg");
            Console.WriteLine();


            TextEditor editor = new TextEditor();

            editor.SetContent("Hello, User!");
            editor.Save();
            Console.WriteLine("Current content: " + editor.GetContent());

            editor.SetContent("Goodbye, User!");
            editor.Save();
            Console.WriteLine("Current content: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("Current content after undo: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("Current content after undo: " + editor.GetContent());

            editor.Undo();
            Console.WriteLine("Reached maximum undo limit");
        }
    }
}
