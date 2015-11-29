using System.Threading.Tasks;

namespace MicroMsg.sdk
{
    public interface IWXAPI
    {
        
        void OpenWXApp();
        Task<string> SendReq(BaseReq request, string targetAppId = ConstantsAPI.WECHAT_APP_ID);
        Task<bool> SendResp(BaseResp response, string targetAppId = ConstantsAPI.WECHAT_APP_ID);
    }

}
