using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXTextMessageP : GeneratedMessageLite<WXTextMessageP, WXTextMessageP.Builder>
    {
        
        private static readonly string[] _wXTextMessagePFieldNames = new string[] { "Text" };
        private static readonly uint[] _wXTextMessagePFieldTags = new uint[] { 10 };
        private static readonly WXTextMessageP defaultInstance = new WXTextMessageP().MakeReadOnly();
        private bool hasText;
        private int memoizedSerializedSize = -1;
        private string text_ = "";
        public const int TextFieldNumber = 1;

        
        static WXTextMessageP()
        {
            object.ReferenceEquals(Proto.WXTextMessageP.Descriptor, null);
        }

        private WXTextMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXTextMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXTextMessageP ep = obj as WXTextMessageP;
            if (ep == null)
            {
                return false;
            }
            return ((this.hasText == ep.hasText) && (!this.hasText || this.text_.Equals(ep.text_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasText)
            {
                hashCode ^= this.text_.GetHashCode();
            }
            return hashCode;
        }

        private WXTextMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXTextMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXTextMessageP, Builder>.PrintField("Text", this.hasText, this.text_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXTextMessagePFieldNames;
            if (this.hasText)
            {
                output.WriteString(1, strArray[0], this.Text);
            }
        }

        // Properties
        public static WXTextMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXTextMessageP DefaultInstanceForType
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
                if (!this.hasText)
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
                    if (this.hasText)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(1, this.Text);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string Text
        {
            get
            {
                return this.text_;
            }
        }

        protected override WXTextMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<WXTextMessageP, WXTextMessageP.Builder>
        {
            
            private WXTextMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXTextMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXTextMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXTextMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXTextMessageP.Builder Clear()
            {
                this.result = WXTextMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXTextMessageP.Builder ClearText()
            {
                this.PrepareBuilder();
                this.result.hasText = false;
                this.result.text_ = "";
                return this;
            }

            public override WXTextMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXTextMessageP.Builder(this.result);
                }
                return new WXTextMessageP.Builder().MergeFrom(this.result);
            }

            public override WXTextMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXTextMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXTextMessageP)
                {
                    return this.MergeFrom((WXTextMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXTextMessageP.Builder MergeFrom(WXTextMessageP other)
            {
                return this;
            }

            public override WXTextMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXTextMessageP._wXTextMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXTextMessageP._wXTextMessagePFieldTags[index];
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
                    this.result.hasText = input.ReadString(ref this.result.text_);
                }
                return this;
            }

            private WXTextMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXTextMessageP result = this.result;
                    this.result = new WXTextMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXTextMessageP.Builder SetText(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasText = true;
                this.result.text_ = value;
                return this;
            }

            // Properties
            public override WXTextMessageP DefaultInstanceForType
            {
                get
                {
                    return WXTextMessageP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXTextMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Text
            {
                get
                {
                    return this.result.Text;
                }
                set
                {
                    this.SetText(value);
                }
            }

            protected override WXTextMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}
