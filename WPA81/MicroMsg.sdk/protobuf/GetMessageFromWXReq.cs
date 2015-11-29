using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class GetMessageFromWXReq : GeneratedMessageLite<GetMessageFromWXReq, GetMessageFromWXReq.Builder>
    {
        
        private static readonly string[] _getMessageFromWXReqFieldNames = new string[] { "Base", "Username" };
        private static readonly uint[] _getMessageFromWXReqFieldTags = new uint[] { 10, 0x12 };
        private BaseReqP base_;
        public const int BaseFieldNumber = 1;
        private static readonly GetMessageFromWXReq defaultInstance = new GetMessageFromWXReq().MakeReadOnly();
        private bool hasBase;
        private bool hasUsername;
        private int memoizedSerializedSize = -1;
        private string username_ = "";
        public const int UsernameFieldNumber = 2;

        
        static GetMessageFromWXReq()
        {
            object.ReferenceEquals(Proto.GetMessageFromWXReq.Descriptor, null);
        }

        private GetMessageFromWXReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetMessageFromWXReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetMessageFromWXReq req = obj as GetMessageFromWXReq;
            if (req == null)
            {
                return false;
            }
            if ((this.hasBase != req.hasBase) || (this.hasBase && !this.base_.Equals(req.base_)))
            {
                return false;
            }
            return ((this.hasUsername == req.hasUsername) && (!this.hasUsername || this.username_.Equals(req.username_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            if (this.hasUsername)
            {
                hashCode ^= this.username_.GetHashCode();
            }
            return hashCode;
        }

        private GetMessageFromWXReq MakeReadOnly()
        {
            return this;
        }

        public static GetMessageFromWXReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetMessageFromWXReq, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<GetMessageFromWXReq, Builder>.PrintField("Username", this.hasUsername, this.username_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getMessageFromWXReqFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasUsername)
            {
                output.WriteString(2, strArray[1], this.Username);
            }
        }

        // Properties
        public BaseReqP Base
        {
            get
            {
                return (this.base_ ?? BaseReqP.DefaultInstance);
            }
        }

        public static GetMessageFromWXReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetMessageFromWXReq DefaultInstanceForType
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
                if (!this.hasUsername)
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
                    if (this.hasUsername)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Username);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetMessageFromWXReq ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Username
        {
            get
            {
                return this.username_;
            }
        }

        // Nested Types
        [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<GetMessageFromWXReq, GetMessageFromWXReq.Builder>
        {
            
            private GetMessageFromWXReq result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = GetMessageFromWXReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetMessageFromWXReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetMessageFromWXReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetMessageFromWXReq.Builder Clear()
            {
                this.result = GetMessageFromWXReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetMessageFromWXReq.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public GetMessageFromWXReq.Builder ClearUsername()
            {
                this.PrepareBuilder();
                this.result.hasUsername = false;
                this.result.username_ = "";
                return this;
            }

            public override GetMessageFromWXReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetMessageFromWXReq.Builder(this.result);
                }
                return new GetMessageFromWXReq.Builder().MergeFrom(this.result);
            }

            public GetMessageFromWXReq.Builder MergeBase(BaseReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasBase && (this.result.base_ != BaseReqP.DefaultInstance))
                {
                    this.result.base_ = BaseReqP.CreateBuilder(this.result.base_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.base_ = value;
                }
                this.result.hasBase = true;
                return this;
            }

            public override GetMessageFromWXReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetMessageFromWXReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetMessageFromWXReq)
                {
                    return this.MergeFrom((GetMessageFromWXReq)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetMessageFromWXReq.Builder MergeFrom(GetMessageFromWXReq other)
            {
                return this;
            }

            public override GetMessageFromWXReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetMessageFromWXReq._getMessageFromWXReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetMessageFromWXReq._getMessageFromWXReqFieldTags[index];
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
                                BaseReqP.Builder builder = BaseReqP.CreateBuilder();
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
                    this.result.hasUsername = input.ReadString(ref this.result.username_);
                }
                return this;
            }

            private GetMessageFromWXReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetMessageFromWXReq result = this.result;
                    this.result = new GetMessageFromWXReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetMessageFromWXReq.Builder SetBase(BaseReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public GetMessageFromWXReq.Builder SetBase(BaseReqP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public GetMessageFromWXReq.Builder SetUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUsername = true;
                this.result.username_ = value;
                return this;
            }

            // Properties
            public BaseReqP Base
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

            public override GetMessageFromWXReq DefaultInstanceForType
            {
                get
                {
                    return GetMessageFromWXReq.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetMessageFromWXReq MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override GetMessageFromWXReq.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Username
            {
                get
                {
                    return this.result.Username;
                }
                set
                {
                    this.SetUsername(value);
                }
            }
        }
    }
}
