using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class WebSite : IOrder
    {
        public Subscription BuySubscription()
        {
            return new EducationalSubscription(new List<string> { "Detective", "Action film", "War movie", "Zombie movie" });
        }
    }
}
