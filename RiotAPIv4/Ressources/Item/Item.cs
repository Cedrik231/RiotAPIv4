using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Item
    {
        [JsonProperty]
        string name;
        [JsonProperty]
        string description;
        [JsonProperty]
        string colloq;
        [JsonProperty]
        string plaintext;
        [JsonProperty]
        int[] into;
        [JsonProperty]
        Image image;
        [JsonProperty]
        Gold gold;
        [JsonProperty]
        string[] tags;

        string version;
        
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

        public string Colloq
        {
            get
            {
                return colloq;
            }

            set
            {
                colloq = value;
            }
        }

        public string Plaintext
        {
            get
            {
                return plaintext;
            }

            set
            {
                plaintext = value;
            }
        }

        public int[] Into
        {
            get
            {
                return into;
            }

            set
            {
                into = value;
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

        public Gold Gold
        {
            get
            {
                return gold;
            }

            set
            {
                gold = value;
            }
        }

        public string[] Tags
        {
            get
            {
                return tags;
            }

            set
            {
                tags = value;
            }
        }

        public string Version
        {
            get
            {
                return version;
            }

            set
            {
                version = value;
            }
        }

        public string PathToImage
        {
            get { return "http://ddragon.leagueoflegends.com/cdn/" + version + "/img/item/" + image.Full; }
        }



        //Maps


        public override string ToString()
        {
            return name;
        }
        public Item()
        {

        }
    }
}
