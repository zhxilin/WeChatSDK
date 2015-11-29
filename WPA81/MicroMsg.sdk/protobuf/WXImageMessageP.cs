using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXImageMessageP : GeneratedMessageLite<WXImageMessageP, WXImageMessageP.Builder>
    {
        
        private static readonly string[] _wXImageMessagePFieldNames = new string[] { "ImageData", "ImageUrl" };
        private static readonly uint[] _wXImageMessagePFieldTags = new uint[] { 10, 0x1a };
        private static readonly WXImageMessageP defaultInstance = new WXImageMessageP().MakeReadOnly();
        private bool hasImageData;
        private bool hasImageUrl;
        private ByteString imageData_ = ByteString.Empty;
        public const int ImageDataFieldNumber = 1;
        private string imageUrl_ = "";
        public const int ImageUrlFieldNumber = 3;
        private int memoizedSerializedSize = -1;

        
        static WXImageMessageP()
        {
            object.ReferenceEquals(Proto.WXImageMessageP.Descriptor, null);
        }

        private WXImageMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXImageMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXImageMessageP ep = obj as WXImageMessageP;
            if (ep == null)
            {
                return false;
            }
            if ((this.hasImageData != ep.hasImageData) || (this.hasImageData && !this.imageData_.Equals(ep.imageData_)))
            {
                return false;
            }
            return ((this.hasImageUrl == ep.hasImageUrl) && (!this.hasImageUrl || this.imageUrl_.Equals(ep.imageUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasImageData)
            {
                hashCode ^= this.imageData_.GetHashCode();
            }
            if (this.hasImageUrl)
            {
                hashCode ^= this.imageUrl_.GetHashCode();
            }
            return hashCode;
        }

        private WXImageMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXImageMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXImageMessageP, Builder>.PrintField("ImageData", this.hasImageData, this.imageData_, writer);
            GeneratedMessageLite<WXImageMessageP, Builder>.PrintField("ImageUrl", this.hasImageUrl, this.imageUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXImageMessagePFieldNames;
            if (this.hasImageData)
            {
                output.WriteBytes(1, strArray[0], this.ImageData);
            }
            if (this.hasImageUrl)
            {
                output.WriteString(3, strArray[1], this.ImageUrl);
            }
        }

        // Properties
        public static WXImageMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXImageMessageP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString ImageData
        {
            get
            {
                return this.imageData_;
            }
        }

        public string ImageUrl
        {
            get
            {
                return this.imageUrl_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                return true;
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
                    if (this.hasImageData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(1, this.ImageData);
                    }
                    if (this.hasImageUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.ImageUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXImageMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated, DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<WXImageMessageP, WXImageMessageP.Builder>
        {
            
            private WXImageMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXImageMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXImageMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXImageMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXImageMessageP.Builder Clear()
            {
                this.result = WXImageMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXImageMessageP.Builder ClearImageData()
            {
                this.PrepareBuilder();
                this.result.hasImageData = false;
                this.result.imageData_ = ByteString.Empty;
                return this;
            }

            public WXImageMessageP.Builder ClearImageUrl()
            {
                this.PrepareBuilder();
                this.result.hasImageUrl = false;
                this.result.imageUrl_ = "";
                return this;
            }

            public override WXImageMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXImageMessageP.Builder(this.result);
                }
                return new WXImageMessageP.Builder().MergeFrom(this.result);
            }

            public override WXImageMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXImageMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXImageMessageP)
                {
                    return this.MergeFrom((WXImageMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXImageMessageP.Builder MergeFrom(WXImageMessageP other)
            {
                return this;
            }

            public override WXImageMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXImageMessageP._wXImageMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXImageMessageP._wXImageMessagePFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 10:
                            {
                                this.result.hasImageData = input.ReadBytes(ref this.result.imageData_);
                                continue;
                            }
                        case 0x1a:
                            break;

                        default:
                            {
                                if (WireFormat.IsEndGroupTag(num))
                                {
                                    return this;
                                }
                                this.ParseUnknownField(input, extensionRegistry, num, str);
                                continue;
                            }
                    }
                    this.result.hasImageUrl = input.ReadString(ref this.result.imageUrl_);
                }
                return this;
            }

            private WXImageMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXImageMessageP result = this.result;
                    this.result = new WXImageMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXImageMessageP.Builder SetImageData(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImageData = true;
                this.result.imageData_ = value;
                return this;
            }

            public WXImageMessageP.Builder SetImageUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasImageUrl = true;
                this.result.imageUrl_ = value;
                return this;
            }

            // Properties
            public override WXImageMessageP DefaultInstanceForType
            {
                get
                {
                    return WXImageMessageP.DefaultInstance;
                }
            }

            public ByteString ImageData
            {
                get
                {
                    return this.result.ImageData;
                }
                set
                {
                    this.SetImageData(value);
                }
            }

            public string ImageUrl
            {
                get
                {
                    return this.result.ImageUrl;
                }
                set
                {
                    this.SetImageUrl(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXImageMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override WXImageMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}
