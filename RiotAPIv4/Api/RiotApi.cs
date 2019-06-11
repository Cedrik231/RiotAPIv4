using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace RiotAPIv4
{
    /// <summary>
    /// API-Connection to your given Region
    /// </summary>
    public class RiotApi : RiotWeb
    {

        string apikey;
        string region;

        /// <summary>
        /// Initialize your API - Region
        /// </summary>
        /// <param name="apikey"></param>
        /// <param name="region"></param>
        public RiotApi(string apikey, Regions region)
        {
            this.apikey = apikey;
            this.region = RiotHelper.ConvertRegion(region);
        }

        #region Matches

        

        public Match GetMatchById(string matchId)
        {           
            try
            {
                JObject match = JObject.Parse(wc.DownloadString("https://"+region+".api.riotgames.com/lol/match/v4/matches/"+matchId+"?api_key=" + apikey));
                var match1 = JsonConvert.DeserializeObject<Match>(match.ToString());
                

            }
            catch(WebException exception)
            {
                var responseStream = ((HttpWebResponse)exception.Response).StatusDescription;
                if (responseStream == "Forbidden")
                    throw new Exceptions.APIKeyNotValidException(apikey);              
                throw new Exceptions.MatchIDNotFoundException(matchId, region);
            }
            catch (Exception er)
            {
                throw new Exception("Unknwon error was thrown with the message :" + er.Message);
            }
            return null;
        }

        #endregion


    }
}
