using System;
using System.Globalization;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.System;
using MicroMsg.sdk.utils;

namespace MicroMsg.sdk
{
    internal class WXApiImpl : IWXAPI
    {
        private readonly string _appId;
        private const string TempFileName = "wp";

        internal WXApiImpl(string appId)
        {
            _appId = appId;
        }

        internal static string GetCheckContent()
        {
            DateTime time = DateTime.Now.ToUniversalTime();
            DateTime time2 = new DateTime(1970, 1, 1);
            return Convert.ToString(time.Subtract(time2).TotalMilliseconds, CultureInfo.InvariantCulture);
        }

        internal static string GetCheckSummary(string content, string sdkVersion, string appId)
        {
            return Md5Util.GetHashString(TrimToEmpty(content) + TrimToEmpty(sdkVersion) + TrimToEmpty(appId));
        }

        internal static string GetTransactionId()
        {
            DateTime time = DateTime.Now.ToUniversalTime();
            DateTime time2 = new DateTime(0x7b2, 1, 1);
            return Convert.ToString(time.Subtract(time2).TotalMilliseconds, CultureInfo.InvariantCulture);
        }

        public async void OpenWXApp()
        {
            await Launcher.LaunchUriAsync(new Uri("wechat:LaunchWechat?target=MainPage"));
        }

        private async void SendOut(string filePath, string targetAppId)
        {
            StorageFolder local = await ApplicationData.Current.LocalFolder.GetFolderAsync(ConstantsAPI.SDK_TEMP_DIR_PATH);
            StorageFile bqfile = await local.GetFileAsync(filePath);
            if (bqfile != null)
            {
                await Launcher.LaunchFileAsync(bqfile);
            }
        }

        public async Task<string> SendReqAsync(BaseReq request, string targetAppId = ConstantsAPI.WECHAT_APP_ID)
        {
            int p = 0;
            try
            {
                if (request == null)
                {
                    throw new WXException(1, "Req can't be null.");
                }
                if (string.IsNullOrEmpty(targetAppId))
                {
                    throw new WXException(1, "targetAppID can't be empty.");
                }
                p = 1;
                var data = new TransactData
                {
                    Req = request,
                    AppId = _appId,
                    ConmandId = request.Type(),
                    SdkVersion = ConstantsAPI.SDK_VERSION,
                    CheckContent = GetCheckContent()
                };
                data.CheckSummary = GetCheckSummary(data.CheckContent, data.SdkVersion, data.AppId);
                p = 2;
                if (string.IsNullOrEmpty(request.Transaction))
                {
                    request.Transaction = GetTransactionId();
                }

                var folder = await ApplicationData.Current.LocalFolder.CreateFolderAsync(ConstantsAPI.SDK_TEMP_DIR_PATH, CreationCollisionOption.OpenIfExists);
                p = 3;
                string fileName = $"{TempFileName}.{targetAppId}";
                //if (await FileUtil.fileExists(fileName))
                //{
                //   await FileUtil.deleteFile(fileName);
                //}
                if (data.ValidateData(false))
                {
                    try
                    {
                        p = 4;
                        TransactData.WriteToFile(data, fileName, ConstantsAPI.SDK_TEMP_DIR_PATH);
                        SendOut(fileName, targetAppId);
                        return "true";
                    }
                    catch (Exception exception)
                    {
                        throw new WXException(0, exception.Message);
                    }
                }
                return "false";
            }
            catch (Exception e)
            {
                return e.Message + "p:" + p;
            }
        }

        public async Task<bool> SendRespAsync(BaseResp response, string targetAppId)
        {
            if (response == null)
            {
                throw new WXException(1, "Resp can't be null.");
            }
            if (string.IsNullOrEmpty(targetAppId))
            {
                throw new WXException(1, "targetAppID can't be empty.");
            }
            var data = new TransactData
            {
                Resp = response,
                AppId = _appId,
                ConmandId = response.Type(),
                SdkVersion = ConstantsAPI.SDK_VERSION,
                CheckContent = GetCheckContent(),
                CheckSummary = GetCheckSummary(GetCheckContent(), ConstantsAPI.SDK_VERSION, _appId)
            };
            if (string.IsNullOrEmpty(response.Transaction))
            {
                response.Transaction = GetTransactionId();
            }

            var folder = await ApplicationData.Current.LocalFolder.CreateFileAsync(ConstantsAPI.SDK_TEMP_DIR_PATH);

            string fileName = $"{TempFileName}.{targetAppId}";
            //if (await FileUtil.fileExists(fileName))
            //{
            //   await FileUtil.deleteFile(fileName);
            //}
            if (data.ValidateData(false))
            {
                try
                {
                    TransactData.WriteToFile(data, fileName, ConstantsAPI.SDK_TEMP_DIR_PATH);
                    SendOut(fileName, targetAppId);
                    return true;
                }
                catch (Exception exception)
                {
                    throw new WXException(0, exception.Message);
                }
            }
            return false;
        }

        private static string TrimToEmpty(string s)
        {
            if (s != null)
            {
                return s.Trim();
            }
            return "";
        }
    }
}
