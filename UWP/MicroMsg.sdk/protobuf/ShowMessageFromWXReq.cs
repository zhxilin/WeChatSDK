using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class ShowMessageFromWXReq : GeneratedMessageLite<ShowMessageFromWXReq, ShowMessageFromWXReq.Builder>
    {
        
        private static readonly string[] _showMessageFromWXReqFieldNames = new string[] { "Base", "Msg" };
        private static readonly uint[] _showMessageFromWXReqFieldTags = new uint[] { 10, 0x12 };
        private BaseReqP base_;
        public const int BaseFieldNumber = 1;
        private static readonly ShowMessageFromWXReq defaultInstance = new ShowMessageFromWXReq().MakeReadOnly();
        private bool hasBase;
        private bool hasMsg;
        private int memoizedSerializedSize = -1;
        private WXMessageP msg_;
        public const int MsgFieldNumber = 2;

        
        static ShowMessageFromWXReq()
        {
            object.ReferenceEquals(Proto.ShowMessageFromWXReq.Descriptor, null);
        }

        private ShowMessageFromWXReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ShowMessageFromWXReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ShowMessageFromWXReq req = obj as ShowMessageFromWXReq;
            if (req == null)
            {
                return false;
            }
            if ((this.hasBase != req.hasBase) || (this.hasBase && !this.base_.Equals(req.base_)))
            {
                return false;
            }
            return ((this.hasMsg == req.hasMsg) && (!this.hasMsg || this.msg_.Equals(req.msg_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            if (this.hasMsg)
            {
                hashCode ^= this.msg_.GetHashCode();
            }
            return hashCode;
        }

        private ShowMessageFromWXReq MakeReadOnly()
        {
            return this;
        }

        public static ShowMessageFromWXReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ShowMessageFromWXReq, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<ShowMessageFromWXReq, Builder>.PrintField("Msg", this.hasMsg, this.msg_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _showMessageFromWXReqFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasMsg)
            {
                output.WriteMessage(2, strArray[1], this.Msg);
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

        public static ShowMessageFromWXReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ShowMessageFromWXReq DefaultInstanceForType
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
                if (!this.hasMsg)
                {
                    return false;
                }
                if (!this.Base.IsInitialized)
                {
                    return false;
                }
                if (!this.Msg.IsInitialized)
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
                    if (this.hasMsg)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(2, this.Msg);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ShowMessageFromWXReq ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<ShowMessageFromWXReq, ShowMessageFromWXReq.Builder>
        {
            
            private ShowMessageFromWXReq result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = ShowMessageFromWXReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ShowMessageFromWXReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ShowMessageFromWXReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ShowMessageFromWXReq.Builder Clear()
            {
                this.result = ShowMessageFromWXReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ShowMessageFromWXReq.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public ShowMessageFromWXReq.Builder ClearMsg()
            {
                this.PrepareBuilder();
                this.result.hasMsg = false;
                this.result.msg_ = null;
                return this;
            }

            public override ShowMessageFromWXReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ShowMessageFromWXReq.Builder(this.result);
                }
                return new ShowMessageFromWXReq.Builder().MergeFrom(this.result);
            }

            public ShowMessageFromWXReq.Builder MergeBase(BaseReqP value)
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

            public override ShowMessageFromWXReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ShowMessageFromWXReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is ShowMessageFromWXReq)
                {
                    return this.MergeFrom((ShowMessageFromWXReq)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ShowMessageFromWXReq.Builder MergeFrom(ShowMessageFromWXReq other)
            {
                return this;
            }

            public override ShowMessageFromWXReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ShowMessageFromWXReq._showMessageFromWXReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ShowMessageFromWXReq._showMessageFromWXReqFieldTags[index];
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

            public ShowMessageFromWXReq.Builder MergeMsg(WXMessageP value)
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

            private ShowMessageFromWXReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ShowMessageFromWXReq result = this.result;
                    this.result = new ShowMessageFromWXReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ShowMessageFromWXReq.Builder SetBase(BaseReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public ShowMessageFromWXReq.Builder SetBase(BaseReqP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public ShowMessageFromWXReq.Builder SetMsg(WXMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = value;
                return this;
            }

            public ShowMessageFromWXReq.Builder SetMsg(WXMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = builderForValue.Build();
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

            public override ShowMessageFromWXReq DefaultInstanceForType
            {
                get
                {
                    return ShowMessageFromWXReq.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ShowMessageFromWXReq MessageBeingBuilt
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

            protected override ShowMessageFromWXReq.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }

}
