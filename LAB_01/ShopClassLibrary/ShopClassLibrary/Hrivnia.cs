using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public class Hrivnia : IMoney
    {
        public int Fullprice { get; set; }
        public int Partprice { get; set; }

        public Hrivnia(int hrivni, int kopeck)
        {
            Fullprice = hrivni;
            Partprice = kopeck;
        }
        public string ShowInfo()
        {
            return $"{Fullprice} грн.{Partprice} копійок";
        }
    }
}
