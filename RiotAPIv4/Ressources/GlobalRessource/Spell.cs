using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Spell
    {
        [JsonProperty]
        string id;
        [JsonProperty]
        string name;
        [JsonProperty]
        string description;
        [JsonProperty]
        string tooltip;
        [JsonProperty]
        int maxrank;
        [JsonProperty]
        double[] cooldown;
        [JsonProperty]
        string cooldownBurn;
        [JsonProperty]
        int[] cost;
        [JsonProperty]
        string costBurn;
        [JsonProperty]
        string[] effectBurn;
        [JsonProperty]
        string costType;
        [JsonProperty]
        string maxammo;
        [JsonProperty]
        int[] range;
        [JsonProperty]
        string rangeBurn;
        [JsonProperty]
        Image image;
        [JsonProperty]
        string resource;

        string version;

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

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string Tooltip
        {
            get
            {
                return tooltip;
            }

            set
            {
                tooltip = value;
            }
        }

        public int Maxrank
        {
            get
            {
                return maxrank;
            }

            set
            {
                maxrank = value;
            }
        }

        public double[] Cooldown
        {
            get
            {
                return cooldown;
            }

            set
            {
                cooldown = value;
            }
        }

        public string CooldownBurn
        {
            get
            {
                return cooldownBurn;
            }

            set
            {
                cooldownBurn = value;
            }
        }

        public int[] Cost
        {
            get
            {
                return cost;
            }

            set
            {
                cost = value;
            }
        }

        public string CostBurn
        {
            get
            {
                return costBurn;
            }

            set
            {
                costBurn = value;
            }
        }

        public string[] EffectBurn
        {
            get
            {
                return effectBurn;
            }

            set
            {
                effectBurn = value;
            }
        }

        public string CostType
        {
            get
            {
                return costType;
            }

            set
            {
                costType = value;
            }
        }

        public string Maxammo
        {
            get
            {
                return maxammo;
            }

            set
            {
                maxammo = value;
            }
        }

        public int[] Range
        {
            get
            {
                return range;
            }

            set
            {
                range = value;
            }
        }

        public string RangeBurn
        {
            get
            {
                return rangeBurn;
            }

            set
            {
                rangeBurn = value;
            }
        }

        public Image Image
        {
            get
            {
                return image;
            }

            set
            {
                image = value;
            }
        }

        public string Resource
        {
            get
            {
                return resource;
            }

            set
            {
                resource = value;
            }
        }

        public string Version
        {
            get { return version;  }
            set { version = value; }
        }

        public string PathToImage
        {                       
            get {
                string passive = (cooldown == null) ? "passive" : "spell";

                return "http://ddragon.leagueoflegends.com/cdn/" + version + "/img/"+passive+"/" + image.Full;
            }
        }

        public override string ToString()
        {
            return id;
        }
    }
}
