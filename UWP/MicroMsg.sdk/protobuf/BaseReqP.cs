using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class BaseReqP : GeneratedMessageLite<BaseReqP, BaseReqP.Builder>
    {
        private static readonly string[] _baseReqPFieldNames = { "Transaction", "Type" };
        private static readonly uint[] _baseReqPFieldTags = { 0x12, 8 };
        private static readonly BaseReqP defaultInstance = new BaseReqP().MakeReadOnly();
        private bool hasTransaction;
        private bool hasType;
        private int memoizedSerializedSize = -1;
        private string transaction_ = "";
        public const int TransactionFieldNumber = 2;
        private uint type_;
        public const int TypeFieldNumber = 1;

        
        static BaseReqP()
        {
            object.ReferenceEquals(Proto.BaseReqP.Descriptor, null);
        }

        private BaseReqP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(BaseReqP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            BaseReqP qp = obj as BaseReqP;
            if (qp == null)
            {
                return false;
            }
            if ((this.hasType != qp.hasType) || (this.hasType && !this.type_.Equals(qp.type_)))
            {
                return false;
            }
            return ((this.hasTransaction == qp.hasTransaction) && (!this.hasTransaction || this.transaction_.Equals(qp.transaction_)));
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
            return hashCode;
        }

        private BaseReqP MakeReadOnly()
        {
            return this;
        }

        public static BaseReqP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<BaseReqP, Builder>.PrintField("Type", this.hasType, this.type_, writer);
            GeneratedMessageLite<BaseReqP, Builder>.PrintField("Transaction", this.hasTransaction, this.transaction_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _baseReqPFieldNames;
            if (this.hasType)
            {
                output.WriteUInt32(1, strArray[1], this.Type);
            }
            if (this.hasTransaction)
            {
                output.WriteString(2, strArray[0], this.Transaction);
            }
        }

        // Properties
        public static BaseReqP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override BaseReqP DefaultInstanceForType
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
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override BaseReqP ThisMessage
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
        public sealed class Builder : GeneratedBuilderLite<BaseReqP, BaseReqP.Builder>
        {
            
            private BaseReqP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = BaseReqP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(BaseReqP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override BaseReqP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override BaseReqP.Builder Clear()
            {
                this.result = BaseReqP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public BaseReqP.Builder ClearTransaction()
            {
                this.PrepareBuilder();
                this.result.hasTransaction = false;
                this.result.transaction_ = "";
                return this;
            }

            public BaseReqP.Builder ClearType()
            {
                this.PrepareBuilder();
                this.result.hasType = false;
                this.result.type_ = 0;
                return this;
            }

            public override BaseReqP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new BaseReqP.Builder(this.result);
                }
                return new BaseReqP.Builder().MergeFrom(this.result);
            }

            public override BaseReqP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override BaseReqP.Builder MergeFrom(IMessageLite other)
            {
                if (other is BaseReqP)
                {
                    return this.MergeFrom((BaseReqP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override BaseReqP.Builder MergeFrom(BaseReqP other)
            {
                return this;
            }

            public override BaseReqP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(BaseReqP._baseReqPFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = BaseReqP._baseReqPFieldTags[index];
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
                    this.result.hasTransaction = input.ReadString(ref this.result.transaction_);
                }
                return this;
            }

            private BaseReqP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    BaseReqP result = this.result;
                    this.result = new BaseReqP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public BaseReqP.Builder SetTransaction(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasTransaction = true;
                this.result.transaction_ = value;
                return this;
            }

            public BaseReqP.Builder SetType(uint value)
            {
                this.PrepareBuilder();
                this.result.hasType = true;
                this.result.type_ = value;
                return this;
            }

            // Properties
            public override BaseReqP DefaultInstanceForType
            {
                get
                {
                    return BaseReqP.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override BaseReqP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override BaseReqP.Builder ThisBuilder
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
