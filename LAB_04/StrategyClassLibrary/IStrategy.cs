using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public interface IStrategy
    {
        byte[] LoadImage(string href);
    }
}
