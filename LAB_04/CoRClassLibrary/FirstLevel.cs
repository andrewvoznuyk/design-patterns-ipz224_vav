using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRClassLibrary
{
    public class FirstLevel : BaseHandler
    {
        protected override string Report => "Try downloading the update, if that doesn't work, reboot your device";

        protected override int Level => 1;

        protected override string Problem => "Program failure";

        public override void Request(UserRequest request)
        {
            if (request.UserProblem.Equals(Problem, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine($"Level {Level} support: {Report}");
                return;
            }

            base.Request(request);
        }


    }
}
