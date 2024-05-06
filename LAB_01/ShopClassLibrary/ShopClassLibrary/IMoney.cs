using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public interface IMoney
    {
        public int Fullprice { get; set; }
        public int Partprice { get; set; }
        string ShowInfo();
    }
}
