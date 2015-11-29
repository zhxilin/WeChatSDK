using System;
using System.Threading.Tasks;
using WeChatSDK.Extensions.Models;
using WeChatSDK.Extensions.Services;

namespace WeChatSDK.Extensions
{
    public static class WeChatSns
    {
        public static void Initialize(string appid, string appsecret, string scope = null)
        {
            AppSettings.AppId = appid;
            AppSettings.AppSecret = appsecret;
            AppSettings.Scope = scope;
        }


        public async static Task<WeChatToken> GetAccessTokenAsync(string code)
        {
            try
            {
                if (string.IsNullOrEmpty(code))
                {
                    return null;
                }
                var url = $"https://{AppSettings.WeChatHost}/sns/oauth2/access_token?appid={AppSettings.AppId}&secret={AppSettings.AppSecret}&grant_type=authorization_code&code={code}";
                var token = await HttpService.GetAsync<WeChatToken>(url);
                return token;
            }
            catch (Exception ex)
            {
                // ignored
            }
            return null;
        }

        public async static Task<WeChatUser> GetUserInfoAsync(string token, string openid)
        {
            try
            {
                if (string.IsNullOrEmpty(token) || string.IsNullOrEmpty(openid))
                {
                    return null;
                }
                var url = $"https://{AppSettings.WeChatHost}/sns/userinfo?access_token={token}&openid={openid}";
                var user = await HttpService.GetAsync<WeChatUser>(url);
                return user;
            }
            catch (Exception)
            {
                // ignored
            }
            return null;
        }
    }
}
