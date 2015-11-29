using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXEmojiMessage : WXBaseMessage
    {
        
        private const int CONTENT_LENGTH_LIMIT = 0xa00000;
        public byte[] EmojiData { get; set; } = new byte[0];

        public WXEmojiMessage(byte[] emojiData)
        {
            EmojiData = emojiData;
        }

        public WXEmojiMessage()
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
                if (ep.EmojiMessage != null)
                {
                    EmojiData = ep.EmojiMessage.EmojiData.ToByteArray();
                }
            }
        }

        internal override object ToProto()
        {
            WXEmojiMessageP.Builder builder = WXEmojiMessageP.CreateBuilder();
            builder.EmojiData = ByteString.CopyFrom(EmojiData);
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.EmojiMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_EMOJI;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (EmojiData == null || EmojiData.Length == 0)
            {
                throw new WXException(1, "EmojiData is invalid.");
            }
            if (EmojiData != null && EmojiData.Length > CONTENT_LENGTH_LIMIT)
            {
                throw new WXException(1, "EmojiData is invalid.");
            }
            return true;
        }
    }
}
