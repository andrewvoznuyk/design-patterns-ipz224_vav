using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Subscription
    {
        public double MonthlyPay { get; protected set; }
        public int MinSubPeriod { get; protected set; }
        public List<string> Channels { get; protected set; }

        public Subscription(double monthlyPay, int minSubPeriod, List<string> channels)
        {
            MonthlyPay = monthlyPay;
            MinSubPeriod = minSubPeriod;
            Channels = channels;
        }
        public virtual void PrintSubConsole()
        {
            Console.WriteLine($"Subscription Type: {GetType().Name}");
            Console.WriteLine($"Monthly Pay: ${MonthlyPay}");
            Console.WriteLine($"Minimum Subscription Period: {MinSubPeriod} months");
            Console.WriteLine($"Included Channels: {string.Join(", ", Channels)} \n");
        }

    }
}
