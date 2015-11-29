using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXFileMessageP : GeneratedMessageLite<WXFileMessageP, WXFileMessageP.Builder>
    {
        
        private static readonly string[] _wXFileMessagePFieldNames = new string[] { "FileData", "FileName" };
        private static readonly uint[] _wXFileMessagePFieldTags = new uint[] { 10, 0x12 };
        private static readonly WXFileMessageP defaultInstance = new WXFileMessageP().MakeReadOnly();
        private ByteString fileData_ = ByteString.Empty;
        public const int FileDataFieldNumber = 1;
        private string fileName_ = "";
        public const int FileNameFieldNumber = 2;
        private bool hasFileData;
        private bool hasFileName;
        private int memoizedSerializedSize = -1;

        
        static WXFileMessageP()
        {
            object.ReferenceEquals(Proto.WXFileMessageP.Descriptor, null);
        }

        private WXFileMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXFileMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXFileMessageP ep = obj as WXFileMessageP;
            if (ep == null)
            {
                return false;
            }
            if ((this.hasFileData != ep.hasFileData) || (this.hasFileData && !this.fileData_.Equals(ep.fileData_)))
            {
                return false;
            }
            return ((this.hasFileName == ep.hasFileName) && (!this.hasFileName || this.fileName_.Equals(ep.fileName_)));
        }

        public override int GetHashCode()
        {
            int hashCode = base.GetType().GetHashCode();
            if (this.hasFileData)
            {
                hashCode ^= this.fileData_.GetHashCode();
            }
            if (this.hasFileName)
            {
                hashCode ^= this.fileName_.GetHashCode();
            }
            return hashCode;
        }

        private WXFileMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXFileMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXFileMessageP, Builder>.PrintField("FileData", this.hasFileData, this.fileData_, writer);
            GeneratedMessageLite<WXFileMessageP, Builder>.PrintField("FileName", this.hasFileName, this.fileName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXFileMessagePFieldNames;
            if (this.hasFileData)
            {
                output.WriteBytes(1, strArray[0], this.FileData);
            }
            if (this.hasFileName)
            {
                output.WriteString(2, strArray[1], this.FileName);
            }
        }

        // Properties
        public static WXFileMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXFileMessageP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public ByteString FileData
        {
            get
            {
                return this.fileData_;
            }
        }

        public string FileName
        {
            get
            {
                return this.fileName_;
            }
        }

        public override bool IsInitialized
        {
            get
            {
                if (!this.hasFileData)
                {
                    return false;
                }
                if (!this.hasFileName)
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
                    if (this.hasFileData)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeBytesSize(1, this.FileData);
                    }
                    if (this.hasFileName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.FileName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXFileMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [CompilerGenerated, DebuggerNonUserCode, GeneratedCode("ProtoGen", "2.3.0.277")]
        public sealed class Builder : GeneratedBuilderLite<WXFileMessageP, WXFileMessageP.Builder>
        {
            
            private WXFileMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXFileMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXFileMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXFileMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXFileMessageP.Builder Clear()
            {
                this.result = WXFileMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXFileMessageP.Builder ClearFileData()
            {
                this.PrepareBuilder();
                this.result.hasFileData = false;
                this.result.fileData_ = ByteString.Empty;
                return this;
            }

            public WXFileMessageP.Builder ClearFileName()
            {
                this.PrepareBuilder();
                this.result.hasFileName = false;
                this.result.fileName_ = "";
                return this;
            }

            public override WXFileMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXFileMessageP.Builder(this.result);
                }
                return new WXFileMessageP.Builder().MergeFrom(this.result);
            }

            public override WXFileMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXFileMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXFileMessageP)
                {
                    return this.MergeFrom((WXFileMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXFileMessageP.Builder MergeFrom(WXFileMessageP other)
            {
                return this;
            }

            public override WXFileMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXFileMessageP._wXFileMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXFileMessageP._wXFileMessagePFieldTags[index];
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
                                this.result.hasFileData = input.ReadBytes(ref this.result.fileData_);
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
                    this.result.hasFileName = input.ReadString(ref this.result.fileName_);
                }
                return this;
            }

            private WXFileMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXFileMessageP result = this.result;
                    this.result = new WXFileMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXFileMessageP.Builder SetFileData(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFileData = true;
                this.result.fileData_ = value;
                return this;
            }

            public WXFileMessageP.Builder SetFileName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFileName = true;
                this.result.fileName_ = value;
                return this;
            }

            // Properties
            public override WXFileMessageP DefaultInstanceForType
            {
                get
                {
                    return WXFileMessageP.DefaultInstance;
                }
            }

            public ByteString FileData
            {
                get
                {
                    return this.result.FileData;
                }
                set
                {
                    this.SetFileData(value);
                }
            }

            public string FileName
            {
                get
                {
                    return this.result.FileName;
                }
                set
                {
                    this.SetFileName(value);
                }
            }

            public override bool IsInitialized
            {
                get
                {
                    return this.result.IsInitialized;
                }
            }

            protected override WXFileMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override WXFileMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }

}
