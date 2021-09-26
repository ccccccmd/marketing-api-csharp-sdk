using System.Threading.Tasks;
using TencentAd.Model.AdsInsight;

namespace TencentAd.Api
{
    public class AdsInsightApi
    {
        /// <summary>
        ///     获取线索列表
        ///     https://developers.e.qq.com/docs/api/insights/leads/lead_clues_get?version=1.1
        /// </summary>
        /// <param name="req"></param>
        /// <param name="accessToken">授权令牌</param>
        /// <param name="fields">fields 取值范围为 get 接口返回的 list 中的字段。如不填写，则根据默认值进行返回</param>
        /// <returns></returns>
        public Task<LeadCluesGetRes> GetLeadClues(LeadCluesGetReq req, string accessToken, string[] fields)
        {
            return TencentAdBaseApi.PostAsync<LeadCluesGetRes>("/lead_clues/get", req, accessToken, fields);
        }

        /// <summary>
        ///     外部线索数据导入
        ///     https://developers.e.qq.com/docs/api/insights/leads/outer_clues_add?version=1.1
        /// </summary>
        /// <param name="req"></param>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public Task<OuterCluesAddRes> OuterCluesAdd(OuterCluesAddReq req, string accessToken)
        {
            return TencentAdBaseApi.PostAsync<OuterCluesAddRes>("/outer_clues/add", req, accessToken);
        }


        /// <summary>
        /// 获取微信广告关注信息
        /// https://developers.e.qq.com/docs/api/insights/wechat_ad_followers/wechat_ad_followers_get?version=1.3
        /// </summary>
        /// <param name="req"></param>
        /// <param name="accessToken"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public Task<WechatAdFollowersRes> WechatAdFollowersGet(WechatAdFollowersReq req, string accessToken,
            string[] fields)
        {
            return TencentAdBaseApi.GetAsync<WechatAdFollowersRes>("/wechat_ad_followers/get", req, accessToken, fields);
        }
    }
}