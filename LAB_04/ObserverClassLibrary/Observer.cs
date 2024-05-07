namespace ObserverClassLibrary
{
    public class Observer
    {
        private Dictionary<string, List<Action>> eventListeners = new Dictionary<string, List<Action>>();

        public void AddEventListener(string Type, Action listener)
        {
            if (!eventListeners.ContainsKey(Type))
            {
                eventListeners[Type] = new List<Action>();
            }
            eventListeners[Type].Add(listener);
        }

        public void TriggerEvent(string eventType)
        {
            if (eventListeners.ContainsKey(eventType))
            {
                foreach (var listener in eventListeners[eventType])
                {
                    listener();
                }
            }
        }

    }
}
