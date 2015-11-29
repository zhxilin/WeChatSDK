using System;
using System.IO;
using System.Threading.Tasks;
using Windows.Web.Http;
using Newtonsoft.Json;

namespace WeChatSDK.Extensions.Services
{
    public static class HttpService
    {
        public async static Task<T> GetAsync<T>(string url)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(new Uri(url));
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    if (!string.IsNullOrEmpty(json))
                    {
                        var serializer = new JsonSerializer
                        {
                            NullValueHandling = NullValueHandling.Ignore,
                            StringEscapeHandling = StringEscapeHandling.EscapeHtml
                        };
                        using (var sr = new StringReader(json))
                        {
                            using (var reader = new JsonTextReader(sr))
                            {
                                var data = serializer.Deserialize<T>(reader);
                                if (data != null)
                                {
                                    return data;
                                }
                            }
                        }
                    }
                }
            }
            return default(T);
        }
    }
}
