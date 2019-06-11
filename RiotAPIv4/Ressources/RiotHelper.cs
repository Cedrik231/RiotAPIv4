using System;
using Newtonsoft.Json.Linq;
using System.Net;

namespace RiotAPIv4
{
    internal static class RiotHelper
    {
        internal static string ConvertLanguage(Language lang)
        {
            switch (lang)
            {
                case Language.German:
                    return "de_DE";
                case Language.English:
                    return "en_US";
                case Language.French:
                    break;
                case Language.Turkey:
                    break;
                case Language.Spanish:
                    break;
                case Language.Korean:
                    break;
                case Language.Poland:
                    break;
                case Language.Chinese:
                    break;
                case Language.Italy:
                    break;
                default:
                    throw new Exception("Language not Implemented Exception");
            }
            return "";           
        }
        internal static string ConvertRegion(Regions region)
        {
            switch (region)
            {
                case Regions.EUW:
                    return "euw1";
                case Regions.NA:
                    return "na1";
                case Regions.EUNE:
                    return "eun1";
                case Regions.KOREA:
                    return "kr";
                case Regions.RUSSIA:
                    return "ru";
                case Regions.TURKEY:
                    return "tr1";
                case Regions.OCEANIEN:
                    return "oc1";
                case Regions.BRAZIL:
                    return "br1";
                default:
                    return null;
            }
        }
        internal static string CurrentVersion()
        {
            return JArray.Parse(new WebClient().DownloadString(APIConstants.VERSIONPATH))[0].ToString();
        }

    }
}
