using System.Threading.Tasks;

namespace MicroMsg.sdk
{
    public interface IWXAPI
    {
        
        void OpenWXApp();
        Task<string> SendReqAsync(BaseReq request, string targetAppId = ConstantsAPI.WECHAT_APP_ID);
        Task<bool> SendRespAsync(BaseResp response, string targetAppId = ConstantsAPI.WECHAT_APP_ID);
    }

}
