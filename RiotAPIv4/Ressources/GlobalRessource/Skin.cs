using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Skin
    {
        [JsonProperty]
        string id;
        [JsonProperty]
        int num;
        [JsonProperty]
        string name;
        [JsonProperty]
        bool chromas;
      
        string championName;

        public Skin(string championName)
        {
            this.championName = championName;           
        }

        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Num
        {
            get
            {
                return num;
            }

            set
            {
                num = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string PathToSplashArt
        {
            get
            {
                return APIConstants.PATHTOSPLASHART + championName + "_" + num + ".jpg";
            }
        }

        public string PathToLoadingScreen
        {
            get
            {
                return APIConstants.PATHTOLOADINGSCREEN + championName + "_" + num + ".jpg";
            }
        }

        public bool Chromas
        {
            get
            {
                return chromas;
            }

            set
            {
                chromas = value;
            }
        }
                   
        public override string ToString()
        {
            return name;
        }
    }
}
