using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PhotoStock.DataAccess
{
    static class ReadJson<T> where T : class
    {
        public static List<T> GetObjects(string url)
        {
            List<T> listAll = new List<T>();
            using (var client = new WebClient())
            {
                client.Proxy = null;
                //client.Headers[HttpRequestHeader.UserAgent] = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/535.2 (KHTML, like Gecko) Chrome/15.0.874.121 Safari/535.2";
                var jsonstring = client.DownloadString(url);
                listAll = JsonConvert.DeserializeObject<List<T>>(jsonstring);
            }
            return listAll;
        }
    }
}
