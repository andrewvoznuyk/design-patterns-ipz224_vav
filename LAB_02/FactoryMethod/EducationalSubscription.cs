using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription(List<string> channels) : base(50, 6, channels)
        {

        }
    }
}
