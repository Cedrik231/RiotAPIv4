using System.Net;

namespace RiotAPIv4
{
    public abstract class RiotWeb
    {

        protected WebClient wc = new WebClient();
        
        protected RiotWeb()
        {
            wc.UseDefaultCredentials = true;
            wc.Credentials = wc.Proxy.Credentials;
            wc.Encoding = System.Text.Encoding.UTF8;
        }

    }
}
