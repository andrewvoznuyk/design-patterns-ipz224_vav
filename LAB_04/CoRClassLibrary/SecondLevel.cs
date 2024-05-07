using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRClassLibrary
{
    public class SecondLevel : BaseHandler
    {
        protected override string Report => "Unplug and re-plug the device";

        protected override int Level => 2;

        protected override string Problem => "The device is not responding";

        public override void Request(UserRequest request)
        {
            if (request.UserProblem.Equals(Problem, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"Level {Level} support: {this.Report}");
                return;
            }

            base.Request(request);
        }

    }
}
