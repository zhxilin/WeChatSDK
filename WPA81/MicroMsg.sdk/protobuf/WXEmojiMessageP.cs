using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXEmojiMessageP : GeneratedMessageLite<WXEmojiMessageP, WXEmojiMessageP.Builder>
    {
        
        private static readonly string[] _wXEmojiMessagePFieldNames = new string[] { "EmojiData" };
        private static readonly uint[] _wXEmojiMessagePFieldTags = new uint[] { 10 };
        private static readonly WXEmojiMessageP defaultInstance = new WXEmojiMessageP().MakeReadOnly();
        private ByteString emojiData_ = ByteString.Empty;
        public const int EmojiDataFieldNumber = 1;
        private bool hasEmojiData;
        private int memoizedSerializedSize = -1;

        
        static WXEmojiMessageP()
        {
            object.ReferenceEquals(Proto.WXEmojiMessageP.Descriptor, null);
        }

        private WXEmojiMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXEmojiMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXEmojiMessageP ep = obj as WXEmojiMessageP;
            if (ep == null)
            {
                return false;
            }
            return ((this.hasEmojiData == ep.hasEmojiData) && (!this.hasEmojiData || this.emojiData_.Equals(ep.emojiData_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasEmojiData)
            {
                hashCode ^= this.emojiData_.GetHashCode();
            }
            return hashCode;
        }

        private WXEmojiMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXEmojiMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXEmojiMessageP, Builder>.PrintField("EmojiData", this.hasEmojiData, this.emojiData_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXEmojiMessagePFieldNames;
            if (this.hasEmojiData)
            {
                output.WriteBytes(1, strArray[0], this.EmojiData);
            }
        }

        // Properties
        public static WXEmojiMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXEmojiMessageP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString EmojiData
        {
            get
            {
                return this.emojiData_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasEmojiData)
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
                    if (this.hasEmojiData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(1, this.EmojiData);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXEmojiMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<WXEmojiMessageP, WXEmojiMessageP.Builder>
        {
            
            private WXEmojiMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXEmojiMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXEmojiMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXEmojiMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXEmojiMessageP.Builder Clear()
            {
                this.result = WXEmojiMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXEmojiMessageP.Builder ClearEmojiData()
            {
                this.PrepareBuilder();
                this.result.hasEmojiData = false;
                this.result.emojiData_ = ByteString.Empty;
                return this;
            }

            public override WXEmojiMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXEmojiMessageP.Builder(this.result);
                }
                return new WXEmojiMessageP.Builder().MergeFrom(this.result);
            }

            public override WXEmojiMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXEmojiMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXEmojiMessageP)
                {
                    return this.MergeFrom((WXEmojiMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXEmojiMessageP.Builder MergeFrom(WXEmojiMessageP other)
            {
                return this;
            }

            public override WXEmojiMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXEmojiMessageP._wXEmojiMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXEmojiMessageP._wXEmojiMessagePFieldTags[index];
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
                    this.result.hasEmojiData = input.ReadBytes(ref this.result.emojiData_);
                }
                return this;
            }

            private WXEmojiMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXEmojiMessageP result = this.result;
                    this.result = new WXEmojiMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXEmojiMessageP.Builder SetEmojiData(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasEmojiData = true;
                this.result.emojiData_ = value;
                return this;
            }

            // Properties
            public override WXEmojiMessageP DefaultInstanceForType
            {
                get
                {
                    return WXEmojiMessageP.DefaultInstance;
                }
            }

            public ByteString EmojiData
            {
                get
                {
                    return this.result.EmojiData;
                }
                set
                {
                    this.SetEmojiData(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXEmojiMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override WXEmojiMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }

}
