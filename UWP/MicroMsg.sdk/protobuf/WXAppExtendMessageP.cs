using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Google.ProtocolBuffers;

namespace MicroMsg.sdk.protobuf
{
    internal sealed class WXAppExtendMessageP : GeneratedMessageLite<WXAppExtendMessageP, WXAppExtendMessageP.Builder>
    {
        
        private static readonly string[] _wXAppExtendMessagePFieldNames = new string[] { "ExtInfo", "FileData", "FileName" };
        private static readonly uint[] _wXAppExtendMessagePFieldTags = new uint[] { 0x12, 10, 0x1a };
        private static readonly WXAppExtendMessageP defaultInstance = new WXAppExtendMessageP().MakeReadOnly();
        private string extInfo_ = "";
        public const int ExtInfoFieldNumber = 2;
        private ByteString fileData_ = ByteString.Empty;
        public const int FileDataFieldNumber = 1;
        private string fileName_ = "";
        public const int FileNameFieldNumber = 3;
        private bool hasExtInfo;
        private bool hasFileData;
        private bool hasFileName;
        private int memoizedSerializedSize = -1;

        
        static WXAppExtendMessageP()
        {
            object.ReferenceEquals(Proto.WXAppExtendMessageP.Descriptor, null);
        }

        private WXAppExtendMessageP()
        {
        }

        public static Builder CreateBuilder()
        {
            return new Builder();
        }

        public static Builder CreateBuilder(WXAppExtendMessageP prototype)
        {
            return new Builder(prototype);
        }

        public override Builder CreateBuilderForType()
        {
            return new Builder();
        }

        public override bool Equals(object obj)
        {
            WXAppExtendMessageP ep = obj as WXAppExtendMessageP;
            if (ep == null)
            {
                return false;
            }
            if ((this.hasFileData != ep.hasFileData) || (this.hasFileData && !this.fileData_.Equals(ep.fileData_)))
            {
                return false;
            }
            if ((this.hasExtInfo != ep.hasExtInfo) || (this.hasExtInfo && !this.extInfo_.Equals(ep.extInfo_)))
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
            if (this.hasExtInfo)
            {
                hashCode ^= this.extInfo_.GetHashCode();
            }
            if (this.hasFileName)
            {
                hashCode ^= this.fileName_.GetHashCode();
            }
            return hashCode;
        }

        private WXAppExtendMessageP MakeReadOnly()
        {
            return this;
        }

        public static WXAppExtendMessageP ParseFrom(byte[] data)
        {
            return CreateBuilder().MergeFrom(data).BuildParsed();
        }

        public override void PrintTo(TextWriter writer)
        {
            GeneratedMessageLite<WXAppExtendMessageP, Builder>.PrintField("FileData", this.hasFileData, this.fileData_, writer);
            GeneratedMessageLite<WXAppExtendMessageP, Builder>.PrintField("ExtInfo", this.hasExtInfo, this.extInfo_, writer);
            GeneratedMessageLite<WXAppExtendMessageP, Builder>.PrintField("FileName", this.hasFileName, this.fileName_, writer);
        }

        public override Builder ToBuilder()
        {
            return CreateBuilder(this);
        }

        public override void WriteTo(ICodedOutputStream output)
        {
            int serializedSize = this.SerializedSize;
            string[] strArray = _wXAppExtendMessagePFieldNames;
            if (this.hasFileData)
            {
                output.WriteBytes(1, strArray[1], this.FileData);
            }
            if (this.hasExtInfo)
            {
                output.WriteString(2, strArray[0], this.ExtInfo);
            }
            if (this.hasFileName)
            {
                output.WriteString(3, strArray[2], this.FileName);
            }
        }

        // Properties
        public static WXAppExtendMessageP DefaultInstance
        {
            get
            {
                return defaultInstance;
            }
        }

        public override WXAppExtendMessageP DefaultInstanceForType
        {
            get
            {
                return DefaultInstance;
            }
        }

