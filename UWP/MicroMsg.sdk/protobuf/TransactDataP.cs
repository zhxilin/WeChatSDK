using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class TransactDataP : GeneratedMessageLite<TransactDataP, TransactDataP.Builder>
    {
        
        private static readonly string[] _transactDataPFieldNames = new string[] { "AppID", "AuthReq", "AuthResp", "CheckContent", "CheckSummary", "ConmandID", "GetReq", "GetResp", "PayReq", "PayResp", "SdkVersion", "SendReq", "SendResp", "ShowReq", "ShowResp" };
        private static readonly uint[] _transactDataPFieldTags = new uint[] { 0x12, 0x3a, 90, 0x22, 0x2a, 8, 50, 0x52, 0x72, 0x7a, 0x1a, 0x42, 0x62, 0x4a, 0x6a };
        private string appID_ = "";
        public const int AppIDFieldNumber = 2;
        private SendAuthReq authReq_;
        public const int AuthReqFieldNumber = 7;
        private SendAuthResp authResp_;
        public const int AuthRespFieldNumber = 11;
        private string checkContent_ = "";
        public const int CheckContentFieldNumber = 4;
        private string checkSummary_ = "";
        public const int CheckSummaryFieldNumber = 5;
        private uint conmandID_;
        public const int ConmandIDFieldNumber = 1;
        private static readonly TransactDataP defaultInstance = new TransactDataP().MakeReadOnly();
        private GetMessageFromWXReq getReq_;
        public const int GetReqFieldNumber = 6;
        private GetMessageFromWXResp getResp_;
        public const int GetRespFieldNumber = 10;
        private bool hasAppID;
        private bool hasAuthReq;
        private bool hasAuthResp;
        private bool hasCheckContent;
        private bool hasCheckSummary;
        private bool hasConmandID;
        private bool hasGetReq;
        private bool hasGetResp;
        private bool hasPayReq;
        private bool hasPayResp;
        private bool hasSdkVersion;
        private bool hasSendReq;
        private bool hasSendResp;
        private bool hasShowReq;
        private bool hasShowResp;
        private int memoizedSerializedSize = -1;
        private SendPayReqP payReq_;
        public const int PayReqFieldNumber = 14;
        private SendPayRespP payResp_;
        public const int PayRespFieldNumber = 15;
        private string sdkVersion_ = "";
        public const int SdkVersionFieldNumber = 3;
        private SendMessageToWXReq sendReq_;
        public const int SendReqFieldNumber = 8;
        private SendMessageToWXResp sendResp_;
        public const int SendRespFieldNumber = 12;
        private ShowMessageFromWXReq showReq_;
        public const int ShowReqFieldNumber = 9;
        private ShowMessageFromWXResp showResp_;
        public const int ShowRespFieldNumber = 13;

        
        static TransactDataP()
        {
            object.ReferenceEquals(Proto.TransactDataP.Descriptor, null);
        }

        private TransactDataP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(TransactDataP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            TransactDataP ap = obj as TransactDataP;
            if (ap == null)
            {
                return false;
            }
            if ((this.hasConmandID != ap.hasConmandID) || (this.hasConmandID && !this.conmandID_.Equals(ap.conmandID_)))
            {
                return false;
            }
            if ((this.hasAppID != ap.hasAppID) || (this.hasAppID && !this.appID_.Equals(ap.appID_)))
            {
                return false;
            }
            if ((this.hasSdkVersion != ap.hasSdkVersion) || (this.hasSdkVersion && !this.sdkVersion_.Equals(ap.sdkVersion_)))
            {
                return false;
            }
            if ((this.hasCheckContent != ap.hasCheckContent) || (this.hasCheckContent && !this.checkContent_.Equals(ap.checkContent_)))
            {
                return false;
            }
            if ((this.hasCheckSummary != ap.hasCheckSummary) || (this.hasCheckSummary && !this.checkSummary_.Equals(ap.checkSummary_)))
            {
                return false;
            }
            if ((this.hasGetReq != ap.hasGetReq) || (this.hasGetReq && !this.getReq_.Equals(ap.getReq_)))
            {
                return false;
            }
            if ((this.hasAuthReq != ap.hasAuthReq) || (this.hasAuthReq && !this.authReq_.Equals(ap.authReq_)))
            {
                return false;
            }
            if ((this.hasSendReq != ap.hasSendReq) || (this.hasSendReq && !this.sendReq_.Equals(ap.sendReq_)))
            {
                return false;
            }
            if ((this.hasShowReq != ap.hasShowReq) || (this.hasShowReq && !this.showReq_.Equals(ap.showReq_)))
            {
                return false;
            }
            if ((this.hasGetResp != ap.hasGetResp) || (this.hasGetResp && !this.getResp_.Equals(ap.getResp_)))
            {
                return false;
            }
            if ((this.hasAuthResp != ap.hasAuthResp) || (this.hasAuthResp && !this.authResp_.Equals(ap.authResp_)))
            {
                return false;
            }
            if ((this.hasSendResp != ap.hasSendResp) || (this.hasSendResp && !this.sendResp_.Equals(ap.sendResp_)))
            {
                return false;
            }
            if ((this.hasShowResp != ap.hasShowResp) || (this.hasShowResp && !this.showResp_.Equals(ap.showResp_)))
            {
                return false;
            }
            if ((this.hasPayReq != ap.hasPayReq) || (this.hasPayReq && !this.payReq_.Equals(ap.payReq_)))
            {
                return false;
            }
            return ((this.hasPayResp == ap.hasPayResp) && (!this.hasPayResp || this.payResp_.Equals(ap.payResp_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasConmandID)
            {
                hashCode ^= this.conmandID_.GetHashCode();
            }
            if (this.hasAppID)
            {
                hashCode ^= this.appID_.GetHashCode();
            }
            if (this.hasSdkVersion)
            {
                hashCode ^= this.sdkVersion_.GetHashCode();
            }
            if (this.hasCheckContent)
            {
                hashCode ^= this.checkContent_.GetHashCode();
            }
            if (this.hasCheckSummary)
            {
                hashCode ^= this.checkSummary_.GetHashCode();
            }
            if (this.hasGetReq)
            {
                hashCode ^= this.getReq_.GetHashCode();
            }
            if (this.hasAuthReq)
            {
                hashCode ^= this.authReq_.GetHashCode();
            }
            if (this.hasSendReq)
            {
                hashCode ^= this.sendReq_.GetHashCode();
            }
            if (this.hasShowReq)
            {
                hashCode ^= this.showReq_.GetHashCode();
            }
            if (this.hasGetResp)
            {
                hashCode ^= this.getResp_.GetHashCode();
            }
            if (this.hasAuthResp)
            {
                hashCode ^= this.authResp_.GetHashCode();
            }
            if (this.hasSendResp)
            {
                hashCode ^= this.sendResp_.GetHashCode();
            }
            if (this.hasShowResp)
            {
                hashCode ^= this.showResp_.GetHashCode();
            }
            if (this.hasPayReq)
            {
                hashCode ^= this.payReq_.GetHashCode();
            }
            if (this.hasPayResp)
            {
                hashCode ^= this.payResp_.GetHashCode();
            }
            return hashCode;
        }

        private TransactDataP MakeReadOnly()
        {
            return this;
        }

        public static TransactDataP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("ConmandID", this.hasConmandID, this.conmandID_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("AppID", this.hasAppID, this.appID_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("SdkVersion", this.hasSdkVersion, this.sdkVersion_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("CheckContent", this.hasCheckContent, this.checkContent_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("CheckSummary", this.hasCheckSummary, this.checkSummary_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("GetReq", this.hasGetReq, this.getReq_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("AuthReq", this.hasAuthReq, this.authReq_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("SendReq", this.hasSendReq, this.sendReq_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("ShowReq", this.hasShowReq, this.showReq_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("GetResp", this.hasGetResp, this.getResp_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("AuthResp", this.hasAuthResp, this.authResp_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("SendResp", this.hasSendResp, this.sendResp_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("ShowResp", this.hasShowResp, this.showResp_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("PayReq", this.hasPayReq, this.payReq_, writer);
            GeneratedMessageLite<TransactDataP, Builder>.PrintField("PayResp", this.hasPayResp, this.payResp_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _transactDataPFieldNames;
            if (this.hasConmandID)
            {
                output.WriteUInt32(1, strArray[5], this.ConmandID);
            }
            if (this.hasAppID)
            {
                output.WriteString(2, strArray[0], this.AppID);
            }
            if (this.hasSdkVersion)
            {
                output.WriteString(3, strArray[10], this.SdkVersion);
            }
            if (this.hasCheckContent)
            {
                output.WriteString(4, strArray[3], this.CheckContent);
            }
            if (this.hasCheckSummary)
            {
                output.WriteString(5, strArray[4], this.CheckSummary);
            }
            if (this.hasGetReq)
            {
                output.WriteMessage(6, strArray[6], this.GetReq);
            }
            if (this.hasAuthReq)
            {
                output.WriteMessage(7, strArray[1], this.AuthReq);
            }
            if (this.hasSendReq)
            {
                output.WriteMessage(8, strArray[11], this.SendReq);
            }
            if (this.hasShowReq)
            {
                output.WriteMessage(9, strArray[13], this.ShowReq);
            }
            if (this.hasGetResp)
            {
                output.WriteMessage(10, strArray[7], this.GetResp);
            }
            if (this.hasAuthResp)
            {
                output.WriteMessage(11, strArray[2], this.AuthResp);
            }
            if (this.hasSendResp)
            {
                output.WriteMessage(12, strArray[12], this.SendResp);
            }
            if (this.hasShowResp)
            {
                output.WriteMessage(13, strArray[14], this.ShowResp);
            }
            if (this.hasPayReq)
            {
                output.WriteMessage(14, strArray[8], this.PayReq);
            }
            if (this.hasPayResp)
            {
                output.WriteMessage(15, strArray[9], this.PayResp);
            }
        }

        // Properties
        public string AppID
        {
            get
            {
                return this.appID_;
            }
        }

        public SendAuthReq AuthReq
        {
            get
            {
                return (this.authReq_ ?? SendAuthReq.DefaultInstance);
            }
        }

        public SendAuthResp AuthResp
        {
            get
            {
                return (this.authResp_ ?? SendAuthResp.DefaultInstance);
            }
        }

        public string CheckContent
        {
            get
            {
                return this.checkContent_;
            }
        }

        public string CheckSummary
        {
            get
            {
                return this.checkSummary_;
            }
        }

        public uint ConmandID
        {
            get
            {
                return this.conmandID_;
            }
        }

        public static TransactDataP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override TransactDataP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public GetMessageFromWXReq GetReq
        {
            get
            {
                return (this.getReq_ ?? GetMessageFromWXReq.DefaultInstance);
            }
        }

        public GetMessageFromWXResp GetResp
        {
            get
            {
                return (this.getResp_ ?? GetMessageFromWXResp.DefaultInstance);
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasConmandID)
                {
                    return false;
                }
                if (!this.hasAppID)
                {
                    return false;
                }
                if (!this.hasSdkVersion)
                {
                    return false;
                }
                if (!this.hasCheckContent)
                {
                    return false;
                }
                if (!this.hasCheckSummary)
                {
                    return false;
                }
                return true;
            }
        }

        public SendPayReqP PayReq
        {
            get
            {
                return (this.payReq_ ?? SendPayReqP.DefaultInstance);
            }
        }

        public SendPayRespP PayResp
        {
            get
            {
                return (this.payResp_ ?? SendPayRespP.DefaultInstance);
            }
        }

        public string SdkVersion
        {
            get
            {
                return this.sdkVersion_;
            }
        }

        public SendMessageToWXReq SendReq
        {
            get
            {
                return (this.sendReq_ ?? SendMessageToWXReq.DefaultInstance);
            }
        }

        public SendMessageToWXResp SendResp
        {
            get
            {
                return (this.sendResp_ ?? SendMessageToWXResp.DefaultInstance);
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
                    if (this.hasConmandID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.ConmandID);
                    }
                    if (this.hasAppID)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.AppID);
                    }
                    if (this.hasSdkVersion)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.SdkVersion);
                    }
                    if (this.hasCheckContent)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.CheckContent);
                    }
                    if (this.hasCheckSummary)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(5, this.CheckSummary);
                    }
                    if (this.hasGetReq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(6, this.GetReq);
                    }
                    if (this.hasAuthReq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(7, this.AuthReq);
                    }
                    if (this.hasSendReq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(8, this.SendReq);
                    }
                    if (this.hasShowReq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(9, this.ShowReq);
                    }
                    if (this.hasGetResp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(10, this.GetResp);
                    }
                    if (this.hasAuthResp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(11, this.AuthResp);
                    }
                    if (this.hasSendResp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(12, this.SendResp);
                    }
                    if (this.hasShowResp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(13, this.ShowResp);
                    }
                    if (this.hasPayReq)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(14, this.PayReq);
                    }
                    if (this.hasPayResp)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeMessageSize(15, this.PayResp);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        public ShowMessageFromWXReq ShowReq
        {
            get
            {
                return (this.showReq_ ?? ShowMessageFromWXReq.DefaultInstance);
            }
        }

        public ShowMessageFromWXResp ShowResp
        {
            get
            {
                return (this.showResp_ ?? ShowMessageFromWXResp.DefaultInstance);
            }
        }

        protected override TransactDataP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), CompilerGenerated, DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<TransactDataP, TransactDataP.Builder>
        {
            
            private TransactDataP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = TransactDataP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(TransactDataP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override TransactDataP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override TransactDataP.Builder Clear()
            {
                this.result = TransactDataP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public TransactDataP.Builder ClearAppID()
            {
                this.PrepareBuilder();
                this.result.hasAppID = false;
                this.result.appID_ = "";
                return this;
            }

            public TransactDataP.Builder ClearAuthReq()
            {
                this.PrepareBuilder();
                this.result.hasAuthReq = false;
                this.result.authReq_ = null;
                return this;
            }

            public TransactDataP.Builder ClearAuthResp()
            {
                this.PrepareBuilder();
                this.result.hasAuthResp = false;
                this.result.authResp_ = null;
                return this;
            }

            public TransactDataP.Builder ClearCheckContent()
            {
                this.PrepareBuilder();
                this.result.hasCheckContent = false;
                this.result.checkContent_ = "";
                return this;
            }

            public TransactDataP.Builder ClearCheckSummary()
            {
                this.PrepareBuilder();
                this.result.hasCheckSummary = false;
                this.result.checkSummary_ = "";
                return this;
            }

            public TransactDataP.Builder ClearConmandID()
            {
                this.PrepareBuilder();
                this.result.hasConmandID = false;
                this.result.conmandID_ = 0;
                return this;
            }

            public TransactDataP.Builder ClearGetReq()
            {
                this.PrepareBuilder();
                this.result.hasGetReq = false;
                this.result.getReq_ = null;
                return this;
            }

            public TransactDataP.Builder ClearGetResp()
            {
                this.PrepareBuilder();
                this.result.hasGetResp = false;
                this.result.getResp_ = null;
                return this;
            }

            public TransactDataP.Builder ClearPayReq()
            {
                this.PrepareBuilder();
                this.result.hasPayReq = false;
                this.result.payReq_ = null;
                return this;
            }

            public TransactDataP.Builder ClearPayResp()
            {
                this.PrepareBuilder();
                this.result.hasPayResp = false;
                this.result.payResp_ = null;
                return this;
            }

            public TransactDataP.Builder ClearSdkVersion()
            {
                this.PrepareBuilder();
                this.result.hasSdkVersion = false;
                this.result.sdkVersion_ = "";
                return this;
            }

            public TransactDataP.Builder ClearSendReq()
            {
                this.PrepareBuilder();
                this.result.hasSendReq = false;
                this.result.sendReq_ = null;
                return this;
            }

            public TransactDataP.Builder ClearSendResp()
            {
                this.PrepareBuilder();
                this.result.hasSendResp = false;
                this.result.sendResp_ = null;
                return this;
            }

            public TransactDataP.Builder ClearShowReq()
            {
                this.PrepareBuilder();
                this.result.hasShowReq = false;
                this.result.showReq_ = null;
                return this;
            }

            public TransactDataP.Builder ClearShowResp()
            {
                this.PrepareBuilder();
                this.result.hasShowResp = false;
                this.result.showResp_ = null;
                return this;
            }

            public override TransactDataP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new TransactDataP.Builder(this.result);
                }
                return new TransactDataP.Builder().MergeFrom(this.result);
            }

            public TransactDataP.Builder MergeAuthReq(SendAuthReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAuthReq && (this.result.authReq_ != SendAuthReq.DefaultInstance))
                {
                    this.result.authReq_ = SendAuthReq.CreateBuilder(this.result.authReq_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.authReq_ = value;
                }
                this.result.hasAuthReq = true;
                return this;
            }

            public TransactDataP.Builder MergeAuthResp(SendAuthResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasAuthResp && (this.result.authResp_ != SendAuthResp.DefaultInstance))
                {
                    this.result.authResp_ = SendAuthResp.CreateBuilder(this.result.authResp_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.authResp_ = value;
                }
                this.result.hasAuthResp = true;
                return this;
            }

            public override TransactDataP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override TransactDataP.Builder MergeFrom(IMessageLite other)
            {
                if (other is TransactDataP)
                {
                    return this.MergeFrom((TransactDataP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override TransactDataP.Builder MergeFrom(TransactDataP other)
            {
                return this;
            }

            public override TransactDataP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(TransactDataP._transactDataPFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = TransactDataP._transactDataPFieldTags[index];
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
                                this.result.hasAppID = input.ReadString(ref this.result.appID_);
                                continue;
                            }
                        case 0x1a:
                            {
                                this.result.hasSdkVersion = input.ReadString(ref this.result.sdkVersion_);
                                continue;
                            }
                        case 0:
                            throw InvalidProtocolBufferException.InvalidTag();

                        case 8:
                            {
                                this.result.hasConmandID = input.ReadUInt32(ref this.result.conmandID_);
                                continue;
                            }
                        case 0x22:
                            {
                                this.result.hasCheckContent = input.ReadString(ref this.result.checkContent_);
                                continue;
                            }
                        case 0x2a:
                            {
                                this.result.hasCheckSummary = input.ReadString(ref this.result.checkSummary_);
                                continue;
                            }
                        case 50:
                            {
                                GetMessageFromWXReq.Builder builder = GetMessageFromWXReq.CreateBuilder();
                                if (this.result.hasGetReq)
                                {
                                    builder.MergeFrom(this.GetReq);
                                }
                                input.ReadMessage(builder, extensionRegistry);
                                this.GetReq = builder.BuildPartial();
                                continue;
                            }
                        case 0x3a:
                            {
                                SendAuthReq.Builder builder2 = SendAuthReq.CreateBuilder();
                                if (this.result.hasAuthReq)
                                {
                                    builder2.MergeFrom(this.AuthReq);
                                }
                                input.ReadMessage(builder2, extensionRegistry);
                                this.AuthReq = builder2.BuildPartial();
                                continue;
                            }
                        case 0x52:
                            {
                                GetMessageFromWXResp.Builder builder5 = GetMessageFromWXResp.CreateBuilder();
                                if (this.result.hasGetResp)
                                {
                                    builder5.MergeFrom(this.GetResp);
                                }
                                input.ReadMessage(builder5, extensionRegistry);
                                this.GetResp = builder5.BuildPartial();
                                continue;
                            }
                        case 90:
                            {
                                SendAuthResp.Builder builder6 = SendAuthResp.CreateBuilder();
                                if (this.result.hasAuthResp)
                                {
                                    builder6.MergeFrom(this.AuthResp);
                                }
                                input.ReadMessage(builder6, extensionRegistry);
                                this.AuthResp = builder6.BuildPartial();
                                continue;
                            }
                        case 0x42:
                            {
                                SendMessageToWXReq.Builder builder3 = SendMessageToWXReq.CreateBuilder();
                                if (this.result.hasSendReq)
                                {
                                    builder3.MergeFrom(this.SendReq);
                                }
                                input.ReadMessage(builder3, extensionRegistry);
                                this.SendReq = builder3.BuildPartial();
                                continue;
                            }
                        case 0x4a:
                            {
                                ShowMessageFromWXReq.Builder builder4 = ShowMessageFromWXReq.CreateBuilder();
                                if (this.result.hasShowReq)
                                {
                                    builder4.MergeFrom(this.ShowReq);
                                }
                                input.ReadMessage(builder4, extensionRegistry);
                                this.ShowReq = builder4.BuildPartial();
                                continue;
                            }
                        case 0x62:
                            {
                                SendMessageToWXResp.Builder builder7 = SendMessageToWXResp.CreateBuilder();
                                if (this.result.hasSendResp)
                                {
                                    builder7.MergeFrom(this.SendResp);
                                }
                                input.ReadMessage(builder7, extensionRegistry);
                                this.SendResp = builder7.BuildPartial();
                                continue;
                            }
                        case 0x6a:
                            {
                                ShowMessageFromWXResp.Builder builder8 = ShowMessageFromWXResp.CreateBuilder();
                                if (this.result.hasShowResp)
                                {
                                    builder8.MergeFrom(this.ShowResp);
                                }
                                input.ReadMessage(builder8, extensionRegistry);
                                this.ShowResp = builder8.BuildPartial();
                                continue;
                            }
                        case 0x72:
                            {
                                SendPayReqP.Builder builder9 = SendPayReqP.CreateBuilder();
                                if (this.result.hasPayReq)
                                {
                                    builder9.MergeFrom(this.PayReq);
                                }
                                input.ReadMessage(builder9, extensionRegistry);
                                this.PayReq = builder9.BuildPartial();
                                continue;
                            }
                        case 0x7a:
                            {
                                SendPayRespP.Builder builder10 = SendPayRespP.CreateBuilder();
                                if (this.result.hasPayResp)
                                {
                                    builder10.MergeFrom(this.PayResp);
                                }
                                input.ReadMessage(builder10, extensionRegistry);
                                this.PayResp = builder10.BuildPartial();
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

            public TransactDataP.Builder MergeGetReq(GetMessageFromWXReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasGetReq && (this.result.getReq_ != GetMessageFromWXReq.DefaultInstance))
                {
                    this.result.getReq_ = GetMessageFromWXReq.CreateBuilder(this.result.getReq_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.getReq_ = value;
                }
                this.result.hasGetReq = true;
                return this;
            }

            public TransactDataP.Builder MergeGetResp(GetMessageFromWXResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasGetResp && (this.result.getResp_ != GetMessageFromWXResp.DefaultInstance))
                {
                    this.result.getResp_ = GetMessageFromWXResp.CreateBuilder(this.result.getResp_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.getResp_ = value;
                }
                this.result.hasGetResp = true;
                return this;
            }

            public TransactDataP.Builder MergePayReq(SendPayReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPayReq && (this.result.payReq_ != SendPayReqP.DefaultInstance))
                {
                    this.result.payReq_ = SendPayReqP.CreateBuilder(this.result.payReq_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.payReq_ = value;
                }
                this.result.hasPayReq = true;
                return this;
            }

            public TransactDataP.Builder MergePayResp(SendPayRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasPayResp && (this.result.payResp_ != SendPayRespP.DefaultInstance))
                {
                    this.result.payResp_ = SendPayRespP.CreateBuilder(this.result.payResp_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.payResp_ = value;
                }
                this.result.hasPayResp = true;
                return this;
            }

            public TransactDataP.Builder MergeSendReq(SendMessageToWXReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSendReq && (this.result.sendReq_ != SendMessageToWXReq.DefaultInstance))
                {
                    this.result.sendReq_ = SendMessageToWXReq.CreateBuilder(this.result.sendReq_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.sendReq_ = value;
                }
                this.result.hasSendReq = true;
                return this;
            }

            public TransactDataP.Builder MergeSendResp(SendMessageToWXResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasSendResp && (this.result.sendResp_ != SendMessageToWXResp.DefaultInstance))
                {
                    this.result.sendResp_ = SendMessageToWXResp.CreateBuilder(this.result.sendResp_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.sendResp_ = value;
                }
                this.result.hasSendResp = true;
                return this;
            }

            public TransactDataP.Builder MergeShowReq(ShowMessageFromWXReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasShowReq && (this.result.showReq_ != ShowMessageFromWXReq.DefaultInstance))
                {
                    this.result.showReq_ = ShowMessageFromWXReq.CreateBuilder(this.result.showReq_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.showReq_ = value;
                }
                this.result.hasShowReq = true;
                return this;
            }

            public TransactDataP.Builder MergeShowResp(ShowMessageFromWXResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                if (this.result.hasShowResp && (this.result.showResp_ != ShowMessageFromWXResp.DefaultInstance))
                {
                    this.result.showResp_ = ShowMessageFromWXResp.CreateBuilder(this.result.showResp_).MergeFrom(value).BuildPartial();
                }
                else
                {
                    this.result.showResp_ = value;
                }
                this.result.hasShowResp = true;
                return this;
            }

            private TransactDataP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    TransactDataP result = this.result;
                    this.result = new TransactDataP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public TransactDataP.Builder SetAppID(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAppID = true;
                this.result.appID_ = value;
                return this;
            }

            public TransactDataP.Builder SetAuthReq(SendAuthReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthReq = true;
                this.result.authReq_ = value;
                return this;
            }

            public TransactDataP.Builder SetAuthReq(SendAuthReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAuthReq = true;
                this.result.authReq_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetAuthResp(SendAuthResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasAuthResp = true;
                this.result.authResp_ = value;
                return this;
            }

            public TransactDataP.Builder SetAuthResp(SendAuthResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasAuthResp = true;
                this.result.authResp_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetCheckContent(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCheckContent = true;
                this.result.checkContent_ = value;
                return this;
            }

            public TransactDataP.Builder SetCheckSummary(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasCheckSummary = true;
                this.result.checkSummary_ = value;
                return this;
            }

            public TransactDataP.Builder SetConmandID(uint value)
            {
                this.PrepareBuilder();
                this.result.hasConmandID = true;
                this.result.conmandID_ = value;
                return this;
            }

            public TransactDataP.Builder SetGetReq(GetMessageFromWXReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGetReq = true;
                this.result.getReq_ = value;
                return this;
            }

            public TransactDataP.Builder SetGetReq(GetMessageFromWXReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasGetReq = true;
                this.result.getReq_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetGetResp(GetMessageFromWXResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasGetResp = true;
                this.result.getResp_ = value;
                return this;
            }

            public TransactDataP.Builder SetGetResp(GetMessageFromWXResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasGetResp = true;
                this.result.getResp_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetPayReq(SendPayReqP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPayReq = true;
                this.result.payReq_ = value;
                return this;
            }

            public TransactDataP.Builder SetPayReq(SendPayReqP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPayReq = true;
                this.result.payReq_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetPayResp(SendPayRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasPayResp = true;
                this.result.payResp_ = value;
                return this;
            }

            public TransactDataP.Builder SetPayResp(SendPayRespP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasPayResp = true;
                this.result.payResp_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetSdkVersion(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSdkVersion = true;
                this.result.sdkVersion_ = value;
                return this;
            }

            public TransactDataP.Builder SetSendReq(SendMessageToWXReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSendReq = true;
                this.result.sendReq_ = value;
                return this;
            }

            public TransactDataP.Builder SetSendReq(SendMessageToWXReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSendReq = true;
                this.result.sendReq_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetSendResp(SendMessageToWXResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasSendResp = true;
                this.result.sendResp_ = value;
                return this;
            }

            public TransactDataP.Builder SetSendResp(SendMessageToWXResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasSendResp = true;
                this.result.sendResp_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetShowReq(ShowMessageFromWXReq value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasShowReq = true;
                this.result.showReq_ = value;
                return this;
            }

            public TransactDataP.Builder SetShowReq(ShowMessageFromWXReq.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasShowReq = true;
                this.result.showReq_ = builderForValue.Build();
                return this;
            }

            public TransactDataP.Builder SetShowResp(ShowMessageFromWXResp value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasShowResp = true;
                this.result.showResp_ = value;
                return this;
            }

            public TransactDataP.Builder SetShowResp(ShowMessageFromWXResp.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasShowResp = true;
                this.result.showResp_ = builderForValue.Build();
                return this;
            }

            // Properties
            public string AppID
            {
                get
                {
                    return this.result.AppID;
                }
                set
                {
                    this.SetAppID(value);
                }
            }

            public SendAuthReq AuthReq
            {
                get
                {
                    return this.result.AuthReq;
                }
                set
                {
                    this.SetAuthReq(value);
                }
            }

            public SendAuthResp AuthResp
            {
                get
                {
                    return this.result.AuthResp;
                }
                set
                {
                    this.SetAuthResp(value);
                }
            }

            public string CheckContent
            {
                get
                {
                    return this.result.CheckContent;
                }
                set
                {
                    this.SetCheckContent(value);
                }
            }

            public string CheckSummary
            {
                get
                {
                    return this.result.CheckSummary;
                }
                set
                {
                    this.SetCheckSummary(value);
                }
            }

            public uint ConmandID
            {
                get
                {
                    return this.result.ConmandID;
                }
                set
                {
                    this.SetConmandID(value);
                }
            }

            public override TransactDataP DefaultInstanceForType
            {
                get
                {
                    return TransactDataP.DefaultInstance;
                }
            }

            public GetMessageFromWXReq GetReq
            {
                get
                {
                    return this.result.GetReq;
                }
                set
                {
                    this.SetGetReq(value);
                }
            }

            public GetMessageFromWXResp GetResp
            {
                get
                {
                    return this.result.GetResp;
                }
                set
                {
                    this.SetGetResp(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override TransactDataP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            public SendPayReqP PayReq
            {
                get
                {
                    return this.result.PayReq;
                }
                set
                {
                    this.SetPayReq(value);
                }
            }

            public SendPayRespP PayResp
            {
                get
                {
                    return this.result.PayResp;
                }
                set
                {
                    this.SetPayResp(value);
                }
            }

            public string SdkVersion
            {
                get
                {
                    return this.result.SdkVersion;
                }
                set
                {
                    this.SetSdkVersion(value);
                }
            }

            public SendMessageToWXReq SendReq
            {
                get
                {
                    return this.result.SendReq;
                }
                set
                {
                    this.SetSendReq(value);
                }
            }

            public SendMessageToWXResp SendResp
            {
                get
                {
                    return this.result.SendResp;
                }
                set
                {
                    this.SetSendResp(value);
                }
            }

            public ShowMessageFromWXReq ShowReq
            {
                get
                {
                    return this.result.ShowReq;
                }
                set
                {
                    this.SetShowReq(value);
                }
            }

            public ShowMessageFromWXResp ShowResp
            {
                get
                {
                    return this.result.ShowResp;
                }
                set
                {
                    this.SetShowResp(value);
                }
            }

            protected override TransactDataP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}
