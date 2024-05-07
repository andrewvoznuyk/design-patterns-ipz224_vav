using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRClassLibrary
{
    public class FourthLevel : BaseHandler
    {
        protected override string Report => "Loose or poor connection within internal components could cause a phone to show you black lines on the screen";

        protected override int Level => 4;

        protected override string Problem => "Black lines sometimes appear on the device";

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
