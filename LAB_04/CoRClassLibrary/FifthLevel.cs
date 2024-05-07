using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRClassLibrary
{
    public class FifthLevel : BaseHandler
    {
        protected override string Report => "Drug use, mental health problems, homelessness, criminal behaviour, sexuality issues, physical or intellectual disability, behavioural problems, child abuse.";

        protected override int Level => 5;

        protected override string Problem => "Complex problems that need support";

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
