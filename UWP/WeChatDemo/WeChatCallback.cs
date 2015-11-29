using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using MicroMsg.sdk;
using WeChatSDK.Extensions;

namespace WeChatDemo
{
    public class WeChatCallback : WXEntryBasePage
    {
        public override async void OnSendMessageToWXResponse(SendMessageToWX.Resp response)
        {
            base.OnSendMessageToWXResponse(response);
            var dialog = new MessageDialog(response.ErrCode == 0 ? "分享成功": "分享失败");
            await dialog.ShowAsync();
        }

        public override async void OnSendAuthResponse(SendAuth.Resp response)
        {
            base.OnSendAuthResponse(response);
            if (response.ErrCode == 0)
            {
                if (!string.IsNullOrEmpty(response.Code))
                {
                    var token = await WeChatSns.GetAccessTokenAsync(response.Code);
                    if (token != null)
                    {
                        var user = await WeChatSns.GetUserInfoAsync(token.AccessToken, token.OpenId);

                        var dialog = new MessageDialog($"name:{user.Nickname}\r\nopenid:{user.OpenId}","授权成功");
                        await dialog.ShowAsync();
                    }
                }
            }
            else
            {
                var dialog = new MessageDialog("授权失败");
                await dialog.ShowAsync();
            }
        }
    }
}
