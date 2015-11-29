using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class GetMessageFromWX
    {
        private GetMessageFromWX()
        {
        }
        
        public class Req : BaseReq
        {
            public string Username { get; set; }
            
            internal Req()
            {
            }

            public Req(string username)
            {
                Username = username;
            }

            internal override void FromProto(object protoObj)
            {
                GetMessageFromWXReq req = protoObj as GetMessageFromWXReq;
                if (req != null)
                {
                    Transaction = req.Base.Transaction;
                    Username = req.Username;
                }
            }

            internal override object ToProto()
            {
                BaseReqP.Builder builder = BaseReqP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                GetMessageFromWXReq.Builder builder2 = GetMessageFromWXReq.CreateBuilder();
                builder2.Base = builder.Build();
                builder2.Username = Username;
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_GETMESSAGE_FROM_WX;
            }

            internal override bool ValidateData()
            {
                if (string.IsNullOrEmpty(Username))
                {
                    throw new WXException(1, "Username can't be empty.");
                }
                return true;
            }
        }

        public class Resp : BaseResp
        {
            public WXBaseMessage Message { get; set; }
            public string Username { get; set; }
            
            internal Resp()
            {
            }

            public Resp(string transaction, int errCode, string errString)
            {
                Username = "";
                Transaction = transaction;
                ErrCode = errCode;
                ErrStr = errString;
            }

            public Resp(string transaction, string username, WXBaseMessage message)
            {
                Username = "";
                Username = username;
                Message = message;
                Transaction = transaction;
            }

            internal override void FromProto(object protoObj)
            {
                GetMessageFromWXResp resp = protoObj as GetMessageFromWXResp;
                if (resp != null)
                {
                    Transaction = resp.Base.Transaction;
                    ErrCode = (int)resp.Base.ErrCode;
                    ErrStr = resp.Base.ErrStr;
                    Username = resp.Username;
                    Message = WXBaseMessage.CreateMessage((int)resp.Msg.Type);
                    Message?.FromProto(resp.Msg);
                }
            }

            internal override object ToProto()
            {
                BaseRespP.Builder builder = BaseRespP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                builder.ErrCode = (uint)ErrCode;
                builder.ErrStr = ErrStr;
                GetMessageFromWXResp.Builder builder2 = GetMessageFromWXResp.CreateBuilder();
                builder2.Base = builder.Build();
                if (Message != null)
                {
                    WXMessageP ep = Message.ToProto() as WXMessageP;
                    builder2.Msg = ep;
                }
                builder2.Username = Username;
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_GETMESSAGE_FROM_WX;
            }

            internal override bool ValidateData()
            {
                if (string.IsNullOrEmpty(Username))
                {
                    throw new WXException(1, "Username can't be empty.");
                }
                if (ErrCode != 0)
                {
                    return true;
                }
                if (Message == null)
                {
                    throw new WXException(1, "Message can't be null.");
                }
                return Message.ValidateData();
            }
        }
    }
}
