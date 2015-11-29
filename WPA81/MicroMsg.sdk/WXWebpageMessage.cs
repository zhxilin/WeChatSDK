using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXWebpageMessage : WXBaseMessage
    {
        private const int LENGTH_LIMIT = 0x2800;
        public string WebpageUrl { get; set; } = string.Empty;

        public WXWebpageMessage(string url)
        {
            WebpageUrl = url;
        }

        public WXWebpageMessage()
        {
        }

        internal override void FromProto(object protoObj)
        {
            WXMessageP ep = protoObj as WXMessageP;
            if (ep != null)
            {
                Title = ep.Title;
                Description = ep.Description;
                ThumbData = ep.ThumbData.ToByteArray();
                if (ep.WebpageMessage != null)
                {
                    WebpageUrl = ep.WebpageMessage.WebpageUrl;
                }
            }
        }

        internal override object ToProto()
        {
            WXWebpageMessageP.Builder builder = WXWebpageMessageP.CreateBuilder();
            builder.WebpageUrl = WebpageUrl;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.WebpageMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_URL;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (string.IsNullOrEmpty(WebpageUrl) || WebpageUrl.Length > LENGTH_LIMIT)
            {
                throw new WXException(1, "WebpageUrl is invalid.");
            }
            return true;
        }
    }
}
