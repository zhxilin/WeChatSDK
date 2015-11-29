using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class SendAuth
    {
        private SendAuth()
        {
        }
        
        public class Req : BaseReq
        {
            private const int LENGTH_LIMIT = 0x400;
            private const string TAG = "MicroMsg.SendAuth.Req";
            public string Scope { get; set; }
            public string State { get; set; }
            
            internal Req()
            {
            }

            public Req(string scope, string state)
            {
                Scope = scope;
                State = state;
            }

            internal override void FromProto(object protoObj)
            {
                SendAuthReq req = protoObj as SendAuthReq;
                if (req != null)
                {
                    Transaction = req.Base.Transaction;
                    Scope = req.Scope;
                    State = req.State;
                }
            }

            internal override object ToProto()
            {
                BaseReqP.Builder builder = BaseReqP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                SendAuthReq.Builder builder2 = SendAuthReq.CreateBuilder();
                builder2.Base = builder.Build();
                builder2.Scope = Scope;
                builder2.State = State;
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SENDAUTH;
            }

            internal override bool ValidateData()
            {
                if (string.IsNullOrEmpty(Scope) || Scope.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "Scope is invalid.");
                }
                if (State != null && State.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "State is invalid.");
                }
                return true;
            }
        }

        public class Resp : BaseResp
        {
            private const int LENGTH_LIMIT = 0x400;
            private const string TAG = "MicroMsg.SendAuth.Resp";
            public string Code { get; set; }
            public string State { get; set; }
            public string Url { get; set; }
            
            internal Resp()
            {
            }

            public Resp(string transaction, int errCode, string errString)
            {
                Transaction = transaction;
                ErrCode = errCode;
                ErrStr = errString;
            }

            public Resp(string code, string state, string url)
            {
                Code = code;
                State = state;
                Url = url;
            }

            internal override void FromProto(object protoObj)
            {
                SendAuthResp resp = protoObj as SendAuthResp;
                if (resp != null)
                {
                    Transaction = resp.Base.Transaction;
                    ErrCode = (int)resp.Base.ErrCode;
                    ErrStr = resp.Base.ErrStr;
                    Code = resp.Code;
                    State = resp.State;
                    Url = resp.Url;
                }
            }

            internal override object ToProto()
            {
                BaseRespP.Builder builder = BaseRespP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                builder.ErrCode = (uint)ErrCode;
                builder.ErrStr = ErrStr;
                SendAuthResp.Builder builder2 = SendAuthResp.CreateBuilder();
                builder2.Base = builder.Build();
                builder2.Code = string.IsNullOrEmpty(Code) ? "" : Code;
                builder2.State = string.IsNullOrEmpty(State) ? "" : State;
                builder2.Url = string.IsNullOrEmpty(Url) ? "" : Url;
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SENDAUTH;
            }

            internal override bool ValidateData()
            {
                if (State != null && State.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "State is invalid.");
                }
                return true;
            }
        }
    }
}
