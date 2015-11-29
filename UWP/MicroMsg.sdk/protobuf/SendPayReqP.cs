using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class SendPayReqP : GeneratedMessageLite<SendPayReqP, SendPayReqP.Builder>
    {
        
        private static readonly string[] _sendPayReqPFieldNames = new string[] { "Base", "NonceStr", "Package", "PartnerId", "PrepayId", "Sign", "TimeStamp" };
        private static readonly uint[] _sendPayReqPFieldTags = new uint[] { 10, 0x22, 50, 0x12, 0x1a, 0x3a, 40 };
        private BaseReqP base_;
        public const int BaseFieldNumber = 1;
        private static readonly SendPayReqP defaultInstance = new SendPayReqP().MakeReadOnly();
        private bool hasBase;
        private bool hasNonceStr;
        private bool hasPackage;
        private bool hasPartnerId;
        private bool hasPrepayId;
        private bool hasSign;
        private bool hasTimeStamp;
        private int memoizedSerializedSize = -1;
        private string nonceStr_ = "";
        public const int NonceStrFieldNumber = 4;
        private string package_ = "";
        public const int PackageFieldNumber = 6;
        private string partnerId_ = "";
        public const int PartnerIdFieldNumber = 2;
        private string prepayId_ = "";
        public const int PrepayIdFieldNumber = 3;
        private string sign_ = "";
        public const int SignFieldNumber = 7;
        private uint timeStamp_;
        public const int TimeStampFieldNumber = 5;

        
        static SendPayReqP()
        {
            object.ReferenceEquals(Proto.SendPayReqP.Descriptor, null);
        }

        private SendPayReqP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(SendPayReqP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            SendPayReqP qp = obj as SendPayReqP;
            if (qp == null)
            {
                return false;
            }
            if ((this.hasBase != qp.hasBase) || (this.hasBase && !this.base_.Equals(qp.base_)))
            {
                return false;
            }
            if ((this.hasPartnerId != qp.hasPartnerId) || (this.hasPartnerId && !this.partnerId_.Equals(qp.partnerId_)))
            {
                return false;
            }
            if ((this.hasPrepayId != qp.hasPrepayId) || (this.hasPrepayId && !this.prepayId_.Equals(qp.prepayId_)))
            {
                return false;
            }
            if ((this.hasNonceStr != qp.hasNonceStr) || (this.hasNonceStr && !this.nonceStr_.Equals(qp.nonceStr_)))
            {
                return false;
            }
            if ((this.hasTimeStamp != qp.hasTimeStamp) || (this.hasTimeStamp && !this.timeStamp_.Equals(qp.timeStamp_)))
            {
                return false;
            }
            if ((this.hasPackage != qp.hasPackage) || (this.hasPackage && !this.package_.Equals(qp.package_)))
            {
                return false;
            }
            return ((this.hasSign == qp.hasSign) && (!this.hasSign || this.sign_.Equals(qp.sign_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            if (this.hasPartnerId)
            {
                hashCode ^= this.partnerId_.GetHashCode();
            }
            if (this.hasPrepayId)
            {
                hashCode ^= this.prepayId_.GetHashCode();
            }
            if (this.hasNonceStr)
            {
                hashCode ^= this.nonceStr_.GetHashCode();
            }
            if (this.hasTimeStamp)
            {
                hashCode ^= this.timeStamp_.GetHashCode();
            }
            if (this.hasPackage)
            {
                hashCode ^= this.package_.GetHashCode();
            }
            if (this.hasSign)
            {
                hashCode ^= this.sign_.GetHashCode();
            }
            return hashCode;
        }

        private SendPayReqP MakeReadOnly()
        {
            return this;
        }

        public static SendPayReqP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("PartnerId", this.hasPartnerId, this.partnerId_, writer);
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("PrepayId", this.hasPrepayId, this.prepayId_, writer);
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("NonceStr", this.hasNonceStr, this.nonceStr_, writer);
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("TimeStamp", this.hasTimeStamp, this.timeStamp_, writer);
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("Package", this.hasPackage, this.package_, writer);
            GeneratedMessageLite<SendPayReqP, Builder>.PrintField("Sign", this.hasSign, this.sign_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _sendPayReqPFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
            }
            if (this.hasPartnerId)
            {
                output.WriteString(2, strArray[3], this.PartnerId);
            }
            if (this.hasPrepayId)
            {
                output.WriteString(3, strArray[4], this.PrepayId);
            }
            if (this.hasNonceStr)
            {
                output.WriteString(4, strArray[1], this.NonceStr);
            }
            if (this.hasTimeStamp)
            {
                output.WriteUInt32(5, strArray[6], this.TimeStamp);
            }
            if (this.hasPackage)
            {
                output.WriteString(6, strArray[2], this.Package);
            }
            if (this.hasSign)
            {
                output.WriteString(7, strArray[5], this.Sign);
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

        public static SendPayReqP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override SendPayReqP DefaultInstanceForType
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
                if (!this.hasPartnerId)
                {
                    return false;
                }
                if (!this.hasPrepayId)
                {
                    return false;
                }
                if (!this.hasNonceStr)
                {
                    return false;
                }
                if (!this.hasTimeStamp)
                {
                    return false;
                }
                if (!this.hasPackage)
                {
                    return false;
                }
                if (!this.hasSign)
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

        public string NonceStr
        {
            get
            {
                return this.nonceStr_;
            }
        }

        public string Package
        {
            get
            {
                return this.package_;
            }
        }

        public string PartnerId
        {
            get
            {
                return this.partnerId_;
            }
        }

        public string PrepayId
        {
            get
            {
                return this.prepayId_;
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
                    if (this.hasPartnerId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.PartnerId);
                    }
                    if (this.hasPrepayId)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.PrepayId);
                    }
                    if (this.hasNonceStr)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.NonceStr);
                    }
                    if (this.hasTimeStamp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(5, this.TimeStamp);
                    }
                    if (this.hasPackage)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(6, this.Package);
                    }
                    if (this.hasSign)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(7, this.Sign);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public string Sign
        {
            get
            {
                return this.sign_;
            }
        }

        protected override SendPayReqP ThisMessage
        {
            get
            {
                return this;
            }
        }

        public uint TimeStamp
        {
            get
            {
                return this.timeStamp_;
            }
        }

        // Nested Types
        [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<SendPayReqP, SendPayReqP.Builder>
        {
            
            private SendPayReqP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = SendPayReqP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(SendPayReqP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override SendPayReqP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override SendPayReqP.Builder Clear()
            {
                this.result = SendPayReqP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public SendPayReqP.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public SendPayReqP.Builder ClearNonceStr()
            {
                this.PrepareBuilder();
                this.result.hasNonceStr = false;
                this.result.nonceStr_ = "";
                return this;
            }

            public SendPayReqP.Builder ClearPackage()
            {
                this.PrepareBuilder();
                this.result.hasPackage = false;
                this.result.package_ = "";
                return this;
            }

            public SendPayReqP.Builder ClearPartnerId()
            {
                this.PrepareBuilder();
                this.result.hasPartnerId = false;
                this.result.partnerId_ = "";
                return this;
            }

            public SendPayReqP.Builder ClearPrepayId()
            {
                this.PrepareBuilder();
                this.result.hasPrepayId = false;
                this.result.prepayId_ = "";
                return this;
            }

            public SendPayReqP.Builder ClearSign()
            {
                this.PrepareBuilder();
                this.result.hasSign = false;
                this.result.sign_ = "";
                return this;
            }

            public SendPayReqP.Builder ClearTimeStamp()
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = false;
                this.result.timeStamp_ = 0;
                return this;
            }

            public override SendPayReqP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new SendPayReqP.Builder(this.result);
                }
                return new SendPayReqP.Builder().MergeFrom(this.result);
            }

            public SendPayReqP.Builder MergeBase(BaseReqP value)
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

            public override SendPayReqP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override SendPayReqP.Builder MergeFrom(IMessageLite other)
            {
                if (other is SendPayReqP)
                {
                    return this.MergeFrom((SendPayReqP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override SendPayReqP.Builder MergeFrom(SendPayReqP other)
            {
                return this;
            }

            public override SendPayReqP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(SendPayReqP._sendPayReqPFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = SendPayReqP._sendPayReqPFieldTags[index];
                        }
                        else
                        {
                            this.ParseUnknownField(input, extensionRegistry, num, str);
                            continue;
                        }
                    }
                    switch (num)
                    {
                        case 0x12:
                            {
                                this.result.hasPartnerId = input.ReadString(ref this.result.partnerId_);
                                continue;
                            }
                        case 0x1a:
                            {
                                this.result.hasPrepayId = input.ReadString(ref this.result.prepayId_);
                                continue;
                            }
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
                        case 0x22:
                            {
                                this.result.hasNonceStr = input.ReadString(ref this.result.nonceStr_);
                                continue;
                            }
                        case 40:
                            {
                                this.result.hasTimeStamp = input.ReadUInt32(ref this.result.timeStamp_);
                                continue;
                            }
                        case 50:
                            {
                                this.result.hasPackage = input.ReadString(ref this.result.package_);
                                continue;
                            }
                        case 0x3a:
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
                    this.result.hasSign = input.ReadString(ref this.result.sign_);
                }
                return this;
            }

            private SendPayReqP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    SendPayReqP result = this.result;
                    this.result = new SendPayReqP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public SendPayReqP.Builder SetBase(BaseReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public SendPayReqP.Builder SetBase(BaseReqP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
                return this;
            }

            public SendPayReqP.Builder SetNonceStr(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasNonceStr = true;
                this.result.nonceStr_ = value;
                return this;
            }

            public SendPayReqP.Builder SetPackage(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPackage = true;
                this.result.package_ = value;
                return this;
            }

            public SendPayReqP.Builder SetPartnerId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPartnerId = true;
                this.result.partnerId_ = value;
                return this;
            }

            public SendPayReqP.Builder SetPrepayId(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPrepayId = true;
                this.result.prepayId_ = value;
                return this;
            }

            public SendPayReqP.Builder SetSign(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSign = true;
                this.result.sign_ = value;
                return this;
            }

            public SendPayReqP.Builder SetTimeStamp(uint value)
            {
                this.PrepareBuilder();
                this.result.hasTimeStamp = true;
                this.result.timeStamp_ = value;
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

            public override SendPayReqP DefaultInstanceForType
            {
                get
                {
                    return SendPayReqP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override SendPayReqP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public string NonceStr
            {
                get
                {
                    return this.result.NonceStr;
                }
                set
                {
                    this.SetNonceStr(value);
                }
            }

            public string Package
            {
                get
                {
                    return this.result.Package;
                }
                set
                {
                    this.SetPackage(value);
                }
            }

            public string PartnerId
            {
                get
                {
                    return this.result.PartnerId;
                }
                set
                {
                    this.SetPartnerId(value);
                }
            }

            public string PrepayId
            {
                get
                {
                    return this.result.PrepayId;
                }
                set
                {
                    this.SetPrepayId(value);
                }
            }

            public string Sign
            {
                get
                {
                    return this.result.Sign;
                }
                set
                {
                    this.SetSign(value);
                }
            }

            protected override SendPayReqP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public uint TimeStamp
            {
                get
                {
                    return this.result.TimeStamp;
                }
                set
                {
                    this.SetTimeStamp(value);
                }
            }
        }
    }

}
