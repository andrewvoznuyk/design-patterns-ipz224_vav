using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class MobileApp : IOrder
    {
        public Subscription BuySubscription()
        {
            return new PremiumSubscription(new List<string> { "Detective", "Action film", "War movie", "Drama", "Documentary film", "Zombie movie", "Musical","Postapocalypse" });
        }
    }
}
