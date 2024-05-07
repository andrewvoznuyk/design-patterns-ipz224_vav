namespace AirTrafficControlLibrary
{
    public class CommandCentre
    {
        private readonly List<Runway> _runways;
        private readonly List<Aircraft> _aircrafts;

        public CommandCentre(List<Runway> runways, List<Aircraft> aircrafts)
        {
            _runways = runways ?? throw new ArgumentNullException(nameof(runways));
            _aircrafts = aircrafts ?? throw new ArgumentNullException(nameof(aircrafts));
        }

        public void AircraftLandingRequests(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} requests landing.");

            if (_runways.Any(r => r.IsBusy == aircraft))
            {
                Print.ShowError($"Aircraft {aircraft.Name} already landed on Runway({aircraft.CurrentRunway!.Id})   {aircraft.CurrentRunway.Way}\n");
                return;
            }

            foreach (var runway in _runways)
            {
                if (runway.IsAvailable())
                {
                    Print.ShowSuccess($"Runway({runway.Id})  {runway.Way} is free. Aircraft {aircraft.Name} is landing.\n");
                    runway.IsBusy = aircraft;
                    aircraft.CurrentRunway = runway;
                    aircraft.Land();
                    return;
                }
            }

            Print.ShowError($"All runways are busy. Aircraft {aircraft.Name} cannot land.");
        }

        public void AircraftTakeOffRequests(Aircraft aircraft)
        {
            Console.WriteLine($"Aircraft {aircraft.Name} requests takeoff.");

            var runway = aircraft.CurrentRunway;
            if (runway != null && runway.IsBusy == aircraft)
            {
                Print.ShowSuccess($"Aircraft {aircraft.Name} is taking off from Runway({runway.Id})   {runway.Way}.");
                runway.IsBusy = null;
                aircraft.TakeOff();
            }
            else
            {
                Print.ShowError($"Aircraft {aircraft.Name} is not on any runway. Cannot takeoff.");
            }
            Console.WriteLine();
        }
    }
}
