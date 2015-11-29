using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXImageMessage : WXBaseMessage
    {
        private const int CONTENT_LENGTH_LIMIT = 0xA00000;
        private const int PATH_LENGTH_LIMIT = 0x2800;
        private const int URL_LENGTH_LIMIT = 0x2800;
        public byte[] ImageData { get; set; } = new byte[0];
        public string ImageUrl { get; set; } = string.Empty;

        public WXImageMessage(byte[] imageData)
        {
            ImageData = imageData;
        }

        public WXImageMessage(string imageUrl)
        {
            ImageUrl = imageUrl;
        }

        public WXImageMessage()
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
                if (ep.ImageMessage != null)
                {
                    ImageData = ep.ImageMessage.ImageData.ToByteArray();
                    ImageUrl = ep.ImageMessage.ImageUrl;
                }
            }
        }

        internal override object ToProto()
        {
            WXImageMessageP.Builder builder = WXImageMessageP.CreateBuilder();
            builder.ImageData = ByteString.CopyFrom(ImageData);
            builder.ImageUrl = ImageUrl;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.ImageMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_IMAGE;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (ImageData == null || ImageData.Length == 0 && string.IsNullOrEmpty(ImageUrl))
            {
                throw new WXException(1, "All arguments are null.");
            }
            if (ImageData != null && ImageData.Length > CONTENT_LENGTH_LIMIT)
            {
                throw new WXException(1, "ImageData is invalid.");
            }
            if (ImageUrl != null && ImageUrl.Length > URL_LENGTH_LIMIT)
            {
                throw new WXException(1, "ImageUrl is invalid.");
            }
            return true;
        }
    }





}
