using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StrategyClassLibrary
{
    public class Network : IStrategy
    {
        public byte[] LoadImage(string href)
        {

            using (var webClient = new WebClient())
            {
                return webClient.DownloadData(href);
            }
        }

    }
}
