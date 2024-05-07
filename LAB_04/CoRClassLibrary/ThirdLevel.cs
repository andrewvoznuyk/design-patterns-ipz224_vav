using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRClassLibrary
{
    public class ThirdLevel : BaseHandler
    {
        protected override string Report => "Restart your device";

        protected override int Level => 3;

        protected override string Problem => "Connection problem";

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
