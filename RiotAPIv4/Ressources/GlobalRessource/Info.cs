using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Info
    {
        [JsonProperty]
        int attack;
        [JsonProperty]
        int defense;
        [JsonProperty]
        int magic;
        [JsonProperty]
        int difficulty;

        public int Attack
        {
            get
            {
                return attack;
            }

            set
            {
                attack = value;
            }
        }

        public int Defense
        {
            get
            {
                return defense;
            }

            set
            {
                defense = value;
            }
        }

        public int Magic
        {
            get
            {
                return magic;
            }

            set
            {
                magic = value;
            }
        }

        public int Difficulty
        {
            get
            {
                return difficulty;
            }

            set
            {
                difficulty = value;
            }
        }
        public override string ToString()
        {
            return attack.ToString();
        }
    }
}
