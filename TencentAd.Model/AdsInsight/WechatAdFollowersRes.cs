using TencentAd.Model.Common;

namespace TencentAd.Model.AdsInsight
{
    public class WechatAdFollowersRes
    {
        /// <summary>
        ///     返回信息列表
        /// </summary>
        public WechatAdFollowersInfo[] list { get; set; }

        /// <summary>
        ///     分页配置信息
        /// </summary>
        public PageInfo page_info { get; set; }
    }
}