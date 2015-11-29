using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXVideoMessageP : GeneratedMessageLite<WXVideoMessageP, WXVideoMessageP.Builder>
    {
        
        private static readonly string[] _wXVideoMessagePFieldNames = new string[] { "VideoLowBandUrl", "VideoUrl" };
        private static readonly uint[] _wXVideoMessagePFieldTags = new uint[] { 0x12, 10 };
        private static readonly WXVideoMessageP defaultInstance = new WXVideoMessageP().MakeReadOnly();
        private bool hasVideoLowBandUrl;
        private bool hasVideoUrl;
        private int memoizedSerializedSize = -1;
        private string videoLowBandUrl_ = "";
        public const int VideoLowBandUrlFieldNumber = 2;
        private string videoUrl_ = "";
        public const int VideoUrlFieldNumber = 1;

        
        static WXVideoMessageP()
        {
            object.ReferenceEquals(Proto.WXVideoMessageP.Descriptor, null);
        }

        private WXVideoMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXVideoMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXVideoMessageP ep = obj as WXVideoMessageP;
            if (ep == null)
            {
                return false;
            }
            if ((this.hasVideoUrl != ep.hasVideoUrl) || (this.hasVideoUrl && !this.videoUrl_.Equals(ep.videoUrl_)))
            {
                return false;
            }
            return ((this.hasVideoLowBandUrl == ep.hasVideoLowBandUrl) && (!this.hasVideoLowBandUrl || this.videoLowBandUrl_.Equals(ep.videoLowBandUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasVideoUrl)
            {
                hashCode ^= this.videoUrl_.GetHashCode();
            }
            if (this.hasVideoLowBandUrl)
            {
                hashCode ^= this.videoLowBandUrl_.GetHashCode();
            }
            return hashCode;
        }

        private WXVideoMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXVideoMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXVideoMessageP, Builder>.PrintField("VideoUrl", this.hasVideoUrl, this.videoUrl_, writer);
            GeneratedMessageLite<WXVideoMessageP, Builder>.PrintField("VideoLowBandUrl", this.hasVideoLowBandUrl, this.videoLowBandUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXVideoMessagePFieldNames;
            if (this.hasVideoUrl)
            {
                output.WriteString(1, strArray[1], this.VideoUrl);
            }
            if (this.hasVideoLowBandUrl)
            {
                output.WriteString(2, strArray[0], this.VideoLowBandUrl);
            }
        }

        // Properties
        public static WXVideoMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXVideoMessageP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
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
                    if (this.hasVideoUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.VideoUrl);
                    }
                    if (this.hasVideoLowBandUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.VideoLowBandUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXVideoMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string VideoLowBandUrl
        {
            get
            {
                return this.videoLowBandUrl_;
            }
        }

        public string VideoUrl
        {
            get
            {
                return this.videoUrl_;
            }
        }

        // Nested Types
        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<WXVideoMessageP, WXVideoMessageP.Builder>
        {
            
            private WXVideoMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXVideoMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXVideoMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXVideoMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXVideoMessageP.Builder Clear()
            {
                this.result = WXVideoMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXVideoMessageP.Builder ClearVideoLowBandUrl()
            {
                this.PrepareBuilder();
                this.result.hasVideoLowBandUrl = false;
                this.result.videoLowBandUrl_ = "";
                return this;
            }

            public WXVideoMessageP.Builder ClearVideoUrl()
            {
                this.PrepareBuilder();
                this.result.hasVideoUrl = false;
                this.result.videoUrl_ = "";
                return this;
            }

            public override WXVideoMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXVideoMessageP.Builder(this.result);
                }
                return new WXVideoMessageP.Builder().MergeFrom(this.result);
            }

            public override WXVideoMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXVideoMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXVideoMessageP)
                {
                    return this.MergeFrom((WXVideoMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXVideoMessageP.Builder MergeFrom(WXVideoMessageP other)
            {
                return this;
            }

            public override WXVideoMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXVideoMessageP._wXVideoMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXVideoMessageP._wXVideoMessagePFieldTags[index];
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
                                this.result.hasVideoUrl = input.ReadString(ref this.result.videoUrl_);
                                continue;
                            }
                        case 0x12:
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
                    this.result.hasVideoLowBandUrl = input.ReadString(ref this.result.videoLowBandUrl_);
                }
                return this;
            }

            private WXVideoMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXVideoMessageP result = this.result;
                    this.result = new WXVideoMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXVideoMessageP.Builder SetVideoLowBandUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVideoLowBandUrl = true;
                this.result.videoLowBandUrl_ = value;
                return this;
            }

            public WXVideoMessageP.Builder SetVideoUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasVideoUrl = true;
                this.result.videoUrl_ = value;
                return this;
            }

            // Properties
            public override WXVideoMessageP DefaultInstanceForType
            {
                get
                {
                    return WXVideoMessageP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXVideoMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override WXVideoMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string VideoLowBandUrl
            {
                get
                {
                    return this.result.VideoLowBandUrl;
                }
                set
                {
                    this.SetVideoLowBandUrl(value);
                }
            }

            public string VideoUrl
            {
                get
                {
                    return this.result.VideoUrl;
                }
                set
                {
                    this.SetVideoUrl(value);
                }
            }
        }
    }
}
