using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class SendAuthReq : GeneratedMessageLite<SendAuthReq, SendAuthReq.Builder>
    {
        
        private static readonly string[] _sendAuthReqFieldNames = new string[] { "Base", "Scope", "State" };
        private static readonly uint[] _sendAuthReqFieldTags = new uint[] { 10, 0x12, 0x1a };
        private BaseReqP base_;
        public const int BaseFieldNumber = 1;
        private static readonly SendAuthReq defaultInstance = new SendAuthReq().MakeReadOnly();
        private bool hasBase;
        private bool hasScope;
        private bool hasState;
        private int memoizedSerializedSize = -1;
        private string scope_ = "";
        public const int ScopeFieldNumber = 2;
        private string state_ = "";
        public const int StateFieldNumber = 3;

        
        static SendAuthReq()
        {
            object.ReferenceEquals(Proto.SendAuthReq.Descriptor, null);
        }

        private SendAuthReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendAuthReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendAuthReq req = obj as SendAuthReq;
            if (req == null)
            {
                return false;
            }
            if ((this.hasBase != req.hasBase) || (this.hasBase && !this.base_.Equals(req.base_)))
            {
                return false;
            }
            if ((this.hasScope != req.hasScope) || (this.hasScope && !this.scope_.Equals(req.scope_)))
            {
                return false;
            }
            return ((this.hasState == req.hasState) && (!this.hasState || this.state_.Equals(req.state_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            if (this.hasScope)
            {
                hashCode ^= this.scope_.GetHashCode();
            }
            if (this.hasState)
            {
                hashCode ^= this.state_.GetHashCode();
            }
            return hashCode;
        }

        private SendAuthReq MakeReadOnly()
        {
            return this;
        }

        public static SendAuthReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendAuthReq, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<SendAuthReq, Builder>.PrintField("Scope", this.hasScope, this.scope_, writer);
            GeneratedMessageLite<SendAuthReq, Builder>.PrintField("State", this.hasState, this.state_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendAuthReqFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasScope)
            {
                output.WriteString(2, strArray[1], this.Scope);
            }
            if (this.hasState)
            {
                output.WriteString(3, strArray[2], this.State);
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

        public static SendAuthReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendAuthReq DefaultInstanceForType
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
                if (!this.hasScope)
                {
                    return false;
                }
                if (!this.hasState)
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

        public string Scope
        {
            get
            {
                return this.scope_;
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
                    if (this.hasScope)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Scope);
                    }
                    if (this.hasState)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.State);
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

        protected override SendAuthReq ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<SendAuthReq, SendAuthReq.Builder>
        {
            
            private SendAuthReq result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = SendAuthReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendAuthReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendAuthReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendAuthReq.Builder Clear()
            {
                this.result = SendAuthReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendAuthReq.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public SendAuthReq.Builder ClearScope()
            {
                this.PrepareBuilder();
                this.result.hasScope = false;
                this.result.scope_ = "";
                return this;
            }

            public SendAuthReq.Builder ClearState()
            {
                this.PrepareBuilder();
                this.result.hasState = false;
                this.result.state_ = "";
                return this;
            }

            public override SendAuthReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendAuthReq.Builder(this.result);
                }
                return new SendAuthReq.Builder().MergeFrom(this.result);
            }

            public SendAuthReq.Builder MergeBase(BaseReqP value)
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

            public override SendAuthReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendAuthReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendAuthReq)
                {
                    return this.MergeFrom((SendAuthReq)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendAuthReq.Builder MergeFrom(SendAuthReq other)
            {
                return this;
            }

            public override SendAuthReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendAuthReq._sendAuthReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendAuthReq._sendAuthReqFieldTags[index];
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
                            {
                                this.result.hasScope = input.ReadString(ref this.result.scope_);
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
                    this.result.hasState = input.ReadString(ref this.result.state_);
                }
                return this;
            }

            private SendAuthReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendAuthReq result = this.result;
                    this.result = new SendAuthReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendAuthReq.Builder SetBase(BaseReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public SendAuthReq.Builder SetBase(BaseReqP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public SendAuthReq.Builder SetScope(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasScope = true;
                this.result.scope_ = value;
                return this;
            }

            public SendAuthReq.Builder SetState(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasState = true;
                this.result.state_ = value;
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

            public override SendAuthReq DefaultInstanceForType
            {
                get
                {
                    return SendAuthReq.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendAuthReq MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string Scope
            {
                get
                {
                    return this.result.Scope;
                }
                set
                {
                    this.SetScope(value);
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

            protected override SendAuthReq.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }





}
