using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotAPIv4.Exceptions
{



    [Serializable]
    public class ChampionNotFoundException : Exception
    {
        public ChampionNotFoundException(string champion, string version) : base("The Champion " + champion + " was not found in the RiotAPI, check your current Version (" + version + ",) because maybe your champ does not exist in this version!") { }
    }


    [Serializable]
    public class MatchIDNotFoundException : Exception
    {        
        public MatchIDNotFoundException(string id, string region) : base("The MatchID :"+id + " was not found in the region :" + region + ". Please Check your Input!") { }        
    }


    [Serializable]
    public class APIKeyNotValidException : Exception
    {        
        public APIKeyNotValidException(string apikey) : base("The given API-Key :" + apikey + " is not valid or it timed out!") { }      
    }

}
