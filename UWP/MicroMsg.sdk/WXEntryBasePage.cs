using System;
using System.Diagnostics;
using System.Linq;
using Windows.ApplicationModel.Activation;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using MicroMsg.sdk.utils;

namespace MicroMsg.sdk
{
    public class WXEntryBasePage : Page
    {
        public virtual void OnGetMessageFromWXRequest(GetMessageFromWX.Req request)
        {
        }

        public virtual void OnSendAuthResponse(SendAuth.Resp response)
        {
        }

        public virtual void OnSendMessageToWXResponse(SendMessageToWX.Resp response)
        {
        }

        public virtual void OnSendPayResponse(SendPay.Resp response)
        {
        }

        public virtual void OnShowMessageFromWXRequest(ShowMessageFromWX.Req request)
        {
        }

        public void Handle(FileActivatedEventArgs e)
        {
            if (e.Files.Any())
            {
                ParseData((StorageFile)e.Files[0]);
            }
        }

        public async void ParseData(StorageFile file)
        {
            try
            {
                if (!await FileUtil.DirExistsAsync(ConstantsAPI.SDK_TEMP_DIR_PATH))
                {
                    await FileUtil.CreateDirAsync(ConstantsAPI.SDK_TEMP_DIR_PATH);
                }

                var folder = await ApplicationData.Current.LocalFolder.GetFolderAsync(ConstantsAPI.SDK_TEMP_DIR_PATH);
                var copyFile = await file.CopyAsync(folder, "wp.wechat", NameCollisionOption.ReplaceExisting);

                if (await FileUtil.FileExistsAsync(ConstantsAPI.SDK_TEMP_FILE_PATH))
                {
                    TransactData data = await TransactData.ReadFromFileAsync(ConstantsAPI.SDK_TEMP_FILE_PATH);
                    if (!data.ValidateData())
                    {
                        //MessageBox.Show("数据验证失败");
                    }
                    else if (!data.CheckSupported())
                    {
                        //MessageBox.Show("当前版本不支持该请求");
                    }
                    else if (data.Req != null)
                    {
                        if (data.Req.Type() == ConstantsAPI.COMMAND_GETMESSAGE_FROM_WX)
                        {
                            OnGetMessageFromWXRequest(data.Req as GetMessageFromWX.Req);
                        }
                        else if (data.Req.Type() == 4)
                        {
                            OnShowMessageFromWXRequest(data.Req as ShowMessageFromWX.Req);
                        }
                    }
                    else if (data.Resp != null)
                    {
                        if (data.Resp.Type() == 1)
                        {
                            OnSendAuthResponse(data.Resp as SendAuth.Resp);
                        }
                        else if (data.Resp.Type() == 2)
                        {
                            OnSendMessageToWXResponse(data.Resp as SendMessageToWX.Resp);
                        }
                        else if (data.Resp.Type() == 5)
                        {
                            OnSendPayResponse(data.Resp as SendPay.Resp);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                //MessageBox.Show(exception.Message);
            }
        }
    }
}
