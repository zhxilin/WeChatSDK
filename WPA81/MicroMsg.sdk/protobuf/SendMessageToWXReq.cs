using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class SendMessageToWXReq : GeneratedMessageLite<SendMessageToWXReq, SendMessageToWXReq.Builder>
    {
        
        private static readonly string[] _sendMessageToWXReqFieldNames = new string[] { "Base", "Msg", "Scene" };
        private static readonly uint[] _sendMessageToWXReqFieldTags = new uint[] { 10, 0x12, 0x18 };
        private BaseReqP base_;
        public const int BaseFieldNumber = 1;
        private static readonly SendMessageToWXReq defaultInstance = new SendMessageToWXReq().MakeReadOnly();
        private bool hasBase;
        private bool hasMsg;
        private bool hasScene;
        private int memoizedSerializedSize = -1;
        private WXMessageP msg_;
        public const int MsgFieldNumber = 2;
        private uint scene_;
        public const int SceneFieldNumber = 3;

        
        static SendMessageToWXReq()
        {
            object.ReferenceEquals(Proto.SendMessageToWXReq.Descriptor, null);
        }

        private SendMessageToWXReq()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendMessageToWXReq prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendMessageToWXReq req = obj as SendMessageToWXReq;
            if (req == null)
            {
                return false;
            }
            if ((this.hasBase != req.hasBase) || (this.hasBase && !this.base_.Equals(req.base_)))
            {
                return false;
            }
            if ((this.hasMsg != req.hasMsg) || (this.hasMsg && !this.msg_.Equals(req.msg_)))
            {
                return false;
            }
            return ((this.hasScene == req.hasScene) && (!this.hasScene || this.scene_.Equals(req.scene_)));
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
            if (this.hasScene)
            {
                hashCode ^= this.scene_.GetHashCode();
            }
            return hashCode;
        }

        private SendMessageToWXReq MakeReadOnly()
        {
            return this;
        }

        public static SendMessageToWXReq ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendMessageToWXReq, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<SendMessageToWXReq, Builder>.PrintField("Msg", this.hasMsg, this.msg_, writer);
            GeneratedMessageLite<SendMessageToWXReq, Builder>.PrintField("Scene", this.hasScene, this.scene_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendMessageToWXReqFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasMsg)
            {
                output.WriteMessage(2, strArray[1], this.Msg);
            }
            if (this.hasScene)
            {
                output.WriteUInt32(3, strArray[2], this.Scene);
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

        public static SendMessageToWXReq DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendMessageToWXReq DefaultInstanceForType
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
                if (!this.hasScene)
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

        public uint Scene
        {
            get
            {
                return this.scene_;
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
                    if (this.hasScene)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.Scene);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override SendMessageToWXReq ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<SendMessageToWXReq, SendMessageToWXReq.Builder>
        {
            
            private SendMessageToWXReq result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = SendMessageToWXReq.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendMessageToWXReq cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendMessageToWXReq BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendMessageToWXReq.Builder Clear()
            {
                this.result = SendMessageToWXReq.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendMessageToWXReq.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public SendMessageToWXReq.Builder ClearMsg()
            {
                this.PrepareBuilder();
                this.result.hasMsg = false;
                this.result.msg_ = null;
                return this;
            }

            public SendMessageToWXReq.Builder ClearScene()
            {
                this.PrepareBuilder();
                this.result.hasScene = false;
                this.result.scene_ = 0;
                return this;
            }

            public override SendMessageToWXReq.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendMessageToWXReq.Builder(this.result);
                }
                return new SendMessageToWXReq.Builder().MergeFrom(this.result);
            }

            public SendMessageToWXReq.Builder MergeBase(BaseReqP value)
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

            public override SendMessageToWXReq.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendMessageToWXReq.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendMessageToWXReq)
                {
                    return this.MergeFrom((SendMessageToWXReq)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendMessageToWXReq.Builder MergeFrom(SendMessageToWXReq other)
            {
                return this;
            }

            public override SendMessageToWXReq.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendMessageToWXReq._sendMessageToWXReqFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendMessageToWXReq._sendMessageToWXReqFieldTags[index];
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
                        case 0x18:
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
                    this.result.hasScene = input.ReadUInt32(ref this.result.scene_);
                }
                return this;
            }

            public SendMessageToWXReq.Builder MergeMsg(WXMessageP value)
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

            private SendMessageToWXReq PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendMessageToWXReq result = this.result;
                    this.result = new SendMessageToWXReq();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendMessageToWXReq.Builder SetBase(BaseReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public SendMessageToWXReq.Builder SetBase(BaseReqP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public SendMessageToWXReq.Builder SetMsg(WXMessageP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = value;
                return this;
            }

            public SendMessageToWXReq.Builder SetMsg(WXMessageP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasMsg = true;
                this.result.msg_ = builderForValue.Build();
                return this;
            }

            public SendMessageToWXReq.Builder SetScene(uint value)
            {
                this.PrepareBuilder();
                this.result.hasScene = true;
                this.result.scene_ = value;
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

            public override SendMessageToWXReq DefaultInstanceForType
            {
                get
                {
                    return SendMessageToWXReq.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendMessageToWXReq MessageBeingBuilt
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

            public uint Scene
            {
                get
                {
                    return this.result.Scene;
                }
                set
                {
                    this.SetScene(value);
                }
            }

            protected override SendMessageToWXReq.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}
