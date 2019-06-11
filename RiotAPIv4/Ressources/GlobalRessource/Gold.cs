using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Gold
    {
        [JsonProperty(PropertyName = "base")]
        int baseGold;
        [JsonProperty]
        bool purchasable;
        [JsonProperty]
        int toal;
        [JsonProperty]
        int sell;

        public int BaseGold
        {
            get
            {
                return baseGold;
            }

            set
            {
                baseGold = value;
            }
        }

        public bool Purchasable
        {
            get
            {
                return purchasable;
            }

            set
            {
                purchasable = value;
            }
        }

        public int Toal
        {
            get
            {
                return toal;
            }

            set
            {
                toal = value;
            }
        }

        public int Sell
        {
            get
            {
                return sell;
            }

            set
            {
                sell = value;
            }
        }

        public override string ToString()
        {
            return baseGold.ToString();
        }
    }
}
