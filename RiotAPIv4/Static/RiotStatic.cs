using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace RiotAPIv4
{
    public class RiotStatic : RiotWeb
    {
        string version;
        string language;

        #region cTor
        public RiotStatic(string version, Language language)
        {
            this.version = version;
            this.language = RiotHelper.ConvertLanguage(language);
        }
        public RiotStatic(Language language)
        {
            this.version = RiotHelper.CurrentVersion();
            this.language = RiotHelper.ConvertLanguage(language);
        }
        #endregion

        #region Champion
        /// <summary>
        /// Get your Champion by Name
        /// </summary>
        /// <param name="name">The champion name</param>
        /// <returns></returns>
        public Champion GetChampionByName(string name)
        {
            try
            {
                var rawString = JObject.Parse(wc.DownloadString("http://ddragon.leagueoflegends.com/cdn/" + version + "/data/" + language + "/champion/" + name + ".json")).SelectToken("data." + name).ToString();
                Champion ret = JsonConvert.DeserializeObject<Champion>(rawString);
                ret.Version = version;
                return ret;
            }
            catch
            {
                throw new Exceptions.ChampionNotFoundException(name, version);
            }
        }
        public async Task<Champion> GetChampionByNameAsync(string name)
        {
            var result = Task.Run(() =>
            {
                return GetChampionByName(name);
            });
            var z = await result;
            return z;
        }
        /// <summary>
        /// Returns all Champions in your given Version
        /// </summary>
        /// <returns></returns>
        public Champion[] GetAllChampions()
        {
            var champs = (JObject)JObject.Parse(wc.DownloadString("http://ddragon.leagueoflegends.com/cdn/" + version + "/data/" + language + "/champion.json")).SelectToken("data");
            Champion[] champions = new Champion[champs.Count];
            int counter = 0;
            foreach (var item in champs)
            {
                try
                {
                    champions[counter] = GetChampionByName(item.Key);
                    counter++;
                }
                catch { }
            }
            return champions;
        }
        public async Task<Champion[]> GetAllChampionsAsync()
        {
            var result = Task.Run(() =>
            {
                var result1 = GetAllChampions();
                return result1;
            });
            var z = await result;
            return z;
        }
        #endregion

        #region Item
        /// <summary>
        /// Get an Item by ID
        /// </summary>
        /// <param name="id">The item id</param>
        /// <returns></returns>
        public Item GetItemById(string id)
        {
            var items = (JObject)JObject.Parse(wc.DownloadString("http://ddragon.leagueoflegends.com/cdn/" + version + "/data/" + language + "/item.json")).SelectToken("data");
            foreach (var item in items)
            {
                if (item.Key == id)
                {
                    Item re = JsonConvert.DeserializeObject<Item>(item.Value.ToString());
                    re.Version = version;
                    return re;
                }
            }
            throw new System.Exception(id + " ItemID was not found, make sure your itemId exists in the current version! (Version : " + version);
        }
        public Item GetItemById(int id)
        {
            return GetItemById(id.ToString());
        }
        public async Task<Item> GetItemByIdAsync(string id)
        {
            var result = Task.Run(() =>
            {
                return GetItemById(id);
            });
            var z = await result;
            return z;
        }
        public async Task<Item> GetItemByIdAsync(int id)
        {
            return await GetItemByIdAsync(id.ToString());
        }
        /// <summary>
        /// Get All current items in the version
        /// </summary>
        /// <returns></returns>
        public Item[] GetAllItems()
        {
            var items = (JObject)JObject.Parse(wc.DownloadString("http://ddragon.leagueoflegends.com/cdn/" + version + "/data/" + language + "/item.json")).SelectToken("data");
            var i = 0;
            Item[] retu = new Item[items.Count];
            foreach (var item in items)
            {
                retu[i] = GetItemById(item.Key);
                i++;
            }
            return retu;
        }
        public async Task<Item[]> GetAllItemsAsync()
        {
            var result = Task.Run(() =>
            {
                return GetAllItems();
            });
            var z = await result;
            return z;
        }


        #endregion

    }
}
