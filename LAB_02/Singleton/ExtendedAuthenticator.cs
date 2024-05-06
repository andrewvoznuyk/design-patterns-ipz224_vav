using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ExtendedAuthenticator : Authenticator
    {
        private ExtendedAuthenticator() : base() { }

        public static Authenticator GetInstance()
        {
            return Instance;
        }

    }
}
