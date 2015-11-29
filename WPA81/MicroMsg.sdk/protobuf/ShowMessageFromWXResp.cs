using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class ShowMessageFromWXResp : GeneratedMessageLite<ShowMessageFromWXResp, ShowMessageFromWXResp.Builder>
    {
        
        private static readonly string[] _showMessageFromWXRespFieldNames = new string[] { "Base" };
        private static readonly uint[] _showMessageFromWXRespFieldTags = new uint[] { 10 };
        private BaseRespP base_;
        public const int BaseFieldNumber = 1;
        private static readonly ShowMessageFromWXResp defaultInstance = new ShowMessageFromWXResp().MakeReadOnly();
        private bool hasBase;
        private int memoizedSerializedSize = -1;

        
        static ShowMessageFromWXResp()
        {
            object.ReferenceEquals(Proto.ShowMessageFromWXResp.Descriptor, null);
        }

        private ShowMessageFromWXResp()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(ShowMessageFromWXResp prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            ShowMessageFromWXResp resp = obj as ShowMessageFromWXResp;
            if (resp == null)
            {
                return false;
            }
            return ((this.hasBase == resp.hasBase) && (!this.hasBase || this.base_.Equals(resp.base_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasBase)
            {
                hashCode ^= this.base_.GetHashCode();
            }
            return hashCode;
        }

        private ShowMessageFromWXResp MakeReadOnly()
        {
            return this;
        }

        public static ShowMessageFromWXResp ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<ShowMessageFromWXResp, Builder>.PrintField("Base", this.hasBase, this.base_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _showMessageFromWXRespFieldNames;
            if (this.hasBase)
            {
                output.WriteMessage(1, strArray[0], this.Base);
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

        public static ShowMessageFromWXResp DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override ShowMessageFromWXResp DefaultInstanceForType
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
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override ShowMessageFromWXResp ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [CompilerGenerated, GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode]
        public sealed class Builder : GeneratedBuilderLite<ShowMessageFromWXResp, ShowMessageFromWXResp.Builder>
        {
            
            private ShowMessageFromWXResp result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = ShowMessageFromWXResp.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(ShowMessageFromWXResp cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override ShowMessageFromWXResp BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override ShowMessageFromWXResp.Builder Clear()
            {
                this.result = ShowMessageFromWXResp.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public ShowMessageFromWXResp.Builder ClearBase()
            {
                this.PrepareBuilder();
                this.result.hasBase = false;
                this.result.base_ = null;
                return this;
            }

            public override ShowMessageFromWXResp.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new ShowMessageFromWXResp.Builder(this.result);
                }
                return new ShowMessageFromWXResp.Builder().MergeFrom(this.result);
            }

            public ShowMessageFromWXResp.Builder MergeBase(BaseRespP value)
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

            public override ShowMessageFromWXResp.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override ShowMessageFromWXResp.Builder MergeFrom(IMessageLite other)
            {
                if (other is ShowMessageFromWXResp)
                {
                    return this.MergeFrom((ShowMessageFromWXResp)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override ShowMessageFromWXResp.Builder MergeFrom(ShowMessageFromWXResp other)
            {
                return this;
            }

            public override ShowMessageFromWXResp.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(ShowMessageFromWXResp._showMessageFromWXRespFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = ShowMessageFromWXResp._showMessageFromWXRespFieldTags[index];
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
                    }
                    if (WireFormat.IsEndGroupTag(num))
                    {
                        return this;
                    }
                    this.ParseUnknownField(input, extensionRegistry, num, str);
                }
                return this;
            }

            private ShowMessageFromWXResp PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    ShowMessageFromWXResp result = this.result;
                    this.result = new ShowMessageFromWXResp();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public ShowMessageFromWXResp.Builder SetBase(BaseRespP value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = value;
                return this;
            }

            public ShowMessageFromWXResp.Builder SetBase(BaseRespP.Builder builderForValue)
            {
                ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
                this.PrepareBuilder();
                this.result.hasBase = true;
                this.result.base_ = builderForValue.Build();
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

            public override ShowMessageFromWXResp DefaultInstanceForType
            {
                get
                {
                    return ShowMessageFromWXResp.DefaultInstance;
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override ShowMessageFromWXResp MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override ShowMessageFromWXResp.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }

}
