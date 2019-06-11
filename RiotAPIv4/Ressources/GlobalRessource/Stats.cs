using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Stats
    {
        [JsonProperty]
        double hp;
        [JsonProperty]
        double hpperlevel;
        [JsonProperty]
        double mp;
        [JsonProperty]
        double mpperlevel;
        [JsonProperty]
        double movespeed;
        [JsonProperty]
        double armor;
        [JsonProperty]
        double armorperlevel;
        [JsonProperty]
        double spellblock;
        [JsonProperty]
        double spellblockperlevel;
        [JsonProperty]
        double attackrange;
        [JsonProperty]
        double hpregen;
        [JsonProperty]
        double hpregenperlevel;
        [JsonProperty]
        double mpregen;
        [JsonProperty]
        double mpregenperlevel;
        [JsonProperty]
        double crit;
        [JsonProperty]
        double critperlevel;
        [JsonProperty]
        double attackdamage;
        [JsonProperty]
        double attackdamageperlevel;
        [JsonProperty]
        double attackspeedoffset;
        [JsonProperty]
        double attackspeedperlevel;

        public double Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public double Hpperlevel
        {
            get
            {
                return hpperlevel;
            }

            set
            {
                hpperlevel = value;
            }
        }

        public double Mp
        {
            get
            {
                return mp;
            }

            set
            {
                mp = value;
            }
        }

        public double Mpperlevel
        {
            get
            {
                return mpperlevel;
            }

            set
            {
                mpperlevel = value;
            }
        }

        public double Movespeed
        {
            get
            {
                return movespeed;
            }

            set
            {
                movespeed = value;
            }
        }

        public double Armor
        {
            get
            {
                return armor;
            }

            set
            {
                armor = value;
            }
        }

        public double Armorperlevel
        {
            get
            {
                return armorperlevel;
            }

            set
            {
                armorperlevel = value;
            }
        }

        public double Spellblock
        {
            get
            {
                return spellblock;
            }

            set
            {
                spellblock = value;
            }
        }

        public double Spellblockperlevel
        {
            get
            {
                return spellblockperlevel;
            }

            set
            {
                spellblockperlevel = value;
            }
        }

        public double Attackrange
        {
            get
            {
                return attackrange;
            }

            set
            {
                attackrange = value;
            }
        }

        public double Hpregen
        {
            get
            {
                return hpregen;
            }

            set
            {
                hpregen = value;
            }
        }

        public double Hpregenperlevel
        {
            get
            {
                return hpregenperlevel;
            }

            set
            {
                hpregenperlevel = value;
            }
        }

        public double Mpregen
        {
            get
            {
                return mpregen;
            }

            set
            {
                mpregen = value;
            }
        }

        public double Mpregenperlevel
        {
            get
            {
                return mpregenperlevel;
            }

            set
            {
                mpregenperlevel = value;
            }
        }

        public double Crit
        {
            get
            {
                return crit;
            }

            set
            {
                crit = value;
            }
        }

        public double Critperlevel
        {
            get
            {
                return critperlevel;
            }

            set
            {
                critperlevel = value;
            }
        }

        public double Attackdamage
        {
            get
            {
                return attackdamage;
            }

            set
            {
                attackdamage = value;
            }
        }

        public double Attackdamageperlevel
        {
            get
            {
                return attackdamageperlevel;
            }

            set
            {
                attackdamageperlevel = value;
            }
        }

        public double Attackspeedoffset
        {
            get
            {
                return attackspeedoffset;
            }

            set
            {
                attackspeedoffset = value;
            }
        }

        public double Attackspeedperlevel
        {
            get
            {
                return attackspeedperlevel;
            }

            set
            {
                attackspeedperlevel = value;
            }
        }

        public override string ToString()
        {
            return hp.ToString();
        }

    }
}
