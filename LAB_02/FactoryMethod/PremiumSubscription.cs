using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription(List<string> channels) : base(500, 36, channels)
        {

        }
    }
}
