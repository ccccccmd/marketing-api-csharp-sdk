namespace TencentAd.Model.Enums
{
    /// <summary>
    ///     线索匹配类型
    /// </summary>
    public enum MatchTypeEnum
    {
        /// <summary>
        ///     无，不需要与线索平台已有线索匹配
        /// </summary>
        NONE,

        /// <summary>
        ///     线索 id，使用腾讯广告线索管理平台的线索唯一 id 匹配
        /// </summary>
        LEADSID,

        /// <summary>
        ///     外部线索 id，使用客户侧的线索唯一 id 与线索平台已有的线索匹配
        /// </summary>
        OUTERLEADSID,

        /// <summary>
        ///     联系方式，使用联系方式与线索平台已有的线索匹配，优先级：leads_tel>leads_wechat>leads_qq
        /// </summary>
        CONTACT,

        /// <summary>
        ///     点击 id，使用腾讯广告点击 id 与线索平台已有的线索匹配
        /// </summary>
        CLICKID
    }
}