using Google.ProtocolBuffers;
using MicroMsg.sdk.protobuf;

namespace MicroMsg.sdk
{
    public class WXFileMessage : WXBaseMessage
    {
        private const int CONTENT_LENGTH_LIMIT = 0xa00000;
        public byte[] FileData { get; set; } = new byte[0];
        public string FileName { get; set; } = string.Empty;

        public WXFileMessage(byte[] fileData, string fileName)
        {
            FileData = fileData;
            FileName = fileName;
        }

        public WXFileMessage()
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
                if (ep.FileMessage != null)
                {
                    FileData = ep.FileMessage.FileData.ToByteArray();
                    FileName = ep.FileMessage.FileName;
                }
            }
        }

        internal override object ToProto()
        {
            WXFileMessageP.Builder builder = WXFileMessageP.CreateBuilder();
            builder.FileData = ByteString.CopyFrom(FileData);
            builder.FileName = FileName;
            WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
            builder2.Type = (uint)Type();
            builder2.Title = Title;
            builder2.Description = Description;
            builder2.ThumbData = ByteString.CopyFrom(ThumbData);
            builder2.FileMessage = builder.Build();
            return builder2.Build();
        }

        public override int Type()
        {
            return TYPE_FILE;
        }

        internal override bool ValidateData()
        {
            if (!base.ValidateData())
            {
                return false;
            }
            if (string.IsNullOrEmpty(FileName))
            {
                throw new WXException(1, "FileName is invalid.");
            }
            if (FileData != null && (FileData.Length == 0 || FileData.Length > CONTENT_LENGTH_LIMIT))
            {
                throw new WXException(1, "FileData is invalid.");
            }
            return true;
        }
    }





}
