using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public class Euro : IMoney
    {
        public int Fullprice { get; set; }
        public int Partprice { get; set; }

        public Euro(int euros, int eurocent)
        {
            Fullprice = euros;
            Partprice = eurocent;
        }
        public string ShowInfo()
        {
            return $"{Fullprice}.{Partprice} €";
        }
    }
}
