using System;
using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXMusicMessage : WXBaseMessage
    {
        private const int LENGTH_LIMIT = 0x2800;
        public string MusicLowBandUrl { get; set; } = string.Empty;
        public string MusicUrl { get; set; } = string.Empty;
        
        internal override void FromProto(object protoObj)
        {
            WXMessageP ep = protoObj as WXMessageP;
            if (ep != null)
            {
                Title = ep.Title;
                Description = ep.Description;
                ThumbData = ep.ThumbData.ToByteArray();
                if (ep.MusicMessage != null)
                {
                    MusicUrl = ep.MusicMessage.MusicUrl;
                    MusicLowBandUrl = ep.MusicMessage.MusicLowBandUrl;
                }
            }
        }

        internal override object ToProto()
        {
            WXMusicMessageP.Builder builder = WXMusicMessageP.CreateBuilder();
            builder.MusicUrl = MusicUrl;
            builder.MusicLowBandUrl = MusicLowBandUrl;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.MusicMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_MUSIC;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (string.IsNullOrEmpty(MusicUrl) && string.IsNullOrEmpty(MusicLowBandUrl))
            {
                throw new WXException(1, "Both arguments are null.");
            }
            if (MusicUrl != null && MusicUrl.Length > LENGTH_LIMIT)
            {
                throw new WXException(1, "MusicUrl is too long.");
            }
            if (MusicLowBandUrl != null && MusicLowBandUrl.Length > LENGTH_LIMIT)
            {
                throw new WXException(1, "MusicLowBandUrl is too long.");
            }
            return true;
        }
    }





}
