using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class SendPay
    {
        private SendPay()
        {
        }

        public class Req : BaseReq
        {
            private const int LENGTH_LIMIT = 0x400;
            private const string TAG = "MicroMsg.SendPay.Req";
            public string NonceStr { get; set; }
            public string Package { get; set; }
            public string PartnerId { get; set; }
            public string PrepayId { get; set; }
            public string Sign { get; set; }
            public uint TimeStamp { get; set; }

            internal Req()
            {
            }

            public Req(string partnerId, string prepayId, string nonceStr, uint timeStamp, string package, string sign)
            {
                PartnerId = partnerId;
                PrepayId = prepayId;
                NonceStr = nonceStr;
                TimeStamp = timeStamp;
                Package = package;
                Sign = sign;
            }

            internal override void FromProto(object protoObj)
            {
                SendPayReqP qp = protoObj as SendPayReqP;
                if (qp != null)
                {
                    Transaction = qp.Base.Transaction;
                    PartnerId = qp.PartnerId;
                    PrepayId = qp.PrepayId;
                    NonceStr = qp.NonceStr;
                    TimeStamp = qp.TimeStamp;
                    Package = qp.Package;
                    Sign = qp.Sign;
                }
            }

            internal override object ToProto()
            {
                BaseReqP.Builder builder = BaseReqP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                SendPayReqP.Builder builder2 = SendPayReqP.CreateBuilder();
                builder2.Base = builder.Build();
                builder2.PartnerId = PartnerId;
                builder2.PrepayId = PrepayId;
                builder2.NonceStr = NonceStr;
                builder2.TimeStamp = TimeStamp;
                builder2.Package = Package;
                builder2.Sign = Sign;
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SENDPAY;
            }

            internal override bool ValidateData()
            {
                if (string.IsNullOrWhiteSpace(PartnerId) || PartnerId.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "PartnerId is invalid.");
                }
                if (string.IsNullOrWhiteSpace(PrepayId) || PrepayId.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "PrepayId is invalid.");
                }
                if (string.IsNullOrWhiteSpace(NonceStr) || NonceStr.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "NonceStr is invalid.");
                }
                if (TimeStamp == 0)
                {
                    throw new WXException(1, "TimeStamp is invalid.");
                }
                if (string.IsNullOrWhiteSpace(Package) || Package.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "Package is invalid.");
                }
                if (string.IsNullOrWhiteSpace(Sign) || Sign.Length > LENGTH_LIMIT)
                {
                    throw new WXException(1, "Sign is invalid.");
                }
                return true;
            }
        }

        public class Resp : BaseResp
        {
            private const int LENGTH_LIMIT = 0x400;
            private const string TAG = "MicroMsg.SendPay.Resp";
            public string ReturnKey { get; set; }

            internal Resp()
            {
            }

            public Resp(string returnKey)
            {
                ReturnKey = returnKey;
            }

            public Resp(string transaction, int errCode, string errString)
            {
                Transaction = transaction;
                ErrCode = errCode;
                ErrStr = errString;
            }

            internal override void FromProto(object protoObj)
            {
                SendPayRespP pp = protoObj as SendPayRespP;
                if (pp != null)
                {
                    Transaction = pp.Base.Transaction;
                    ErrCode = (int)pp.Base.ErrCode;
                    ErrStr = pp.Base.ErrStr;
                    ReturnKey = pp.ReturnKey;
                }
            }

            internal override object ToProto()
            {
                BaseRespP.Builder builder = BaseRespP.CreateBuilder();
                builder.Type = (uint)Type();
                builder.Transaction = Transaction;
                builder.ErrCode = (uint)ErrCode;
                builder.ErrStr = ErrStr;
                SendPayRespP.Builder builder2 = SendPayRespP.CreateBuilder();
                builder2.Base = builder.Build();
                builder2.ReturnKey = string.IsNullOrEmpty(ReturnKey) ? "" : ReturnKey;
                return builder2.Build();
            }

            public override int Type()
            {
                return ConstantsAPI.COMMAND_SENDPAY;
            }

            internal override bool ValidateData()
            {
                return true;
            }
        }
    }
}
