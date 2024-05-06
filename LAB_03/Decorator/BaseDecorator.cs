using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class BaseDecorator : IHero
    {
        protected IHero _hero;
        public BaseDecorator(IHero hero)
        {
            _hero = hero;
        }

        abstract public void Show();
    }
}
