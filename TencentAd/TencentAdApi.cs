using TencentAd.Api;

namespace TencentAd
{
    public class TencentAdApi
    {
        /// <summary>
        ///     数据上报
        /// </summary>
        public UserDataApi UserData => new UserDataApi();

        /// <summary>
        ///     授权认证
        /// </summary>
        public OAuthApi OAuth => new OAuthApi(TencentAdContext.ClientConfig);

        /// <summary>
        ///     数据洞察
        /// </summary>
        public AdsInsightApi Insight => new AdsInsightApi();
    }
}