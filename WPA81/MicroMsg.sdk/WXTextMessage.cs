using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXTextMessage : WXBaseMessage
    {
        private const int LENGTH_LIMIT = 0xa0000;
        public string Text { get; set; } = string.Empty;

        public WXTextMessage(string text)
        {
            Text = text;
        }

        public WXTextMessage()
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
                if (ep.TextMessage != null)
                {
                    Text = ep.TextMessage.Text;
                }
            }
        }

        internal override object ToProto()
        {
            WXTextMessageP.Builder builder = WXTextMessageP.CreateBuilder();
            builder.Text = Text;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            if (ThumbData == null)
            {
                ThumbData = new byte[0];
            }
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.TextMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_TEXT;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (string.IsNullOrEmpty(Text) || Text.Length > LENGTH_LIMIT)
            {
                throw new WXException(1, "Text is invalid.");
            }
            return true;
        }
    }

}
