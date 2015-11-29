using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.System.Profile;
using Windows.UI.Xaml.Controls;
using MicroMsg.sdk;
using WeChatSDK.Extensions;
using WeChatSDK.Extensions.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WeChatDemo
{
    public class ShareScene
    {
        public int Scene { get; set; }
        public string Name { get; set; }
    }

    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            WeChatSns.Initialize("[YOUR APP ID]", "[YOUR APP SECRET]", "[YOUR SCOPE]");
        }


        public List<ShareScene> Targets => new List<ShareScene>
        {
            new ShareScene { Scene = SendMessageToWX.Req.WXSceneChooseByUser, Name = "用户自选"},
            new ShareScene { Scene = SendMessageToWX.Req.WXSceneSession, Name = "分享给好友"},
            new ShareScene { Scene = SendMessageToWX.Req.WXSceneTimeline, Name = "分享到朋友圈"},
        };

        public async void ShareText()
        {
            var shareScene = ComboBox.SelectionBoxItem as ShareScene;
            if (shareScene == null)
            {
                return;
            }

            try
            {
                var scene = shareScene.Scene;
                var message = new WXTextMessage
                {
                    Title = "Sharing a text title!",
                    Text = "This is text content",
                    Description = "This is a text message.这是一个文本消息。",
                    ThumbData = null
                };
                SendMessageToWX.Req req = new SendMessageToWX.Req(message, scene);
                IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                var isValid = await api.SendReq(req);
            }
            catch (WXException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public async void ShareImage()
        {
            var shareScene = ComboBox.SelectionBoxItem as ShareScene;
            if (shareScene == null)
            {
                return;
            }
            try
            {
                var scene = shareScene.Scene;
                var file = await Package.Current.InstalledLocation.GetFileAsync("1.png");
                using (var stream = await file.OpenReadAsync())
                {
                    var pic = new byte[stream.Size];
                    await stream.AsStream().ReadAsync(pic, 0, pic.Length);
                    var message = new WXImageMessage
                    {
                        Title = "Sharing a picture!",
                        Description = "This is a image message.这是一个图片消息",
                        ThumbData = pic,
                        ImageUrl = "http://tp3.sinaimg.cn/1882347990/180/5725518284/1"
                    };

                    SendMessageToWX.Req req = new SendMessageToWX.Req(message, scene);
                    IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                    var isValid = await api.SendReq(req);
                }
            }
            catch (WXException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public async void ShareLink()
        {
            var shareScene = ComboBox.SelectionBoxItem as ShareScene;
            if (shareScene == null)
            {
                return;
            }

            try
            {
                var scene = shareScene.Scene;
                var file = await Package.Current.InstalledLocation.GetFileAsync("1.png");
                using (var stream = await file.OpenReadAsync())
                {
                    var pic = new byte[stream.Size];
                    await stream.AsStream().ReadAsync(pic, 0, pic.Length);

                    var message = new WXWebpageMessage
                    {
                        WebpageUrl = "http://www.baidu.com",
                        Title = "Sharing a link!",
                        Description = "This is a link message.这是一个链接消息",
                        ThumbData = pic
                    };
                    SendMessageToWX.Req req = new SendMessageToWX.Req(message, scene);
                    IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                    var isValid = await api.SendReq(req);
                }
            }
            catch (WXException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        public async void SendAuth()
        {
            try
            {
                SendAuth.Req req = new SendAuth.Req(AppSettings.Scope, "test");

                IWXAPI api = WXAPIFactory.CreateWXAPI(AppSettings.AppId);
                var isValid = await api.SendReq(req);
            }
            catch (WXException ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }
    }
}
