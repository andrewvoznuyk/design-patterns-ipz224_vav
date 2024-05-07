namespace AirTrafficControlLibrary
{
    public class Runway
    {
        public readonly Guid Id = Guid.NewGuid();
        public Aircraft IsBusy;
        public string Way { get; set; }
        public Runway(string Way)
        {
            this.Way = Way;
        }

        public bool IsAvailable()
        {
            return IsBusy == null;
        }
    }

}
