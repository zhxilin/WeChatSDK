using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class SendAuthResp : GeneratedMessageLite<SendAuthResp, SendAuthResp.Builder>
    {
        
        private static readonly string[] _sendAuthRespFieldNames = new string[] { "Base", "Code", "State", "Url" };
        private static readonly uint[] _sendAuthRespFieldTags = new uint[] { 10, 0x12, 0x1a, 0x22 };
        private BaseRespP base_;
        public const int BaseFieldNumber = 1;
        private string code_ = "";
        public const int CodeFieldNumber = 2;
        private static readonly SendAuthResp defaultInstance = new SendAuthResp().MakeReadOnly();
        private bool hasBase;
        private bool hasCode;
        private bool hasState;
        private bool hasUrl;
        private int memoizedSerializedSize = -1;
        private string state_ = "";
        public const int StateFieldNumber = 3;
        private string url_ = "";
        public const int UrlFieldNumber = 4;

        
        static SendAuthResp()
        {
            object.ReferenceEquals(Proto.SendAuthResp.Descriptor, null);
        }

        private SendAuthResp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendAuthResp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendAuthResp resp = obj as SendAuthResp;
            if (resp == null)
            {
                return false;
            }
            if ((this.hasBase != resp.hasBase) || (this.hasBase && !this.base_.Equals(resp.base_)))
            {
                return false;
            }
            if ((this.hasCode != resp.hasCode) || (this.hasCode && !this.code_.Equals(resp.code_)))
            {
                return false;
            }
            if ((this.hasState != resp.hasState) || (this.hasState && !this.state_.Equals(resp.state_)))
            {
                return false;
            }
            return ((this.hasUrl == resp.hasUrl) && (!this.hasUrl || this.url_.Equals(resp.url_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            if (this.hasCode)
            {
                hashCode ^= this.code_.GetHashCode();
            }
            if (this.hasState)
            {
                hashCode ^= this.state_.GetHashCode();
            }
            if (this.hasUrl)
            {
                hashCode ^= this.url_.GetHashCode();
            }
            return hashCode;
        }

        private SendAuthResp MakeReadOnly()
        {
            return this;
        }

        public static SendAuthResp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendAuthResp, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<SendAuthResp, Builder>.PrintField("Code", this.hasCode, this.code_, writer);
            GeneratedMessageLite<SendAuthResp, Builder>.PrintField("State", this.hasState, this.state_, writer);
            GeneratedMessageLite<SendAuthResp, Builder>.PrintField("Url", this.hasUrl, this.url_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendAuthRespFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasCode)
            {
                output.WriteString(2, strArray[1], this.Code);
            }
            if (this.hasState)
            {
                output.WriteString(3, strArray[2], this.State);
            }
            if (this.hasUrl)
            {
                output.WriteString(4, strArray[3], this.Url);
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

        public string Code
        {
            get
            {
                return this.code_;
            }
        }

        public static SendAuthResp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendAuthResp DefaultInstanceForType
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
                if (!this.hasCode)
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
                    if (this.hasCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Code);
                    }
                    if (this.hasState)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.State);
                    }
                    if (this.hasUrl)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.Url);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string State
        {
            get
            {
                return this.state_;
            }
        }

        protected override SendAuthResp ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Url
        {
            get
            {
                return this.url_;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<SendAuthResp, SendAuthResp.Builder>
        {
            
            private SendAuthResp result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = SendAuthResp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendAuthResp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendAuthResp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendAuthResp.Builder Clear()
            {
                this.result = SendAuthResp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendAuthResp.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public SendAuthResp.Builder ClearCode()
            {
                this.PrepareBuilder();
                this.result.hasCode = false;
                this.result.code_ = "";
                return this;
            }

            public SendAuthResp.Builder ClearState()
            {
                this.PrepareBuilder();
                this.result.hasState = false;
                this.result.state_ = "";
                return this;
            }

            public SendAuthResp.Builder ClearUrl()
            {
                this.PrepareBuilder();
                this.result.hasUrl = false;
                this.result.url_ = "";
                return this;
            }

            public override SendAuthResp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendAuthResp.Builder(this.result);
                }
                return new SendAuthResp.Builder().MergeFrom(this.result);
            }

            public SendAuthResp.Builder MergeBase(BaseRespP value)
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

            public override SendAuthResp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendAuthResp.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendAuthResp)
                {
                    return this.MergeFrom((SendAuthResp)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendAuthResp.Builder MergeFrom(SendAuthResp other)
            {
                return this;
            }

            public override SendAuthResp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendAuthResp._sendAuthRespFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendAuthResp._sendAuthRespFieldTags[index];
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
                                this.result.hasCode = input.ReadString(ref this.result.code_);
                                continue;
                            }
                        case 0x1a:
                            {
                                this.result.hasState = input.ReadString(ref this.result.state_);
                                continue;
                            }
                        case 0x22:
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
                    this.result.hasUrl = input.ReadString(ref this.result.url_);
                }
                return this;
            }

            private SendAuthResp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendAuthResp result = this.result;
                    this.result = new SendAuthResp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendAuthResp.Builder SetBase(BaseRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public SendAuthResp.Builder SetBase(BaseRespP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public SendAuthResp.Builder SetCode(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCode = true;
                this.result.code_ = value;
                return this;
            }

            public SendAuthResp.Builder SetState(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasState = true;
                this.result.state_ = value;
                return this;
            }

            public SendAuthResp.Builder SetUrl(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasUrl = true;
                this.result.url_ = value;
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

            public string Code
            {
                get
                {
                    return this.result.Code;
                }
                set
                {
                    this.SetCode(value);
                }
            }

            public override SendAuthResp DefaultInstanceForType
            {
                get
                {
                    return SendAuthResp.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendAuthResp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string State
            {
                get
                {
                    return this.result.State;
                }
                set
                {
                    this.SetState(value);
                }
            }

            protected override SendAuthResp.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Url
            {
                get
                {
                    return this.result.Url;
                }
                set
                {
                    this.SetUrl(value);
                }
            }
        }
    }





}
