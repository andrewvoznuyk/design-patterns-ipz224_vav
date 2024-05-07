namespace AirTrafficControlLibrary
{
    public class Aircraft
    {
        public string Name;
        public Runway? CurrentRunway { get; set; }
        public bool IsTakingOff { get; private set; }

        public Aircraft(string name)
        {
            Name = name;
        }
        public void Land()
        {
            this.IsTakingOff = false;
            Console.WriteLine($"Aircraft {Name} has landed.");
        }

        public void TakeOff()
        {
            this.IsTakingOff = true;
            Console.WriteLine($"Aircraft {Name} has taken off.");
        }
    }

}
