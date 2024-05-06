using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopClassLibrary
{
    public interface IReport
    {
        void GenerateReport(Warehouse warehouse);
    }
}
