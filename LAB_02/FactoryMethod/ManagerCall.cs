using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class ManagerCall : IOrder
    {
        public Subscription BuySubscription()
        {
            return new DomesticSubscription(new List<string> { "Western", "War movie", "Drama", "Documentary film"});
        }
    }
}
