using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class BaseRespP : GeneratedMessageLite<BaseRespP, BaseRespP.Builder>
    {
        
        private static readonly string[] _baseRespPFieldNames = new string[] { "ErrCode", "ErrStr", "Transaction", "Type" };
        private static readonly uint[] _baseRespPFieldTags = new uint[] { 0x18, 0x22, 0x12, 8 };
        private static readonly BaseRespP defaultInstance = new BaseRespP().MakeReadOnly();
        private uint errCode_;
        public const int ErrCodeFieldNumber = 3;
        private string errStr_ = "";
        public const int ErrStrFieldNumber = 4;
        private bool hasErrCode;
        private bool hasErrStr;
        private bool hasTransaction;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private string transaction_ = "";
        public const int TransactionFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 1;

        
        static BaseRespP()
        {
            object.ReferenceEquals(Proto.BaseRespP.Descriptor, null);
        }

        private BaseRespP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BaseRespP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BaseRespP pp = obj as BaseRespP;
            if (pp == null)
            {
                return false;
            }
            if ((this.hasType != pp.hasType) || (this.hasType && !this.type_.Equals(pp.type_)))
            {
                return false;
            }
            if ((this.hasTransaction != pp.hasTransaction) || (this.hasTransaction && !this.transaction_.Equals(pp.transaction_)))
            {
                return false;
            }
            if ((this.hasErrCode != pp.hasErrCode) || (this.hasErrCode && !this.errCode_.Equals(pp.errCode_)))
            {
                return false;
            }
            return ((this.hasErrStr == pp.hasErrStr) && (!this.hasErrStr || this.errStr_.Equals(pp.errStr_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasType)
            {
                hashCode ^= this.type_.GetHashCode();
            }
            if (this.hasTransaction)
            {
                hashCode ^= this.transaction_.GetHashCode();
            }
            if (this.hasErrCode)
            {
                hashCode ^= this.errCode_.GetHashCode();
            }
            if (this.hasErrStr)
            {
                hashCode ^= this.errStr_.GetHashCode();
            }
            return hashCode;
        }

        private BaseRespP MakeReadOnly()
        {
            return this;
        }

        public static BaseRespP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BaseRespP, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<BaseRespP, Builder>.PrintField("Transaction", this.hasTransaction, this.transaction_, writer);
            GeneratedMessageLite<BaseRespP, Builder>.PrintField("ErrCode", this.hasErrCode, this.errCode_, writer);
            GeneratedMessageLite<BaseRespP, Builder>.PrintField("ErrStr", this.hasErrStr, this.errStr_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _baseRespPFieldNames;
            if (this.hasType)
            {
                output.WriteUInt32(1, strArray[3], this.Type);
            }
            if (this.hasTransaction)
            {
                output.WriteString(2, strArray[2], this.Transaction);
            }
            if (this.hasErrCode)
            {
                output.WriteUInt32(3, strArray[0], this.ErrCode);
            }
            if (this.hasErrStr)
            {
                output.WriteString(4, strArray[1], this.ErrStr);
            }
        }

        // Properties
        public static BaseRespP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BaseRespP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public uint ErrCode
        {
            get
            {
                return this.errCode_;
            }
        }

        public string ErrStr
        {
            get
            {
                return this.errStr_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasType)
                {
                    return false;
                }
                if (!this.hasTransaction)
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
                    if (this.hasType)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(1, this.Type);
                    }
                    if (this.hasTransaction)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.Transaction);
                    }
                    if (this.hasErrCode)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeUInt32Size(3, this.ErrCode);
                    }
                    if (this.hasErrStr)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(4, this.ErrStr);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override BaseRespP ThisMessage
        {
            get
            {
                return this;
            }
        }

        public string Transaction
        {
            get
            {
                return this.transaction_;
            }
        }

        public uint Type
        {
            get
            {
                return this.type_;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<BaseRespP, BaseRespP.Builder>
        {
            
            private BaseRespP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = BaseRespP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BaseRespP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BaseRespP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BaseRespP.Builder Clear()
            {
                this.result = BaseRespP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BaseRespP.Builder ClearErrCode()
            {
                this.PrepareBuilder();
                this.result.hasErrCode = false;
                this.result.errCode_ = 0;
                return this;
            }

            public BaseRespP.Builder ClearErrStr()
            {
                this.PrepareBuilder();
                this.result.hasErrStr = false;
                this.result.errStr_ = "";
                return this;
            }

            public BaseRespP.Builder ClearTransaction()
            {
                this.PrepareBuilder();
                this.result.hasTransaction = false;
                this.result.transaction_ = "";
                return this;
            }

            public BaseRespP.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override BaseRespP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BaseRespP.Builder(this.result);
                }
                return new BaseRespP.Builder().MergeFrom(this.result);
            }

            public override BaseRespP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BaseRespP.Builder MergeFrom(IMessageLite other)
            {
                if (other is BaseRespP)
                {
                    return this.MergeFrom((BaseRespP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BaseRespP.Builder MergeFrom(BaseRespP other)
            {
                return this;
            }

            public override BaseRespP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BaseRespP._baseRespPFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BaseRespP._baseRespPFieldTags[index];
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

                        case 8:
                            {
                                this.result.hasType = input.ReadUInt32(ref this.result.type_);
                                continue;
                            }
                        case 0x12:
                            {
                                this.result.hasTransaction = input.ReadString(ref this.result.transaction_);
                                continue;
                            }
                        case 0x18:
                            {
                                this.result.hasErrCode = input.ReadUInt32(ref this.result.errCode_);
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
                    this.result.hasErrStr = input.ReadString(ref this.result.errStr_);
                }
                return this;
            }

            private BaseRespP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BaseRespP result = this.result;
                    this.result = new BaseRespP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BaseRespP.Builder SetErrCode(uint value)
            {
                this.PrepareBuilder();
                this.result.hasErrCode = true;
                this.result.errCode_ = value;
                return this;
            }

            public BaseRespP.Builder SetErrStr(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasErrStr = true;
                this.result.errStr_ = value;
                return this;
            }

            public BaseRespP.Builder SetTransaction(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTransaction = true;
                this.result.transaction_ = value;
                return this;
            }

            public BaseRespP.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            // Properties
            public override BaseRespP DefaultInstanceForType
            {
                get
                {
                    return BaseRespP.DefaultInstance;
                }
            }

            public uint ErrCode
            {
                get
                {
                    return this.result.ErrCode;
                }
                set
                {
                    this.SetErrCode(value);
                }
            }

            public string ErrStr
            {
                get
                {
                    return this.result.ErrStr;
                }
                set
                {
                    this.SetErrStr(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override BaseRespP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override BaseRespP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }

            public string Transaction
            {
                get
                {
                    return this.result.Transaction;
                }
                set
                {
                    this.SetTransaction(value);
                }
            }

            public uint Type
            {
                get
                {
                    return this.result.Type;
                }
                set
                {
                    this.SetType(value);
                }
            }
        }
    }
}
