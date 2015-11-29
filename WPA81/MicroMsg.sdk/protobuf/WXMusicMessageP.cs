using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXMusicMessageP : GeneratedMessageLite<WXMusicMessageP, WXMusicMessageP.Builder>
    {
        
        private static readonly string[] _wXMusicMessagePFieldNames = new string[] { "MusicLowBandUrl", "MusicUrl" };
        private static readonly uint[] _wXMusicMessagePFieldTags = new uint[] { 0x12, 10 };
        private static readonly WXMusicMessageP defaultInstance = new WXMusicMessageP().MakeReadOnly();
        private bool hasMusicLowBandUrl;
        private bool hasMusicUrl;
        private int memoizedSerializedSize = -1;
        private string musicLowBandUrl_ = "";
        public const int MusicLowBandUrlFieldNumber = 2;
        private string musicUrl_ = "";
        public const int MusicUrlFieldNumber = 1;

        
        static WXMusicMessageP()
        {
            object.ReferenceEquals(Proto.WXMusicMessageP.Descriptor, null);
        }

        private WXMusicMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXMusicMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXMusicMessageP ep = obj as WXMusicMessageP;
            if (ep == null)
            {
                return false;
            }
            if ((this.hasMusicUrl != ep.hasMusicUrl) || (this.hasMusicUrl && !this.musicUrl_.Equals(ep.musicUrl_)))
            {
                return false;
            }
            return ((this.hasMusicLowBandUrl == ep.hasMusicLowBandUrl) && (!this.hasMusicLowBandUrl || this.musicLowBandUrl_.Equals(ep.musicLowBandUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasMusicUrl)
            {
                hashCode ^= this.musicUrl_.GetHashCode();
            }
            if (this.hasMusicLowBandUrl)
            {
                hashCode ^= this.musicLowBandUrl_.GetHashCode();
            }
            return hashCode;
        }

        private WXMusicMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXMusicMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXMusicMessageP, Builder>.PrintField("MusicUrl", this.hasMusicUrl, this.musicUrl_, writer);
            GeneratedMessageLite<WXMusicMessageP, Builder>.PrintField("MusicLowBandUrl", this.hasMusicLowBandUrl, this.musicLowBandUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXMusicMessagePFieldNames;
            if (this.hasMusicUrl)
            {
                output.WriteString(1, strArray[1], this.MusicUrl);
            }
            if (this.hasMusicLowBandUrl)
            {
                output.WriteString(2, strArray[0], this.MusicLowBandUrl);
            }
        }

        // Properties
        public static WXMusicMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXMusicMessageP DefaultInstanceForType
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

        public string MusicLowBandUrl
        {
            get
            {
                return this.musicLowBandUrl_;
            }
        }

        public string MusicUrl
        {
            get
            {
                return this.musicUrl_;
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
                    if (this.hasMusicUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.MusicUrl);
                    }
                    if (this.hasMusicLowBandUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.MusicLowBandUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXMusicMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<WXMusicMessageP, WXMusicMessageP.Builder>
        {
            
            private WXMusicMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXMusicMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXMusicMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXMusicMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXMusicMessageP.Builder Clear()
            {
                this.result = WXMusicMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXMusicMessageP.Builder ClearMusicLowBandUrl()
            {
                this.PrepareBuilder();
                this.result.hasMusicLowBandUrl = false;
                this.result.musicLowBandUrl_ = "";
                return this;
            }

            public WXMusicMessageP.Builder ClearMusicUrl()
            {
                this.PrepareBuilder();
                this.result.hasMusicUrl = false;
                this.result.musicUrl_ = "";
                return this;
            }

            public override WXMusicMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXMusicMessageP.Builder(this.result);
                }
                return new WXMusicMessageP.Builder().MergeFrom(this.result);
            }

            public override WXMusicMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXMusicMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXMusicMessageP)
                {
                    return this.MergeFrom((WXMusicMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXMusicMessageP.Builder MergeFrom(WXMusicMessageP other)
            {
                return this;
            }

            public override WXMusicMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXMusicMessageP._wXMusicMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXMusicMessageP._wXMusicMessagePFieldTags[index];
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
                                this.result.hasMusicUrl = input.ReadString(ref this.result.musicUrl_);
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
                    this.result.hasMusicLowBandUrl = input.ReadString(ref this.result.musicLowBandUrl_);
                }
                return this;
            }

            private WXMusicMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXMusicMessageP result = this.result;
                    this.result = new WXMusicMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXMusicMessageP.Builder SetMusicLowBandUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMusicLowBandUrl = true;
                this.result.musicLowBandUrl_ = value;
                return this;
            }

            public WXMusicMessageP.Builder SetMusicUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMusicUrl = true;
                this.result.musicUrl_ = value;
                return this;
            }

            // Properties
            public override WXMusicMessageP DefaultInstanceForType
            {
                get
                {
                    return WXMusicMessageP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXMusicMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string MusicLowBandUrl
            {
                get
                {
                    return this.result.MusicLowBandUrl;
                }
                set
                {
                    this.SetMusicLowBandUrl(value);
                }
            }

            public string MusicUrl
            {
                get
                {
                    return this.result.MusicUrl;
                }
                set
                {
                    this.SetMusicUrl(value);
                }
            }

            protected override WXMusicMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }

}
