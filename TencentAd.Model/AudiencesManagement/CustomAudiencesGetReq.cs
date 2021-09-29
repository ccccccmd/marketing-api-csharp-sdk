using TencentAd.Model.Enums;

namespace TencentAd.Model.AudiencesManagement
{
    public class CustomAudiencesGetReq : TencentAdRequest
    {
        /// <summary>
        ///     推广帐号 id，有操作权限的帐号 id，包括代理商和广告主帐号 id
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     人群 id，通过 [custom_audiences] 模块创建客户人群获得
        /// </summary>
        public long audience_id { get; set; }

        /// <summary>
        ///     当前页码，默认 1 最小值 1，最大值 2147483647
        /// </summary>
        public int page { get; set; } = 1;

        /// <summary>
        ///     分页大小，默认 10 最小值 1，最大值 100
        /// </summary>
        public int page_size { get; set; } = 10;

        /// <summary>
        ///     数据应用，不填写默认为 DMP
        /// </summary>
        public data_platform platform { get; set; } = data_platform.DMP;
    }
}