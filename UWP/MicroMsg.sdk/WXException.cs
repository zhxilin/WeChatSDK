using System;
using System.Collections.Generic;
using System.Globalization;

namespace MicroMsg.sdk
{
    public class WXException : Exception
    {
        public const int ERR_DATA_ILLEGA = 1;
        public const int ERR_NOT_SUPPORTED = 2;
        public const int ERR_OTHER = 0;
        public const int ERR_PACKAGE_ERR = 3;
        private static Dictionary<string, string> _errStringMap;

        public WXException(int errCode, string appendString = "") : base(GetErrString(errCode, appendString))
        {
            HResult = errCode;
        }

        public static string GetErrString(int code, string appendString = "")
        {
            if (_errStringMap == null)
            {
                InitErrStringMap();
            }
            if (appendString == null)
            {
                appendString = "";
            }
            if (code > 3 || code < 0)
            {
                code = 0;
            }
            if (_errStringMap == null)
            {
                return string.Empty;
            }
            string str = _errStringMap[code + "_" + GetLanguage()];
            if (!string.IsNullOrEmpty(appendString))
            {
                str = str + ": " + appendString;
            }
            return str;
        }

        private static string GetLanguage()
        {
            RegionInfo currentRegion = RegionInfo.CurrentRegion;
            if (currentRegion.Name == "CN")
            {
                return "cn";
            }
            if (currentRegion.Name == "TW")
            {
                return "tw";
            }
            return "en";
        }

        private static void InitErrStringMap()
        {
            _errStringMap = new Dictionary<string, string>
            {
                {0 + "_en", "Unknown error:"},
                {0 + "_cn", "未知错误"},
                {0 + "_tw", "未知錯誤"},
                {1 + "_en", "Invalid data format"},
                {1 + "_cn", "数据格式不合法"},
                {1 + "_tw", "資料格式無效"},
                {2 + "_en", "Request not supported by your current version"},
                {2 + "_cn", "当前版本不支持该请求"},
                {2 + "_tw", "當前版本不支持該請求"},
                {3 + "_en", "打包数据时发生错误"},
                {3 + "_cn", "打包数据时发生错误"},
                {3 + "_tw", "打包数据时发生错误"}
            };
        }
    }
}
