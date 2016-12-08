using System;
namespace MicroMsg.sdk
{
    public class ConstantsAPI
    {
        public const int COMMAND_UNKNOWN = 0;
        public const int COMMAND_SENDAUTH = 1;
        public const int COMMAND_SENDMESSAGE_TO_WX = 2;
        public const int COMMAND_GETMESSAGE_FROM_WX = 3;
        public const int COMMAND_SHOWMESSAGE_FROM_WX = 4;
        public const int COMMAND_SENDPAY = 5;

        internal const byte SDK_MAIN_VERSION = 1;
        internal const byte SDK_SUB_VERSION = 6;
        public const string SDK_TEMP_DIR_PATH = "wechatsdk";
        public const string SDK_TEMP_FILE_PATH = "wechatsdk/wp.wechat";
        public const string SDK_VERSION = "1.6";
        public const string THIRD_APP_ID = "wechatapp";
        public const string WECHAT_APP_ID = "wechat";
        public static async System.Threading.Tasks.Task<bool> CanOpenWXAppAsync()
        {
            return (await Windows.System.Launcher.FindFileHandlersAsync(".wechat")).Count > 0;
        }
    }
}
