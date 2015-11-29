namespace MicroMsg.sdk
{

    public abstract class BaseReq
    {
        
        public string Transaction { get; internal set; }
        public abstract int Type();

        internal abstract void FromProto(object protoObj);
        internal abstract object ToProto();
        internal abstract bool ValidateData();
    }
}
