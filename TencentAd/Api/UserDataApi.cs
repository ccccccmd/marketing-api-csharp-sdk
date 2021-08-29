using System.Threading.Tasks;
using TencentAd.Model.UserData;

namespace TencentAd.Api
{
    
    
    /// <summary>
    /// 数据上报
    /// </summary>
    public class UserDataApi
    {
        /// <summary>
        ///     上传用户行为数据
        ///     https://developers.e.qq.com/docs/api/user_data/user_action/user_actions_add?version=1.1
        /// </summary>
        public Task<UserActionsAddRes> UserActionsAdd(UserActionsAddReq req, string accessToken)
        {
            return TencentAdBaseApi.PostAsync<UserActionsAddRes>("/user_actions/add", req, accessToken);
        }

        /// <summary>
        ///     创建用户行为数据源
        ///     https://developers.e.qq.com/docs/api/user_data/user_action_set/user_action_sets_add?version=1.1
        /// </summary>
        /// <param name="req"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public Task<UserActionSetsAddRes> UserActionSetsAdd(UserActionsAddReq req, string accessToken)
        {
            return TencentAdBaseApi.PostAsync<UserActionSetsAddRes>("/user_action_sets/add", req, accessToken);
        }
    }
}