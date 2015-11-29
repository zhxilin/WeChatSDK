namespace MicroMsg.sdk
{
    public class WXAPIFactory
    {
        public static IWXAPI CreateWXAPI(string appId)
        {
            return new WXApiImpl(appId);
        }
    }
}
