using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using RiotAPIv4;

namespace RiotAPIv4Test
{
    static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            RiotClient rc = new RiotClient();

            

            var qwe = rc.ApiClient("RGAPI-be4b3790-fe62-4b9a-9dc0-5fa157f6b619", Regions.EUW);


            var match = qwe.GetMatchById("4053846627");


        }
    }
}