        public string ExtInfo
        {
            get
            {
                return this.extInfo_;
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
                    if (this.hasExtInfo)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(2, this.ExtInfo);
                    }
                    if (this.hasFileName)
                    {
                        memoizedSerializedSize += CodedOutputStream.ComputeStringSize(3, this.FileName);
                    }
                    this.memoizedSerializedSize = memoizedSerializedSize;
                }
                return memoizedSerializedSize;
            }
        }

        protected override WXAppExtendMessageP ThisMessage
        {
            get
            {
                return this;
            }
        }

        // Nested Types
        [GeneratedCode("ProtoGen", "2.3.0.277"), DebuggerNonUserCode, CompilerGenerated]
        public sealed class Builder : GeneratedBuilderLite<WXAppExtendMessageP, WXAppExtendMessageP.Builder>
        {
            
            private WXAppExtendMessageP result;
            private bool resultIsReadOnly;

            
            public Builder()
            {
                this.result = WXAppExtendMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
            }

            internal Builder(WXAppExtendMessageP cloneFrom)
            {
                this.result = cloneFrom;
                this.resultIsReadOnly = true;
            }

            public override WXAppExtendMessageP BuildPartial()
            {
                if (this.resultIsReadOnly)
                {
                    return this.result;
                }
                this.resultIsReadOnly = true;
                return this.result.MakeReadOnly();
            }

            public override WXAppExtendMessageP.Builder Clear()
            {
                this.result = WXAppExtendMessageP.DefaultInstance;
                this.resultIsReadOnly = true;
                return this;
            }

            public WXAppExtendMessageP.Builder ClearExtInfo()
            {
                this.PrepareBuilder();
                this.result.hasExtInfo = false;
                this.result.extInfo_ = "";
                return this;
            }

            public WXAppExtendMessageP.Builder ClearFileData()
            {
                this.PrepareBuilder();
                this.result.hasFileData = false;
                this.result.fileData_ = ByteString.Empty;
                return this;
            }

            public WXAppExtendMessageP.Builder ClearFileName()
            {
                this.PrepareBuilder();
                this.result.hasFileName = false;
                this.result.fileName_ = "";
                return this;
            }

            public override WXAppExtendMessageP.Builder Clone()
            {
                if (this.resultIsReadOnly)
                {
                    return new WXAppExtendMessageP.Builder(this.result);
                }
                return new WXAppExtendMessageP.Builder().MergeFrom(this.result);
            }

            public override WXAppExtendMessageP.Builder MergeFrom(ICodedInputStream input)
            {
                return this.MergeFrom(input, ExtensionRegistry.Empty);
            }

            public override WXAppExtendMessageP.Builder MergeFrom(IMessageLite other)
            {
                if (other is WXAppExtendMessageP)
                {
                    return this.MergeFrom((WXAppExtendMessageP)other);
                }
                base.MergeFrom(other);
                return this;
            }

            public override WXAppExtendMessageP.Builder MergeFrom(WXAppExtendMessageP other)
            {
                return this;
            }

            public override WXAppExtendMessageP.Builder MergeFrom(ICodedInputStream input, ExtensionRegistry extensionRegistry)
            {
                uint num;
                string str;
                this.PrepareBuilder();
                while (input.ReadTag(out num, out str))
                {
                    if ((num == 0) && (str != null))
                    {
                        int index = Array.BinarySearch<string>(WXAppExtendMessageP._wXAppExtendMessagePFieldNames, str, StringComparer.Ordinal);
                        if (index >= 0)
                        {
                            num = WXAppExtendMessageP._wXAppExtendMessagePFieldTags[index];
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
                            {
                                this.result.hasExtInfo = input.ReadString(ref this.result.extInfo_);
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
                    this.result.hasFileName = input.ReadString(ref this.result.fileName_);
                }
                return this;
            }

            private WXAppExtendMessageP PrepareBuilder()
            {
                if (this.resultIsReadOnly)
                {
                    WXAppExtendMessageP result = this.result;
                    this.result = new WXAppExtendMessageP();
                    this.resultIsReadOnly = false;
                    this.MergeFrom(result);
                }
                return this.result;
            }

            public WXAppExtendMessageP.Builder SetExtInfo(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasExtInfo = true;
                this.result.extInfo_ = value;
                return this;
            }

            public WXAppExtendMessageP.Builder SetFileData(ByteString value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFileData = true;
                this.result.fileData_ = value;
                return this;
            }

            public WXAppExtendMessageP.Builder SetFileName(string value)
            {
                ThrowHelper.ThrowIfNull(value, "value");
                this.PrepareBuilder();
                this.result.hasFileName = true;
                this.result.fileName_ = value;
                return this;
            }

            // Properties
            public override WXAppExtendMessageP DefaultInstanceForType
            {
                get
                {
                    return WXAppExtendMessageP.DefaultInstance;
                }
            }

            public string ExtInfo
            {
                get
                {
                    return this.result.ExtInfo;
                }
                set
                {
                    this.SetExtInfo(value);
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

            protected override WXAppExtendMessageP MessageBeingBuilt
            {
                get
                {
                    return this.PrepareBuilder();
                }
            }

            protected override WXAppExtendMessageP.Builder ThisBuilder
            {
                get
                {
                    return this;
                }
            }
        }
    }
}
