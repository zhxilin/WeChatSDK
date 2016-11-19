using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MicroMsg.sdk;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace WeChatDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private async void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            try
            {
                try
                {
                    SendAuth.Req req = new SendAuth.Req("[YOUR SCOPE]", "test");

                    IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                    var isok = await api.SendReqAsync(req);
                }
                catch (WXException)
                {
                }

                //int scene = SendMessageToWX.Req.WXSceneTimeline; //发给微信朋友

                //var file = await Package.Current.InstalledLocation.GetFileAsync("1.png");
                //using (var stream = await file.OpenReadAsync())
                //{
                //    var pic = new byte[stream.Size];
                //    await stream.AsStream().ReadAsync(pic, 0, pic.Length);

                //    var message = new WXWebpageMessage
                //    {
                //        WebpageUrl = "http://www.baidu.com",
                //        Title = "title",
                //        Description = "desc",
                //        ThumbData = pic
                //    };

                //    try
                //    {
                //        SendMessageToWX.Req req = new SendMessageToWX.Req(message, scene);
                //        IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                //        var isok = await api.SendReq(req);
                //    }
                //    catch (WXException)
                //    {
                //    }
                //}

                //var message = new WXTextMessage();
                //message.Title = "flora";
                //message.Text = "这是一段文本内容";
                //message.ThumbData = null;
                //SendMessageToWX.Req req = new SendMessageToWX.Req(message, scene);
                //IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                //var isok = await api.SendReq(req);

                //WXImageMessage message = new WXImageMessage();
                //var file = await Package.Current.InstalledLocation.GetFileAsync("1.png");
                //using (var stream = await file.OpenReadAsync())
                //{
                //    var pic = new byte[stream.Size];
                //    await stream.AsStream().ReadAsync(pic, 0, pic.Length);
                //    message.Title = "tupian";
                //    message.Description = "desc";
                //    message.ThumbData = pic;
                //    message.ImageUrl = "http://tp3.sinaimg.cn/1882347990/180/5725518284/1";

                //    try
                //    {
                //        SendMessageToWX.Req req = new SendMessageToWX.Req(message, scene);
                //        IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
                //        var isok = await api.SendReq(req);
                //    }
                //    catch (WXException)
                //    {
                //    }
                //}
            }
            catch (Exception ex)
            {
                //new MessageDialog(ex.Message).ShowAsync();
            }
        }
    }
}
