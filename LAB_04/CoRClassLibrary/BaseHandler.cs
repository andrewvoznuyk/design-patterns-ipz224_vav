using System.Reflection.Metadata;

namespace CoRClassLibrary
{
    public abstract class BaseHandler : IHandler
    {
        protected abstract string Report { get; }
        protected abstract int Level { get; }
        protected abstract string Problem { get; }

        private BaseHandler? baseHandler;

        public BaseHandler SetNext(BaseHandler basehandler)
        {
            if (baseHandler == null)
            {
                baseHandler = basehandler;
            }
            else
            {
                BaseHandler lastHandler = baseHandler;
                while (lastHandler.baseHandler != null)
                {
                    lastHandler = lastHandler.baseHandler;
                }
                lastHandler.baseHandler = basehandler;
            }
            return this;
        }


        public virtual void Request(UserRequest request)
        {
            if (baseHandler == null)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("There is no support for this question!");
                Console.ResetColor();
                return;
            }
            else
            {
                baseHandler.Request(request);
            }
        }

    }
}
