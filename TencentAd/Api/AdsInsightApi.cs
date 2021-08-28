using System.Threading.Tasks;
using TencentAd.Model.AdsInsight;

namespace TencentAd.Api
{
    public class AdsInsightApi
    {
        /// <summary>
        ///     获取线索列表
        /// </summary>
        /// <param name="req"></param>
        /// <param name="accessToken">授权令牌</param>
        /// <param name="fields">fields 取值范围为 get 接口返回的 list 中的字段。如不填写，则根据默认值进行返回</param>
        /// <returns></returns>
        public Task<LeadCluesGetRes> GetLeadClues(LeadCluesGetReq req, string accessToken, string[] fields)
        {
            return TencentAdBaseApi.PostAsync<LeadCluesGetRes>("/lead_clues/get", req, accessToken, fields);
        }
    }
}