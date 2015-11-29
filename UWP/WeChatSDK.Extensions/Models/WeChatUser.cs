using Newtonsoft.Json;

namespace WeChatSDK.Extensions.Models
{
    public class WeChatUser
    {
        [JsonProperty("openid")]
        public string OpenId { get; set; }
        [JsonProperty("nickname")]
        public string Nickname { get; set; }
        [JsonProperty("sex")]
        public int Sex { get; set; }
        [JsonProperty("province")]
        public string Province { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("nicountryckname")]
        public string Country { get; set; }
        [JsonProperty("headimgurl")]
        public string Avatar { get; set; }
    }
}
