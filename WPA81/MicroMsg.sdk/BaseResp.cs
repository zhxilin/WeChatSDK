namespace MicroMsg.sdk
{
    public abstract class BaseResp
    {
        
        public int ErrCode { get; internal set; }
        public string ErrStr { get; internal set; }
        public string Transaction { get; internal set; }
        
        public abstract int Type();

        internal abstract void FromProto(object protoObj);
        internal abstract object ToProto();
        internal abstract bool ValidateData();
    }
}
