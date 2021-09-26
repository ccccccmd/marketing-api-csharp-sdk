using TencentAd.Model.Common;

namespace TencentAd.Model.AudiencesManagement
{
    public class CustomAudiencesGetRes
    {
        /// <summary>
        ///     返回信息列表
        /// </summary>
        public CustomAudiencesInfo[] list { get; set; }

        /// <summary>
        ///     分页配置信息
        /// </summary>
        public PageInfo page_info { get; set; }
    }
}