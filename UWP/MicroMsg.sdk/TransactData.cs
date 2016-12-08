using System;
using System.Threading.Tasks;
using MicroMsg.sdk.protobuf;
using MicroMsg.sdk.utils;

namespace MicroMsg.sdk
{
    internal class TransactData
    {
        public string AppId { get; internal set; }
        public string CheckContent { get; internal set; }
        public string CheckSummary { get; internal set; }
        public int ConmandId { get; internal set; }
        public BaseReq Req { get; internal set; }
        public BaseResp Resp { get; internal set; }
        public string SdkVersion { get; internal set; }
        
        public bool CheckSupported()
        {
            if (Req == null && Resp == null)
            {
                return false;
            }
            bool flag;
            switch (ConmandId)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    flag = true;
                    break;
                default:
                    flag = false;
                    break;
            }
            WXBaseMessage message = null;
            if (Req is SendMessageToWX.Req)
            {
                SendMessageToWX.Req req = (SendMessageToWX.Req)Req;
                message = req.Message;
            }
            if (Req is ShowMessageFromWX.Req)
            {
                ShowMessageFromWX.Req req2 = (ShowMessageFromWX.Req) Req;
                message = req2.Message;
            }
            if (Resp is GetMessageFromWX.Resp)
            {
                GetMessageFromWX.Resp resp = (GetMessageFromWX.Resp)Resp;
                message = resp.Message;
            }
            if (message != null)
            {
                flag &= (message.Type() >= 0) && (message.Type() <= 8);
            }
            return flag;
        }

        internal void FromProto(object protoObj)
        {
            TransactDataP ap = protoObj as TransactDataP;
            if (ap != null)
            {
                ConmandId = (int)ap.ConmandID;
                AppId = ap.AppID;
                SdkVersion = ap.SdkVersion;
                CheckContent = ap.CheckContent;
                CheckSummary = ap.CheckSummary;
                if (!string.IsNullOrEmpty(ap.GetReq.Base.Transaction))
                {
                    Req = new GetMessageFromWX.Req();
                    Req.FromProto(ap.GetReq);
                }
                if (!string.IsNullOrEmpty(ap.AuthReq.Base.Transaction))
                {
                    Req = new SendAuth.Req();
                    Req.FromProto(ap.AuthReq);
                }
                if (!string.IsNullOrEmpty(ap.SendReq.Base.Transaction))
                {
                    Req = new SendMessageToWX.Req();
                    Req.FromProto(ap.SendReq);
                }
                if (!string.IsNullOrEmpty(ap.ShowReq.Base.Transaction))
                {
                    Req = new ShowMessageFromWX.Req();
                    Req.FromProto(ap.ShowReq);
                }
                if (!string.IsNullOrEmpty(ap.GetResp.Base.Transaction))
                {
                    Resp = new GetMessageFromWX.Resp();
                    Resp.FromProto(ap.GetResp);
                }
                if (!string.IsNullOrEmpty(ap.AuthResp.Base.Transaction))
                {
                    Resp = new SendAuth.Resp();
                    Resp.FromProto(ap.AuthResp);
                }
                if (!string.IsNullOrEmpty(ap.SendResp.Base.Transaction))
                {
                    Resp = new SendMessageToWX.Resp();
                    Resp.FromProto(ap.SendResp);
                }
                if (!string.IsNullOrEmpty(ap.ShowResp.Base.Transaction))
                {
                    Resp = new ShowMessageFromWX.Resp();
                    Resp.FromProto(ap.ShowResp);
                }
                if (!string.IsNullOrEmpty(ap.PayReq.Base.Transaction))
                {
                    Req = new SendPay.Req();
                    Req.FromProto(ap.PayReq);
                }
                if (!string.IsNullOrEmpty(ap.PayResp.Base.Transaction))
                {
                    Resp = new SendPay.Resp();
                    Resp.FromProto(ap.PayResp);
                }
            }
        }

        public async static Task<TransactData> ReadFromFileAsync(string fileName)
        {
            byte[] sourceArray = await FileUtil.ReadFromFileAsync(fileName, 0, 0x40);
            byte[] destinationArray = new byte[4];
            Array.Copy(sourceArray, 2, destinationArray, 0, 4);
            int count = BitConverter.ToInt32(destinationArray, 0);
            TransactDataP protoObj = TransactDataP.ParseFrom((await FileUtil.ReadFromFileAsync(fileName, 0x40, count)));
            TransactData data = new TransactData();
            data.FromProto(protoObj);
            return data;
        }

        internal TransactDataP ToProto()
        {
            TransactDataP.Builder builder = TransactDataP.CreateBuilder();
            builder.ConmandID = (uint)ConmandId;
            builder.AppID = AppId;
            builder.SdkVersion = SdkVersion;
            builder.CheckContent = CheckContent;
            builder.CheckSummary = CheckSummary;
            if (Req != null)
            {
                switch (Req.Type())
                {
                    case 1:
                        builder.AuthReq = Req.ToProto() as SendAuthReq;
                        break;
                    case 2:
                        builder.SendReq = Req.ToProto() as SendMessageToWXReq;
                        break;
                    case 3:
                        builder.GetReq = Req.ToProto() as GetMessageFromWXReq;
                        break;
                    case 4:
                        builder.ShowReq = Req.ToProto() as ShowMessageFromWXReq;
                        break;
                    case 5:
                        builder.PayReq = Req.ToProto() as SendPayReqP;
                        break;
                }
            }
            if (Resp != null)
            {
                switch (Resp.Type())
                {
                    case 1:
                        builder.AuthResp = Resp.ToProto() as SendAuthResp;
                        break;
                    case 2:
                        builder.SendResp = Resp.ToProto() as SendMessageToWXResp;
                        break;
                    case 3:
                        builder.GetResp = Resp.ToProto() as GetMessageFromWXResp;
                        break;
                    case 4:
                        builder.ShowResp = Resp.ToProto() as ShowMessageFromWXResp;
                        break;
                    case 5:
                        builder.PayResp = Resp.ToProto() as SendPayRespP;
                        break;
                }
            }
            return builder.Build();
        }

        public bool ValidateData(bool checkSummary = true)
        {
            if (string.IsNullOrEmpty(AppId))
            {
                throw new WXException(1, "AppID can't be empty.");
            }
            if (string.IsNullOrEmpty(SdkVersion) || string.IsNullOrEmpty(CheckContent) || string.IsNullOrEmpty(CheckSummary))
            {
                return false;
            }
            if (Req == null && Resp == null)
            {
                return false;
            }
            if (Req != null && !Req.ValidateData())
            {
                return false;
            }
            if (Resp != null && !Resp.ValidateData())
            {
                return false;
            }
            if (checkSummary)
            {
                string str = WXApiImpl.GetCheckSummary(CheckContent, SdkVersion, AppId);
                if ((str == null) || !str.Equals(CheckSummary, StringComparison.CurrentCultureIgnoreCase))
                {
                    return false;
                }
            }
            return true;
        }

        public async static void WriteToFile(TransactData data, string fileName, string folderName)
        {
            byte[] destinationArray = new byte[0x40];
            destinationArray[0] = 1;
            destinationArray[1] = 5;
            byte[] buffer2 = data.ToProto().ToByteArray();
            int length = buffer2.Length;
            Array.Copy(BitConverter.GetBytes(length), 0, destinationArray, 2, 4);
            await FileUtil.WriteToFileAsync(fileName, folderName, destinationArray, true);
            FileUtil.AppendToFile(fileName, folderName, buffer2);
        }
    }
}
