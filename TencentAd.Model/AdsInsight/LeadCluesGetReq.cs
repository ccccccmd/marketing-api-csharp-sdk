using TencentAd.Model.Common;

namespace TencentAd.Model.AdsInsight
{
    public class LeadCluesGetReq : TencentAdRequest
    {
        public LeadCluesGetReq(long accountId, TimeRange timeRange)
        {
            account_id = accountId;
            time_range = timeRange;
        }

        /// <summary>
        ///     广告主账号 id，直客账号或子客账号
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     搜索页码，默认值：1 最小值 1，最大值 1000
        /// </summary>
        public long page { get; set; } = 1;

        /// <summary>
        ///     一页显示的数据条数，默认值：50 最小值 1，最大值 200
        /// </summary>

        public long page_size { get; set; } = 50;

        /// <summary>
        ///     线索深度翻页参数-线索提交时间和线索 id
        /// </summary>
        public string[] last_search_after_values { get; set; }

        /// <summary>
        ///     时间范围，根据表单最后提交时间进行查询。最长跨度 1 年
        /// </summary>
        public TimeRange time_range { get; set; }

        /// <summary>
        ///     过滤条件，若此字段不传，或传空则视为无限制条件，数组最小长度 0，最大长度 100
        /// </summary>

        public Filtering[] filtering { get; set; }
    }
}