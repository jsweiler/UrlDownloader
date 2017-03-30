using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace UrlDownloader
{
    public class Url
    {
        public async Task<string> DownloadStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetAsync(url);
                return await result.Content.ReadAsStringAsync();
            }
        }
    }
}
