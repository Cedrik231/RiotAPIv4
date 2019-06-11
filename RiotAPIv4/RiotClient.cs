using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPIv4
{
    public class RiotClient
    {

        /// <summary>
        /// Initialize your RiotClient
        /// </summary>
        public RiotClient()
        {
            
        }

        /// <summary>
        /// RiotStaticData with unlimited requests!
        /// </summary>
        /// <param name="version">Your Version</param>
        /// <param name="language">Your Response Language</param>
        /// <returns></returns>
        public RiotStatic StaticClient(string version, Language language)
        {
            return new RiotStatic(version, language);
        }
        /// <summary>
        /// RiotStaticData with unlimited requests. This will automaticly take the newest version.
        /// </summary>        
        /// <param name="language">Your Response Language</param>
        /// <returns></returns>
        public RiotStatic StaticClient(Language language)
        {
            return new RiotStatic(language);
        }        
        public RiotApi ApiClient(string apikey, Regions region)
        {
            return new RiotApi(apikey, region);
        }

    }
}
