using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class SendPayRespP : GeneratedMessageLite<SendPayRespP, SendPayRespP.Builder>
    {
        
        private static readonly string[] _sendPayRespPFieldNames = new string[] { "Base", "ReturnKey" };
        private static readonly uint[] _sendPayRespPFieldTags = new uint[] { 10, 0x12 };
        private BaseRespP base_;
        public const int BaseFieldNumber = 1;
        private static readonly SendPayRespP defaultInstance = new SendPayRespP().MakeReadOnly();
        private bool hasBase;
        private bool hasReturnKey;
        private int memoizedSerializedSize = -1;
        private string returnKey_ = "";
        public const int ReturnKeyFieldNumber = 2;

        
        static SendPayRespP()
        {
            object.ReferenceEquals(Proto.SendPayRespP.Descriptor, null);
        }

        private SendPayRespP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendPayRespP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendPayRespP pp = obj as SendPayRespP;
            if (pp == null)
            {
                return false;
            }
            if ((this.hasBase != pp.hasBase) || (this.hasBase && !this.base_.Equals(pp.base_)))
            {
                return false;
            }
            return ((this.hasReturnKey == pp.hasReturnKey) && (!this.hasReturnKey || this.returnKey_.Equals(pp.returnKey_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            if (this.hasReturnKey)
            {
                hashCode ^= this.returnKey_.GetHashCode();
            }
            return hashCode;
        }

        private SendPayRespP MakeReadOnly()
        {
            return this;
        }

        public static SendPayRespP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendPayRespP, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<SendPayRespP, Builder>.PrintField("ReturnKey", this.hasReturnKey, this.returnKey_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendPayRespPFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasReturnKey)
            {
                output.WriteString(2, strArray[1], this.ReturnKey);
            }
        }

        // Properties
        public BaseRespP Base
        {
            get
            {
                return (this.base_ ?? BaseRespP.DefaultInstance);
            }
        }

        public static SendPayRespP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendPayRespP DefaultInstanceForType
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
                if (!this.hasBase)
                {
                    return false;
                }
                if (!this.hasReturnKey)
                {
                    return false;
                }
                if (!this.Base.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public string ReturnKey
        {
            get
            {
                return this.returnKey_;
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
                    if (this.hasBase)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(1, this.Base);
                    }
                    if (this.hasReturnKey)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ReturnKey);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendPayRespP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SendPayRespP, SendPayRespP.Builder>
        {
            
            private SendPayRespP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = SendPayRespP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendPayRespP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendPayRespP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendPayRespP.Builder Clear()
            {
                this.result = SendPayRespP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendPayRespP.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public SendPayRespP.Builder ClearReturnKey()
            {
                this.PrepareBuilder();
                this.result.hasReturnKey = false;
                this.result.returnKey_ = "";
                return this;
            }

            public override SendPayRespP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendPayRespP.Builder(this.result);
                }
                return new SendPayRespP.Builder().MergeFrom(this.result);
            }

            public SendPayRespP.Builder MergeBase(BaseRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBase && (this.result.base_ != BaseRespP.DefaultInstance))
                {
                    this.result.base_ = BaseRespP.CreateBuilder(this.result.base_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.base_ = value;
                }
                this.result.hasBase = true;
                return this;
            }

            public override SendPayRespP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendPayRespP.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendPayRespP)
                {
                    return this.MergeFrom((SendPayRespP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendPayRespP.Builder MergeFrom(SendPayRespP other)
            {
                return this;
            }

            public override SendPayRespP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendPayRespP._sendPayRespPFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendPayRespP._sendPayRespPFieldTags[index];
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
                                BaseRespP.Builder builder = BaseRespP.CreateBuilder();
                                if (this.result.hasBase)
                                {
                                    builder.MergeFrom(this.Base);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.Base = builder.BuildPartial();
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
                    this.result.hasReturnKey = input.ReadString(ref this.result.returnKey_);
                }
                return this;
            }

            private SendPayRespP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendPayRespP result = this.result;
                    this.result = new SendPayRespP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendPayRespP.Builder SetBase(BaseRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public SendPayRespP.Builder SetBase(BaseRespP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public SendPayRespP.Builder SetReturnKey(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasReturnKey = true;
                this.result.returnKey_ = value;
                return this;
            }

            // Properties
            public BaseRespP Base
            {
                get
                {
                    return this.result.Base;
                }
                set
                {
                    this.SetBase(value);
                }
            }

            public override SendPayRespP DefaultInstanceForType
            {
                get
                {
                    return SendPayRespP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendPayRespP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string ReturnKey
            {
                get
                {
                    return this.result.ReturnKey;
                }
                set
                {
                    this.SetReturnKey(value);
                }
            }

            protected override SendPayRespP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}
