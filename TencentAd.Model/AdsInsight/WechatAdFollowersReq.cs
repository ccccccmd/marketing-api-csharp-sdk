using TencentAd.Model.Common;

namespace TencentAd.Model.AdsInsight
{
    public class WechatAdFollowersReq:TencentAdRequest
    {
        
        /// <summary>
        ///     搜索页码，默认值：1 最小值 1，最大值 1000
        /// </summary>
        public long page { get; set; } = 1;

        /// <summary>
        ///     一页显示的数据条数，默认值：50 最小值 1，最大值 200
        /// </summary>

        public long page_size { get; set; } = 50;

     

        /// <summary>
        ///     时间范围，最多支持查询最近 30 天产生的关注数据；单次查询的最长跨度为 30 天；该时间表示用户关注公众号的时间；
        /// </summary>
        public TimeRange time_range { get; set; }
        
    }
}