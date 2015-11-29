using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class GetMessageFromWXResp : GeneratedMessageLite<GetMessageFromWXResp, GetMessageFromWXResp.Builder>
    {
        
        private static readonly string[] _getMessageFromWXRespFieldNames = new string[] { "Base", "Msg", "Username" };
        private static readonly uint[] _getMessageFromWXRespFieldTags = new uint[] { 10, 0x1a, 0x12 };
        private BaseRespP base_;
        public const int BaseFieldNumber = 1;
        private static readonly GetMessageFromWXResp defaultInstance = new GetMessageFromWXResp().MakeReadOnly();
        private bool hasBase;
        private bool hasMsg;
        private bool hasUsername;
        private int memoizedSerializedSize = -1;
        private WXMessageP msg_;
        public const int MsgFieldNumber = 3;
        private string username_ = "";
        public const int UsernameFieldNumber = 2;

        
        static GetMessageFromWXResp()
        {
            object.ReferenceEquals(Proto.GetMessageFromWXResp.Descriptor, null);
        }

        private GetMessageFromWXResp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(GetMessageFromWXResp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            GetMessageFromWXResp resp = obj as GetMessageFromWXResp;
            if (resp == null)
            {
                return false;
            }
            if ((this.hasBase != resp.hasBase) || (this.hasBase && !this.base_.Equals(resp.base_)))
            {
                return false;
            }
            if ((this.hasUsername != resp.hasUsername) || (this.hasUsername && !this.username_.Equals(resp.username_)))
            {
                return false;
            }
            return ((this.hasMsg == resp.hasMsg) && (!this.hasMsg || this.msg_.Equals(resp.msg_)));
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
            if (this.hasMsg)
            {
                hashCode ^= this.msg_.GetHashCode();
            }
            return hashCode;
        }

        private GetMessageFromWXResp MakeReadOnly()
        {
            return this;
        }

        public static GetMessageFromWXResp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<GetMessageFromWXResp, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<GetMessageFromWXResp, Builder>.PrintField("Username", this.hasUsername, this.username_, writer);
            GeneratedMessageLite<GetMessageFromWXResp, Builder>.PrintField("Msg", this.hasMsg, this.msg_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _getMessageFromWXRespFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasUsername)
            {
                output.WriteString(2, strArray[2], this.Username);
            }
            if (this.hasMsg)
            {
                output.WriteMessage(3, strArray[1], this.Msg);
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

        public static GetMessageFromWXResp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override GetMessageFromWXResp DefaultInstanceForType
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
                if (!this.Base.IsInitialized)
                {
                    return false;
                }
                return true;
            }
        }

        public WXMessageP Msg
        {
            get
            {
                return (this.msg_ ?? WXMessageP.DefaultInstance);
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
                    if (this.hasMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(3, this.Msg);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override GetMessageFromWXResp ThisMessage
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
        [DebuggerNonUserCode, CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<GetMessageFromWXResp, GetMessageFromWXResp.Builder>
        {
            
            private GetMessageFromWXResp result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = GetMessageFromWXResp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(GetMessageFromWXResp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override GetMessageFromWXResp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override GetMessageFromWXResp.Builder Clear()
            {
                this.result = GetMessageFromWXResp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public GetMessageFromWXResp.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public GetMessageFromWXResp.Builder ClearMsg()
            {
                this.PrepareBuilder();
                this.result.hasMsg = false;
                this.result.msg_ = null;
                return this;
            }

            public GetMessageFromWXResp.Builder ClearUsername()
            {
                this.PrepareBuilder();
                this.result.hasUsername = false;
                this.result.username_ = "";
                return this;
            }

            public override GetMessageFromWXResp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new GetMessageFromWXResp.Builder(this.result);
                }
                return new GetMessageFromWXResp.Builder().MergeFrom(this.result);
            }

            public GetMessageFromWXResp.Builder MergeBase(BaseRespP value)
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

            public override GetMessageFromWXResp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override GetMessageFromWXResp.Builder MergeFrom(IMessageLite other)
            {
                if (other is GetMessageFromWXResp)
                {
                    return this.MergeFrom((GetMessageFromWXResp)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override GetMessageFromWXResp.Builder MergeFrom(GetMessageFromWXResp other)
            {
                return this;
            }

            public override GetMessageFromWXResp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(GetMessageFromWXResp._getMessageFromWXRespFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = GetMessageFromWXResp._getMessageFromWXRespFieldTags[index];
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
                            {
                                this.result.hasUsername = input.ReadString(ref this.result.username_);
                                continue;
                            }
                        case 0x1a:
                            {
                                WXMessageP.Builder builder2 = WXMessageP.CreateBuilder();
                                if (this.result.hasMsg)
                                {
                                    builder2.MergeFrom(this.Msg);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.Msg = builder2.BuildPartial();
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

            public GetMessageFromWXResp.Builder MergeMsg(WXMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasMsg && (this.result.msg_ != WXMessageP.DefaultInstance))
                {
                    this.result.msg_ = WXMessageP.CreateBuilder(this.result.msg_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.msg_ = value;
                }
                this.result.hasMsg = true;
                return this;
            }

            private GetMessageFromWXResp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    GetMessageFromWXResp result = this.result;
                    this.result = new GetMessageFromWXResp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public GetMessageFromWXResp.Builder SetBase(BaseRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public GetMessageFromWXResp.Builder SetBase(BaseRespP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public GetMessageFromWXResp.Builder SetMsg(WXMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = value;
                return this;
            }

            public GetMessageFromWXResp.Builder SetMsg(WXMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = builderForValue.Build();
                return this;
            }

            public GetMessageFromWXResp.Builder SetUsername(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUsername = true;
                this.result.username_ = value;
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

            public override GetMessageFromWXResp DefaultInstanceForType
            {
                get
                {
                    return GetMessageFromWXResp.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override GetMessageFromWXResp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public WXMessageP Msg
            {
                get
                {
                    return this.result.Msg;
                }
                set
                {
                    this.SetMsg(value);
                }
            }

            protected override GetMessageFromWXResp.Builder ThisBuilder
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
