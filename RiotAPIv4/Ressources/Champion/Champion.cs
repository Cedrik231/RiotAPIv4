using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Champion
    {

        #region Private

        [JsonProperty]
        string id;
        [JsonProperty]
        string key;
        [JsonProperty]
        string name;
        [JsonProperty]
        string title;
        [JsonProperty]
        string lore;
        [JsonProperty]
        string blurb;
        [JsonProperty]
        string[] allytips;
        [JsonProperty]
        string[] enemytips;
        [JsonProperty]
        string[] tags;
        [JsonProperty]
        string partype;
        [JsonProperty]
        Spell passive;
        [JsonProperty]
        Spell[] spells;
        [JsonProperty]
        Info info;
        [JsonProperty]
        Stats stats;
        [JsonProperty]
        Image image;
        [JsonProperty]
        Skin[] skins;
        string version;

        #endregion

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

        public string Key
        {
            get
            {
                return key;
            }

            set
            {
                key = value;
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

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                title = value;
            }
        }

        public string Lore
        {
            get
            {
                return lore;
            }

            set
            {
                lore = value;
            }
        }

        public string Blurb
        {
            get
            {
                return blurb;
            }

            set
            {
                blurb = value;
            }
        }

        public string[] Allytips
        {
            get
            {
                return allytips;
            }

            set
            {
                allytips = value;
            }
        }

        public string[] Enemytips
        {
            get
            {
                return enemytips;
            }

            set
            {
                enemytips = value;
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

        public string Partype
        {
            get
            {
                return partype;
            }

            set
            {
                partype = value;
            }
        }

        public Spell Passive
        {
            get
            {
                passive.Version = version;
                return passive;
            }

            set
            {
                passive = value;
            }
        }

        public Spell[] Spells
        {
            get
            {
                foreach (var item in spells)
                {
                    item.Version = version;
                }
                return spells;
            }

            set
            {
                spells = value;
            }
        }

        public Info Info
        {
            get
            {
                return info;
            }

            set
            {
                info = value;
            }
        }

        public Stats Stats
        {
            get
            {
                return stats;
            }

            set
            {
                stats = value;
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

        public Skin[] Skins
        {
            get
            {
                Skin[] newSkins = new Skin[skins.Length];
                int c = 0;
                foreach (var item in skins)
                {
                    Skin sk = new Skin(name);
                    sk.Chromas = item.Chromas;
                    sk.Id = item.Id;
                    sk.Name = item.Name;
                    sk.Num = item.Num;
                    newSkins[c] = sk;
                    c++;
                }
                return newSkins;
            }

            set
            {
                skins = value;
            }
        }

        public string Version
        {
            get { return version; }set { version = value; }
        }

        public string PathToChampionSquare
        {
            get { return "http://ddragon.leagueoflegends.com/cdn/"+version+"/img/champion/" + image.Full; }
        }

        public Champion()
        {

        }

        public override string ToString()
        {
            return Name + " " + Title;
        }

    }
}
