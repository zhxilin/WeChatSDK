using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class ShowMessageFromWX
    {
        private ShowMessageFromWX()
        {
        }
        
        public class Req : BaseReq
        {
            public WXBaseMessage Message { get; set; }
            
            internal Req()
            {
            }

            public Req(WXBaseMessage message)
            {
                Message = message;
            }

            internal override void FromProto(object protoObj)
            {
                ShowMessageFromWXReq req = protoObj as ShowMessageFromWXReq;
                if (req != null)
                {
                    Transaction = req.Base.Transaction;
                    Message = WXBaseMessage.CreateMessage((int)req.Msg.Type);
                    Message?.FromProto(req.Msg);
                }
            }

            internal override object ToProto()
            {
                BaseReqP.Builder builder = BaseReqP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                ShowMessageFromWXReq.Builder builder2 = ShowMessageFromWXReq.CreateBuilder();
                builder2.Base = builder.Build();
                if (Message != null)
                {
                    WXMessageP ep = Message.ToProto() as WXMessageP;
                    builder2.Msg = ep;
                }
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SHOWMESSAGE_FROM_WX;
            }

            internal override bool ValidateData()
            {
                if (Message == null)
                {
                    throw new WXException(1, "Message can't be null.");
                }
                return Message.ValidateData();
            }
        }

        public class Resp : BaseResp
        {
            internal Resp()
            {
            }

            public Resp(string transaction, int errCode, string errString)
            {
                Transaction = transaction;
                ErrCode = errCode;
                ErrStr = errString;
            }

            internal override void FromProto(object protoObj)
            {
                GetMessageFromWXResp resp = protoObj as GetMessageFromWXResp;
                if (resp != null)
                {
                    Transaction = resp.Base.Transaction;
                    ErrCode = (int)resp.Base.ErrCode;
                    ErrStr = resp.Base.ErrStr;
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
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SHOWMESSAGE_FROM_WX;
            }

            internal override bool ValidateData()
            {
                return true;
            }
        }
    }
}
