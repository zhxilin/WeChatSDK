namespace MicroMsg.sdk
{
    public abstract class WXBaseMessage
    {
        private const int TITLE_LENGTH_LIMIT = 0x200;
        private const int DESCRIPTION_LENGTH_LIMIT = 0x400;
        private const int THUMB_LENGTH_LIMIT = 0x8000;

        public const int TYPE_UNKNOWN = 0;
        public const int TYPE_TEXT = 1;
        public const int TYPE_IMAGE = 2;
        public const int TYPE_MUSIC = 3;
        public const int TYPE_VIDEO = 4;
        public const int TYPE_URL = 5;
        public const int TYPE_FILE = 6;
        public const int TYPE_APPDATA = 7;
        public const int TYPE_EMOJI = 8;
        public string Description { get; set; } = string.Empty;
        public byte[] ThumbData { get; set; } = new byte[0];
        public string Title { get; set; } = string.Empty;

        internal static WXBaseMessage CreateMessage(int type)
        {
            switch (type)
            {
                case TYPE_TEXT:
                    return new WXTextMessage();
                case TYPE_IMAGE:
                    return new WXImageMessage();
                case TYPE_MUSIC:
                    return new WXMusicMessage();
                case TYPE_VIDEO:
                    return new WXVideoMessage();
                case TYPE_URL:
                    return new WXWebpageMessage();
                case TYPE_FILE:
                    return new WXFileMessage();
                case TYPE_APPDATA:
                    return new WXAppExtendMessage();
                case TYPE_EMOJI:
                    return new WXEmojiMessage();
            }
            return null;
        }

        internal abstract void FromProto(object protoObj);
        public void SetThumbImage(byte[] thumbData)
        {
            ThumbData = thumbData;
        }

        internal abstract object ToProto();
        public abstract int Type();
        internal virtual bool ValidateData()
        {
            if (Title != null && Title.Length > TITLE_LENGTH_LIMIT)
            {
                throw new WXException(1, "Title is invalid.");
            }
            if (Description != null && Description.Length > DESCRIPTION_LENGTH_LIMIT)
            {
                throw new WXException(1, "Description is invalid.");
            }
            if (ThumbData != null && ThumbData.Length > THUMB_LENGTH_LIMIT)
            {
                throw new WXException(1, "ThumbData is invalid.");
            }
            return true;
        }
    }
}
