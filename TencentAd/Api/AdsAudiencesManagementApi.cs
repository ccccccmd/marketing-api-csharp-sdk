using System.Threading.Tasks;
using TencentAd.Model.AudiencesManagement;

namespace TencentAd.Api
{
    public class AdsAudiencesManagementApi
    {
        /// <summary>
        ///     获取客户人群
        ///     https://developers.e.qq.com/docs/api/audiences_management/custom_audience/custom_audiences_get?version=1.3
        /// </summary>
        /// <param name="req"></param>
        /// <param name="accessToken"></param>
        /// <param name="fields"></param>
        /// <returns></returns>
        public Task<CustomAudiencesGetRes> CustomAudiencesGet(CustomAudiencesGetReq req, string accessToken,
            string[] fields)
        {
            return TencentAdBaseApi.GetAsync<CustomAudiencesGetRes>("/custom_audiences/get", req, accessToken, fields);
        }
    }
}