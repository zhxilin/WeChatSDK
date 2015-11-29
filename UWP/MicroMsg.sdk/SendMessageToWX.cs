using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class SendMessageToWX
    {
        private SendMessageToWX()
        {
        }
        
        public class Req : BaseReq
        {
            public WXBaseMessage Message;
            public int Scene;
            private const string TAG = "MicroMsg.SendMessageToWX.Req";
            public const int WXSceneChooseByUser = 0;
            public const int WXSceneSession = 1;
            public const int WXSceneTimeline = 2;
            
            internal Req()
            {
            }

            public Req(WXBaseMessage message, int scene = 1)
            {
                Message = message;
                Scene = scene;
            }

            internal override void FromProto(object protoObj)
            {
                SendMessageToWXReq req = protoObj as SendMessageToWXReq;
                if (req != null)
                {
                    Transaction = req.Base.Transaction;
                    Scene = (int)req.Scene;
                    Message = WXBaseMessage.CreateMessage((int)req.Msg.Type);
                    Message?.FromProto(req.Msg);
                }
            }

            internal override object ToProto()
            {
                BaseReqP.Builder builder = BaseReqP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                SendMessageToWXReq.Builder builder2 = SendMessageToWXReq.CreateBuilder();
                builder2.Base = builder.Build();
                builder2.Scene = (uint)Scene;
                if (Message != null)
                {
                    WXMessageP ep = Message.ToProto() as WXMessageP;
                    builder2.Msg = ep;
                }
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SENDMESSAGE_TO_WX;
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
            public Resp()
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
                SendMessageToWXResp resp = protoObj as SendMessageToWXResp;
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
                SendMessageToWXResp.Builder builder2 = SendMessageToWXResp.CreateBuilder();
                builder2.Base = builder.Build();
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SENDMESSAGE_TO_WX;
            }

            internal override bool ValidateData()
            {
                return true;
            }
        }
    }
}
