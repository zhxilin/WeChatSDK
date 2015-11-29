# WeChatSDK
本项目基于微信官方WP8 SDK编写，适用于Windows 10 UWP应用和WP8.1 WinRT应用。UWP项目中还提供WeChatSDK.Extensions，封装部分微信Open API，方便在使用SDK登录授权后，获取用户基本资料等需求。

本项目仅供学习交流参考。

使用方法
-----------------------------------
#### 访问[微信开放平台](https://open.weixin.qq.com/)注册应用，SDK使用方法同官方文档基本一致

> __分享文本消息__
```csharp 
try
{
    var scene = SendMessageToWX.Req.WXSceneTimeline;
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
```
>

> __分享图片消息__
```
try
{
    var scene = SendMessageToWX.Req.WXSceneTimeline;
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
```
>
> __分享链接消息__
```
try
{
    var scene = SendMessageToWX.Req.WXSceneTimeline;
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
```

> __微信登录授权__
```
try
{
    SendAuth.Req req = new SendAuth.Req("[YOUR SCOPE]", "test");
    IWXAPI api = WXAPIFactory.CreateWXAPI("[YOUR APP ID]");
    var isValid = await api.SendReq(req);
}
catch (WXException ex)
{
    Debug.WriteLine(ex.Message);
}
```

####分享结果回调和登录授权回调
* 打开Pakcage.appxmanifest文件，在Extensions节点下添加文件关联协议
```
<Extensions>
    <uap:Extension Category="windows.fileTypeAssociation">
        <uap:FileTypeAssociation Name="wechat">
            <uap:SupportedFileTypes>
                <uap:FileType>.[YOUR APP ID]</uap:FileType>
            </uap:SupportedFileTypes>
        </uap:FileTypeAssociation>
    </uap:Extension>
</Extensions>
```
* 在你的项目中，创建一个类WeChatCallback类，继承WXEntryBasePage类，重载`OnSendMessageToWXResponse`方法和`OnSendAuthResponse`处理回调结果。
，如
```
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
```
* 微信处理结果点击“返回XXX（应用名）”后，会在App.xaml.cs中触发OnFileActivated事件，在事件中处理微信返回结果：
```
        protected override void OnFileActivated(FileActivatedEventArgs args)
        {
            base.OnFileActivated(args);
            try
            {
                var wechat = new WeChatCallback();
                wechat.Handle(args);
            }
            catch (Exception)
            {
                // ignored
            }
        }
```
