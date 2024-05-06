
namespace FactoryMethod
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription(List<string> channels) : base(100, 6, channels)
        {

        }
    }

}
