using System;
using Newtonsoft.Json;

namespace RiotAPIv4
{
    public class Image 
    {
        [JsonProperty]
        string full;
        [JsonProperty]
        string sprite;
        [JsonProperty]
        string group;
        [JsonProperty]
        int x;
        [JsonProperty]
        int y;
        [JsonProperty]
        int w;
        [JsonProperty]
        int h;

        public string Full
        {
            get
            {
                return full;
            }

            set
            {
                full = value;
            }
        }

        public string Sprite
        {
            get
            {
                return sprite;
            }

            set
            {
                sprite = value;
            }
        }

        public string Group
        {
            get
            {
                return group;
            }

            set
            {
                group = value;
            }
        }

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public int W
        {
            get
            {
                return w;
            }

            set
            {
                w = value;
            }
        }

        public int H
        {
            get
            {
                return h;
            }

            set
            {
                h = value;
            }
        }       

        public override string ToString()
        {
            return full;
        }
    }  
}
