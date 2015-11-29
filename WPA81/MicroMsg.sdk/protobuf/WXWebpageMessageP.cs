using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXWebpageMessageP : GeneratedMessageLite<WXWebpageMessageP, WXWebpageMessageP.Builder>
    {
        
        private static readonly string[] _wXWebpageMessagePFieldNames = new string[] { "WebpageUrl" };
        private static readonly uint[] _wXWebpageMessagePFieldTags = new uint[] { 10 };
        private static readonly WXWebpageMessageP defaultInstance = new WXWebpageMessageP().MakeReadOnly();
        private bool hasWebpageUrl;
        private int memoizedSerializedSize = -1;
        private string webpageUrl_ = "";
        public const int WebpageUrlFieldNumber = 1;

        
        static WXWebpageMessageP()
        {
            object.ReferenceEquals(Proto.WXWebpageMessageP.Descriptor, null);
        }

        private WXWebpageMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXWebpageMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXWebpageMessageP ep = obj as WXWebpageMessageP;
            if (ep == null)
            {
                return false;
            }
            return ((this.hasWebpageUrl == ep.hasWebpageUrl) && (!this.hasWebpageUrl || this.webpageUrl_.Equals(ep.webpageUrl_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasWebpageUrl)
            {
                hashCode ^= this.webpageUrl_.GetHashCode();
            }
            return hashCode;
        }

        private WXWebpageMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXWebpageMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXWebpageMessageP, Builder>.PrintField("WebpageUrl", this.hasWebpageUrl, this.webpageUrl_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXWebpageMessagePFieldNames;
            if (this.hasWebpageUrl)
            {
                output.WriteString(1, strArray[0], this.WebpageUrl);
            }
        }

        // Properties
        public static WXWebpageMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXWebpageMessageP DefaultInstanceForType
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
                if (!this.hasWebpageUrl)
                {
                    return false;
                }
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
                    if (this.hasWebpageUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.WebpageUrl);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXWebpageMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string WebpageUrl
        {
            get
            {
                return this.webpageUrl_;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<WXWebpageMessageP, WXWebpageMessageP.Builder>
        {
            
            private WXWebpageMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXWebpageMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXWebpageMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXWebpageMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXWebpageMessageP.Builder Clear()
            {
                this.result = WXWebpageMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXWebpageMessageP.Builder ClearWebpageUrl()
            {
                this.PrepareBuilder();
                this.result.hasWebpageUrl = false;
                this.result.webpageUrl_ = "";
                return this;
            }

            public override WXWebpageMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXWebpageMessageP.Builder(this.result);
                }
                return new WXWebpageMessageP.Builder().MergeFrom(this.result);
            }

            public override WXWebpageMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXWebpageMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXWebpageMessageP)
                {
                    return this.MergeFrom((WXWebpageMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXWebpageMessageP.Builder MergeFrom(WXWebpageMessageP other)
            {
                return this;
            }

            public override WXWebpageMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXWebpageMessageP._wXWebpageMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXWebpageMessageP._wXWebpageMessagePFieldTags[index];
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
                    this.result.hasWebpageUrl = input.ReadString(ref this.result.webpageUrl_);
                }
                return this;
            }

            private WXWebpageMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXWebpageMessageP result = this.result;
                    this.result = new WXWebpageMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXWebpageMessageP.Builder SetWebpageUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasWebpageUrl = true;
                this.result.webpageUrl_ = value;
                return this;
            }

            // Properties
            public override WXWebpageMessageP DefaultInstanceForType
            {
                get
                {
                    return WXWebpageMessageP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXWebpageMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override WXWebpageMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string WebpageUrl
            {
                get
                {
                    return this.result.WebpageUrl;
                }
                set
                {
                    this.SetWebpageUrl(value);
                }
            }
        }
    }
}
