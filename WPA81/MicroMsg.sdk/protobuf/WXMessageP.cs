using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXMessageP : GeneratedMessageLite<WXMessageP, WXMessageP.Builder>
    {
        
        private static readonly string[] _wXMessagePFieldNames = new string[] { "AppExtendMessage", "Description", "EmojiMessage", "FileMessage", "ImageMessage", "MusicMessage", "TextMessage", "ThumbData", "Title", "Type", "VideoMessage", "WebpageMessage" };
        private static readonly uint[] _wXMessagePFieldTags = new uint[] { 0x62, 0x1a, 0x2a, 50, 0x3a, 0x42, 0x4a, 0x22, 0x12, 8, 0x52, 90 };
        private WXAppExtendMessageP appExtendMessage_;
        public const int AppExtendMessageFieldNumber = 12;
        private static readonly WXMessageP defaultInstance = new WXMessageP().MakeReadOnly();
        private string description_ = "";
        public const int DescriptionFieldNumber = 3;
        private WXEmojiMessageP emojiMessage_;
        public const int EmojiMessageFieldNumber = 5;
        private WXFileMessageP fileMessage_;
        public const int FileMessageFieldNumber = 6;
        private bool hasAppExtendMessage;
        private bool hasDescription;
        private bool hasEmojiMessage;
        private bool hasFileMessage;
        private bool hasImageMessage;
        private bool hasMusicMessage;
        private bool hasTextMessage;
        private bool hasThumbData;
        private bool hasTitle;
        private bool hasType;
        private bool hasVideoMessage;
        private bool hasWebpageMessage;
        private WXImageMessageP imageMessage_;
        public const int ImageMessageFieldNumber = 7;
        private int memoizedSerializedSize = -1;
        private WXMusicMessageP musicMessage_;
        public const int MusicMessageFieldNumber = 8;
        private WXTextMessageP textMessage_;
        public const int TextMessageFieldNumber = 9;
        private ByteString thumbData_ = ByteString.Empty;
        public const int ThumbDataFieldNumber = 4;
        private string title_ = "";
        public const int TitleFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 1;
        private WXVideoMessageP videoMessage_;
        public const int VideoMessageFieldNumber = 10;
        private WXWebpageMessageP webpageMessage_;
        public const int WebpageMessageFieldNumber = 11;

        
        static WXMessageP()
        {
            object.ReferenceEquals(Proto.WXMessageP.Descriptor, null);
        }

        private WXMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXMessageP ep = obj as WXMessageP;
            if (ep == null)
            {
                return false;
            }
            if ((this.hasType != ep.hasType) || (this.hasType && !this.type_.Equals(ep.type_)))
            {
                return false;
            }
            if ((this.hasTitle != ep.hasTitle) || (this.hasTitle && !this.title_.Equals(ep.title_)))
            {
                return false;
            }
            if ((this.hasDescription != ep.hasDescription) || (this.hasDescription && !this.description_.Equals(ep.description_)))
            {
                return false;
            }
            if ((this.hasThumbData != ep.hasThumbData) || (this.hasThumbData && !this.thumbData_.Equals(ep.thumbData_)))
            {
                return false;
            }
            if ((this.hasEmojiMessage != ep.hasEmojiMessage) || (this.hasEmojiMessage && !this.emojiMessage_.Equals(ep.emojiMessage_)))
            {
                return false;
            }
            if ((this.hasFileMessage != ep.hasFileMessage) || (this.hasFileMessage && !this.fileMessage_.Equals(ep.fileMessage_)))
            {
                return false;
            }
            if ((this.hasImageMessage != ep.hasImageMessage) || (this.hasImageMessage && !this.imageMessage_.Equals(ep.imageMessage_)))
            {
                return false;
            }
            if ((this.hasMusicMessage != ep.hasMusicMessage) || (this.hasMusicMessage && !this.musicMessage_.Equals(ep.musicMessage_)))
            {
                return false;
            }
            if ((this.hasTextMessage != ep.hasTextMessage) || (this.hasTextMessage && !this.textMessage_.Equals(ep.textMessage_)))
            {
                return false;
            }
            if ((this.hasVideoMessage != ep.hasVideoMessage) || (this.hasVideoMessage && !this.videoMessage_.Equals(ep.videoMessage_)))
            {
                return false;
            }
            if ((this.hasWebpageMessage != ep.hasWebpageMessage) || (this.hasWebpageMessage && !this.webpageMessage_.Equals(ep.webpageMessage_)))
            {
                return false;
            }
            return ((this.hasAppExtendMessage == ep.hasAppExtendMessage) && (!this.hasAppExtendMessage || this.appExtendMessage_.Equals(ep.appExtendMessage_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasTitle)
            {
                hashCode ^= this.title_.GetHashCode();
            }
            if (this.hasDescription)
            {
                hashCode ^= this.description_.GetHashCode();
            }
            if (this.hasThumbData)
            {
                hashCode ^= this.thumbData_.GetHashCode();
            }
            if (this.hasEmojiMessage)
            {
                hashCode ^= this.emojiMessage_.GetHashCode();
            }
            if (this.hasFileMessage)
            {
                hashCode ^= this.fileMessage_.GetHashCode();
            }
            if (this.hasImageMessage)
            {
                hashCode ^= this.imageMessage_.GetHashCode();
            }
            if (this.hasMusicMessage)
            {
                hashCode ^= this.musicMessage_.GetHashCode();
            }
            if (this.hasTextMessage)
            {
                hashCode ^= this.textMessage_.GetHashCode();
            }
            if (this.hasVideoMessage)
            {
                hashCode ^= this.videoMessage_.GetHashCode();
            }
            if (this.hasWebpageMessage)
            {
                hashCode ^= this.webpageMessage_.GetHashCode();
            }
            if (this.hasAppExtendMessage)
            {
                hashCode ^= this.appExtendMessage_.GetHashCode();
            }
            return hashCode;
        }

        private WXMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("Title", this.hasTitle, this.title_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("Description", this.hasDescription, this.description_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("ThumbData", this.hasThumbData, this.thumbData_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("EmojiMessage", this.hasEmojiMessage, this.emojiMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("FileMessage", this.hasFileMessage, this.fileMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("ImageMessage", this.hasImageMessage, this.imageMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("MusicMessage", this.hasMusicMessage, this.musicMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("TextMessage", this.hasTextMessage, this.textMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("VideoMessage", this.hasVideoMessage, this.videoMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("WebpageMessage", this.hasWebpageMessage, this.webpageMessage_, writer);
            GeneratedMessageLite<WXMessageP, Builder>.PrintField("AppExtendMessage", this.hasAppExtendMessage, this.appExtendMessage_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXMessagePFieldNames;
            if (this.hasType)
            {
                output.WriteUInt32(1, strArray[9], this.Type);
            }
            if (this.hasTitle)
            {
                output.WriteString(2, strArray[8], this.Title);
            }
            if (this.hasDescription)
            {
                output.WriteString(3, strArray[1], this.Description);
            }
            if (this.hasThumbData)
            {
                output.WriteBytes(4, strArray[7], this.ThumbData);
            }
            if (this.hasEmojiMessage)
            {
                output.WriteMessage(5, strArray[2], this.EmojiMessage);
            }
            if (this.hasFileMessage)
            {
                output.WriteMessage(6, strArray[3], this.FileMessage);
            }
            if (this.hasImageMessage)
            {
                output.WriteMessage(7, strArray[4], this.ImageMessage);
            }
            if (this.hasMusicMessage)
            {
                output.WriteMessage(8, strArray[5], this.MusicMessage);
            }
            if (this.hasTextMessage)
            {
                output.WriteMessage(9, strArray[6], this.TextMessage);
            }
            if (this.hasVideoMessage)
            {
                output.WriteMessage(10, strArray[10], this.VideoMessage);
            }
            if (this.hasWebpageMessage)
            {
                output.WriteMessage(11, strArray[11], this.WebpageMessage);
            }
            if (this.hasAppExtendMessage)
            {
                output.WriteMessage(12, strArray[0], this.AppExtendMessage);
            }
        }

        // Properties
        public WXAppExtendMessageP AppExtendMessage
        {
            get
            {
                return (this.appExtendMessage_ ?? WXAppExtendMessageP.DefaultInstance);
            }
        }

        public static WXMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXMessageP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string Description
        {
            get
            {
                return this.description_;
            }
        }

        public WXEmojiMessageP EmojiMessage
        {
            get
            {
                return (this.emojiMessage_ ?? WXEmojiMessageP.DefaultInstance);
            }
        }

        public WXFileMessageP FileMessage
        {
            get
            {
                return (this.fileMessage_ ?? WXFileMessageP.DefaultInstance);
            }
        }

        public WXImageMessageP ImageMessage
        {
            get
            {
                return (this.imageMessage_ ?? WXImageMessageP.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasType)
                {
                    return false;
                }
                return true;
            }
        }

        public WXMusicMessageP MusicMessage
        {
            get
            {
                return (this.musicMessage_ ?? WXMusicMessageP.DefaultInstance);
            }
        }

        public override int SerializedSize
        {
            get
            {
                int memoizedSerializedSize = this.memoizedSerializedSize;
                if (memoizedSerializedSize == -1)
                {
                    memoizedSerializedSize = 0;
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Type);
                    }
                    if (this.hasTitle)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Title);
                    }
                    if (this.hasDescription)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.Description);
                    }
                    if (this.hasThumbData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(4, this.ThumbData);
                    }
                    if (this.hasEmojiMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(5, this.EmojiMessage);
                    }
                    if (this.hasFileMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.FileMessage);
                    }
                    if (this.hasImageMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.ImageMessage);
                    }
                    if (this.hasMusicMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.MusicMessage);
                    }
                    if (this.hasTextMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.TextMessage);
                    }
                    if (this.hasVideoMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.VideoMessage);
                    }
                    if (this.hasWebpageMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(11, this.WebpageMessage);
                    }
                    if (this.hasAppExtendMessage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(12, this.AppExtendMessage);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public WXTextMessageP TextMessage
        {
            get
            {
                return (this.textMessage_ ?? WXTextMessageP.DefaultInstance);
            }
        }

        protected override WXMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        public ByteString ThumbData
        {
            get
            {
                return this.thumbData_;
            }
        }

        public string Title
        {
            get
            {
                return this.title_;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        public WXVideoMessageP VideoMessage
        {
            get
            {
                return (this.videoMessage_ ?? WXVideoMessageP.DefaultInstance);
            }
        }

        public WXWebpageMessageP WebpageMessage
        {
            get
            {
                return (this.webpageMessage_ ?? WXWebpageMessageP.DefaultInstance);
            }
        }

        // Nested Types
        [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<WXMessageP, WXMessageP.Builder>
        {
            
            private WXMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXMessageP.Builder Clear()
            {
                this.result = WXMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXMessageP.Builder ClearAppExtendMessage()
            {
                this.PrepareBuilder();
                this.result.hasAppExtendMessage = false;
                this.result.appExtendMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearDescription()
            {
                this.PrepareBuilder();
                this.result.hasDescription = false;
                this.result.description_ = "";
                return this;
            }

            public WXMessageP.Builder ClearEmojiMessage()
            {
                this.PrepareBuilder();
                this.result.hasEmojiMessage = false;
                this.result.emojiMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearFileMessage()
            {
                this.PrepareBuilder();
                this.result.hasFileMessage = false;
                this.result.fileMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearImageMessage()
            {
                this.PrepareBuilder();
                this.result.hasImageMessage = false;
                this.result.imageMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearMusicMessage()
            {
                this.PrepareBuilder();
                this.result.hasMusicMessage = false;
                this.result.musicMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearTextMessage()
            {
                this.PrepareBuilder();
                this.result.hasTextMessage = false;
                this.result.textMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearThumbData()
            {
                this.PrepareBuilder();
                this.result.hasThumbData = false;
                this.result.thumbData_ = ByteString.Empty;
                return this;
            }

            public WXMessageP.Builder ClearTitle()
            {
                this.PrepareBuilder();
                this.result.hasTitle = false;
                this.result.title_ = "";
                return this;
            }

            public WXMessageP.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public WXMessageP.Builder ClearVideoMessage()
            {
                this.PrepareBuilder();
                this.result.hasVideoMessage = false;
                this.result.videoMessage_ = null;
                return this;
            }

            public WXMessageP.Builder ClearWebpageMessage()
            {
                this.PrepareBuilder();
                this.result.hasWebpageMessage = false;
                this.result.webpageMessage_ = null;
                return this;
            }

            public override WXMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXMessageP.Builder(this.result);
                }
                return new WXMessageP.Builder().MergeFrom(this.result);
            }

            public WXMessageP.Builder MergeAppExtendMessage(WXAppExtendMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAppExtendMessage && (this.result.appExtendMessage_ != WXAppExtendMessageP.DefaultInstance))
                {
                    this.result.appExtendMessage_ = WXAppExtendMessageP.CreateBuilder(this.result.appExtendMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.appExtendMessage_ = value;
                }
                this.result.hasAppExtendMessage = true;
                return this;
            }

            public WXMessageP.Builder MergeEmojiMessage(WXEmojiMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasEmojiMessage && (this.result.emojiMessage_ != WXEmojiMessageP.DefaultInstance))
                {
                    this.result.emojiMessage_ = WXEmojiMessageP.CreateBuilder(this.result.emojiMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.emojiMessage_ = value;
                }
                this.result.hasEmojiMessage = true;
                return this;
            }

            public WXMessageP.Builder MergeFileMessage(WXFileMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasFileMessage && (this.result.fileMessage_ != WXFileMessageP.DefaultInstance))
                {
                    this.result.fileMessage_ = WXFileMessageP.CreateBuilder(this.result.fileMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.fileMessage_ = value;
                }
                this.result.hasFileMessage = true;
                return this;
            }

            public override WXMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXMessageP)
                {
                    return this.MergeFrom((WXMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXMessageP.Builder MergeFrom(WXMessageP other)
            {
                return this;
            }

            public override WXMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXMessageP._wXMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXMessageP._wXMessagePFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x1a:
                            {
                                this.result.hasDescription = input.ReadString(ref this.result.description_);
                                continue;
                            }
                        case 0x22:
                            {
                                this.result.hasThumbData = input.ReadBytes(ref this.result.thumbData_);
                                continue;
                            }
                        case 0x2a:
                            {
                                WXEmojiMessageP.Builder builder = WXEmojiMessageP.CreateBuilder();
                                if (this.result.hasEmojiMessage)
                                {
                                    builder.MergeFrom(this.EmojiMessage);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.EmojiMessage = builder.BuildPartial();
                                continue;
                            }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                            {
                                this.result.hasType = input.ReadUInt32(ref this.result.type_);
                                continue;
                            }
                        case 0x12:
                            {
                                this.result.hasTitle = input.ReadString(ref this.result.title_);
                                continue;
                            }
                        case 50:
                            {
                                WXFileMessageP.Builder builder2 = WXFileMessageP.CreateBuilder();
                                if (this.result.hasFileMessage)
                                {
                                    builder2.MergeFrom(this.FileMessage);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.FileMessage = builder2.BuildPartial();
                                continue;
                            }
                        case 0x3a:
                            {
                                WXImageMessageP.Builder builder3 = WXImageMessageP.CreateBuilder();
                                if (this.result.hasImageMessage)
                                {
                                    builder3.MergeFrom(this.ImageMessage);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.ImageMessage = builder3.BuildPartial();
                                continue;
                            }
                        case 0x42:
                            {
                                WXMusicMessageP.Builder builder4 = WXMusicMessageP.CreateBuilder();
                                if (this.result.hasMusicMessage)
                                {
                                    builder4.MergeFrom(this.MusicMessage);
                                }
                                input.ReadMessage(builder4, extensionRegistry);
                                this.MusicMessage = builder4.BuildPartial();
                                continue;
                            }
                        case 0x4a:
                            {
                                WXTextMessageP.Builder builder5 = WXTextMessageP.CreateBuilder();
                                if (this.result.hasTextMessage)
                                {
                                    builder5.MergeFrom(this.TextMessage);
                                }
                                input.ReadMessage(builder5, extensionRegistry);
                                this.TextMessage = builder5.BuildPartial();
                                continue;
                            }
                        case 0x52:
                            {
                                WXVideoMessageP.Builder builder6 = WXVideoMessageP.CreateBuilder();
                                if (this.result.hasVideoMessage)
                                {
                                    builder6.MergeFrom(this.VideoMessage);
                                }
                                input.ReadMessage(builder6, extensionRegistry);
                                this.VideoMessage = builder6.BuildPartial();
                                continue;
                            }
                        case 90:
                            {
                                WXWebpageMessageP.Builder builder7 = WXWebpageMessageP.CreateBuilder();
                                if (this.result.hasWebpageMessage)
                                {
                                    builder7.MergeFrom(this.WebpageMessage);
                                }
                                input.ReadMessage(builder7, extensionRegistry);
                                this.WebpageMessage = builder7.BuildPartial();
                                continue;
                            }
                        case 0x62:
                            {
                                WXAppExtendMessageP.Builder builder8 = WXAppExtendMessageP.CreateBuilder();
                                if (this.result.hasAppExtendMessage)
                                {
                                    builder8.MergeFrom(this.AppExtendMessage);
                                }
                                input.ReadMessage(builder8, extensionRegistry);
                                this.AppExtendMessage = builder8.BuildPartial();
                                continue;
                            }
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            public WXMessageP.Builder MergeImageMessage(WXImageMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasImageMessage && (this.result.imageMessage_ != WXImageMessageP.DefaultInstance))
                {
                    this.result.imageMessage_ = WXImageMessageP.CreateBuilder(this.result.imageMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.imageMessage_ = value;
                }
                this.result.hasImageMessage = true;
                return this;
            }

            public WXMessageP.Builder MergeMusicMessage(WXMusicMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMusicMessage && (this.result.musicMessage_ != WXMusicMessageP.DefaultInstance))
                {
                    this.result.musicMessage_ = WXMusicMessageP.CreateBuilder(this.result.musicMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.musicMessage_ = value;
                }
                this.result.hasMusicMessage = true;
                return this;
            }

            public WXMessageP.Builder MergeTextMessage(WXTextMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasTextMessage && (this.result.textMessage_ != WXTextMessageP.DefaultInstance))
                {
                    this.result.textMessage_ = WXTextMessageP.CreateBuilder(this.result.textMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.textMessage_ = value;
                }
                this.result.hasTextMessage = true;
                return this;
            }

            public WXMessageP.Builder MergeVideoMessage(WXVideoMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasVideoMessage && (this.result.videoMessage_ != WXVideoMessageP.DefaultInstance))
                {
                    this.result.videoMessage_ = WXVideoMessageP.CreateBuilder(this.result.videoMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.videoMessage_ = value;
                }
                this.result.hasVideoMessage = true;
                return this;
            }

            public WXMessageP.Builder MergeWebpageMessage(WXWebpageMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasWebpageMessage && (this.result.webpageMessage_ != WXWebpageMessageP.DefaultInstance))
                {
                    this.result.webpageMessage_ = WXWebpageMessageP.CreateBuilder(this.result.webpageMessage_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.webpageMessage_ = value;
                }
                this.result.hasWebpageMessage = true;
                return this;
            }

            private WXMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXMessageP result = this.result;
                    this.result = new WXMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXMessageP.Builder SetAppExtendMessage(WXAppExtendMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppExtendMessage = true;
                this.result.appExtendMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetAppExtendMessage(WXAppExtendMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAppExtendMessage = true;
                this.result.appExtendMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetDescription(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasDescription = true;
                this.result.description_ = value;
                return this;
            }

            public WXMessageP.Builder SetEmojiMessage(WXEmojiMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasEmojiMessage = true;
                this.result.emojiMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetEmojiMessage(WXEmojiMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasEmojiMessage = true;
                this.result.emojiMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetFileMessage(WXFileMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFileMessage = true;
                this.result.fileMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetFileMessage(WXFileMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasFileMessage = true;
                this.result.fileMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetImageMessage(WXImageMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImageMessage = true;
                this.result.imageMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetImageMessage(WXImageMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasImageMessage = true;
                this.result.imageMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetMusicMessage(WXMusicMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMusicMessage = true;
                this.result.musicMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetMusicMessage(WXMusicMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMusicMessage = true;
                this.result.musicMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetTextMessage(WXTextMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTextMessage = true;
                this.result.textMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetTextMessage(WXTextMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasTextMessage = true;
                this.result.textMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetThumbData(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasThumbData = true;
                this.result.thumbData_ = value;
                return this;
            }

            public WXMessageP.Builder SetTitle(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTitle = true;
                this.result.title_ = value;
                return this;
            }

            public WXMessageP.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            public WXMessageP.Builder SetVideoMessage(WXVideoMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVideoMessage = true;
                this.result.videoMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetVideoMessage(WXVideoMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasVideoMessage = true;
                this.result.videoMessage_ = builderForValue.Build();
                return this;
            }

            public WXMessageP.Builder SetWebpageMessage(WXWebpageMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWebpageMessage = true;
                this.result.webpageMessage_ = value;
                return this;
            }

            public WXMessageP.Builder SetWebpageMessage(WXWebpageMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasWebpageMessage = true;
                this.result.webpageMessage_ = builderForValue.Build();
                return this;
            }

            // Properties
            public WXAppExtendMessageP AppExtendMessage
            {
                get
                {
                    return this.result.AppExtendMessage;
                }
                set
                {
                    this.SetAppExtendMessage(value);
                }
            }

            public override WXMessageP DefaultInstanceForType
            {
                get
                {
                    return WXMessageP.DefaultInstance;
                }
            }

            public string Description
            {
                get
                {
                    return this.result.Description;
                }
                set
                {
                    this.SetDescription(value);
                }
            }

            public WXEmojiMessageP EmojiMessage
            {
                get
                {
                    return this.result.EmojiMessage;
                }
                set
                {
                    this.SetEmojiMessage(value);
                }
            }

            public WXFileMessageP FileMessage
            {
                get
                {
                    return this.result.FileMessage;
                }
                set
                {
                    this.SetFileMessage(value);
                }
            }

            public WXImageMessageP ImageMessage
            {
                get
                {
                    return this.result.ImageMessage;
                }
                set
                {
                    this.SetImageMessage(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public WXMusicMessageP MusicMessage
            {
                get
                {
                    return this.result.MusicMessage;
                }
                set
                {
                    this.SetMusicMessage(value);
                }
            }

            public WXTextMessageP TextMessage
            {
                get
                {
                    return this.result.TextMessage;
                }
                set
                {
                    this.SetTextMessage(value);
                }
            }

            protected override WXMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public ByteString ThumbData
            {
                get
                {
                    return this.result.ThumbData;
                }
                set
                {
                    this.SetThumbData(value);
                }
            }

            public string Title
            {
                get
                {
                    return this.result.Title;
                }
                set
                {
                    this.SetTitle(value);
                }
            }

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }

            public WXVideoMessageP VideoMessage
            {
                get
                {
                    return this.result.VideoMessage;
                }
                set
                {
                    this.SetVideoMessage(value);
                }
            }

            public WXWebpageMessageP WebpageMessage
            {
                get
                {
                    return this.result.WebpageMessage;
                }
                set
                {
                    this.SetWebpageMessage(value);
                }
            }
        }
    }
}
