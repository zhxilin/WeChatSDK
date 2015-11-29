using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXVideoMessage : WXBaseMessage
    {
        private const int LENGTH_LIMIT = 0x2800;
        public string VideoLowBandUrl { get; set; } = string.Empty;
        public string VideoUrl { get; set; } = string.Empty;

        internal override void FromProto(object protoObj)
        {
            WXMessageP ep = protoObj as WXMessageP;
            if (ep != null)
            {
                Title = ep.Title;
                Description = ep.Description;
                ThumbData = ep.ThumbData.ToByteArray();
                if (ep.VideoMessage != null)
                {
                    VideoUrl = ep.VideoMessage.VideoUrl;
                    VideoLowBandUrl = ep.VideoMessage.VideoLowBandUrl;
                }
            }
        }

        internal override object ToProto()
        {
            WXVideoMessageP.Builder builder = WXVideoMessageP.CreateBuilder();
            builder.VideoUrl = VideoUrl;
            builder.VideoLowBandUrl = VideoLowBandUrl;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.VideoMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_VIDEO;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (string.IsNullOrEmpty(VideoUrl) && string.IsNullOrEmpty(VideoLowBandUrl))
            {
                throw new WXException(1, "Both arguments are null.");
            }
            if (VideoUrl != null && VideoUrl.Length > LENGTH_LIMIT)
            {
                throw new WXException(1, "VideoUrl is too long.");
            }
            if (VideoLowBandUrl != null && VideoLowBandUrl.Length > LENGTH_LIMIT)
            {
                throw new WXException(1, "VideoLowBandUrl is too long.");
            }
            return true;
        }
    }
}
