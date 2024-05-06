namespace Singleton
{
    public class Authenticator
    {
        private static Authenticator? instance;
        private static readonly object lockObj = new object();

        protected Authenticator() { }

        public static Authenticator Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObj)
                    {
                        if (instance == null)
                        {
                            instance = new Authenticator();
                        }
                    }
                }
                return instance;
            }
        }

    }
}
