using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXAppExtendMessage : WXBaseMessage
    {
        private const int EXTINFO_Length_LIMIT = 0x800;
        private const int PATH_Length_LIMIT = 0x2800;
        private const int CONTENT_Length_LIMIT = 0xa00000;
        public string ExtInfo { get; set; } = string.Empty;
        public byte[] FileData { get; set; } = new byte[0];
        public string FileName { get; set; } = string.Empty;
        
        public WXAppExtendMessage(string extInfo, string fileName, byte[] fileData)
        {
            ExtInfo = extInfo;
            FileData = fileData;
            FileName = fileName;
        }

        public WXAppExtendMessage()
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
                if (ep.AppExtendMessage != null)
                {
                    FileData = ep.AppExtendMessage.FileData.ToByteArray();
                    ExtInfo = ep.AppExtendMessage.ExtInfo;
                    FileName = ep.AppExtendMessage.FileName;
                }
            }
        }

        internal override object ToProto()
        {
            WXAppExtendMessageP.Builder builder = WXAppExtendMessageP.CreateBuilder();
            builder.FileData = ByteString.CopyFrom(FileData);
            builder.ExtInfo = ExtInfo;
            builder.FileName = FileName;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.AppExtendMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_APPDATA;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (string.IsNullOrEmpty(ExtInfo) && string.IsNullOrEmpty(FileName) && (FileData == null || FileData.Length == 0))
            {
                throw new WXException(1, "All arguments is null.");
            }
            if (ExtInfo != null && ExtInfo.Length > EXTINFO_Length_LIMIT)
            {
                throw new WXException(1, "ExtInfo is invalid.");
            }
            if (FileName != null && FileName.Length > PATH_Length_LIMIT)
            {
                throw new WXException(1, "FilePath is invalid.");
            }
            if (FileData != null && FileData.Length > CONTENT_Length_LIMIT)
            {
                throw new WXException(1, "FileData is invalid.");
            }
            return true;
        }
    }
}
