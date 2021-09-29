using TencentAd.Api;

namespace TencentAd
{
    public class TencentAdApi
    {
        /// <summary>
        ///     数据上报
        /// </summary>
        public UserDataApi UserData => new();

        /// <summary>
        ///     授权认证
        /// </summary>
        public OAuthApi OAuth => new(TencentAdContext.ClientConfig);

        /// <summary>
        ///     数据洞察
        /// </summary>
        public AdsInsightApi Insight => new();

        /// <summary>
        ///     人群管理
        /// </summary>
        public AdsAudiencesManagementApi AudiencesManagementApi => new();
    }
}