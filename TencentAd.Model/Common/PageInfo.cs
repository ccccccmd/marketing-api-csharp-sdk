namespace TencentAd.Model.Common
{
    public class PageInfo
    {
        /// <summary>
        ///     搜索页码
        /// </summary>
        public long page { get; set; }

        /// <summary>
        ///     一页显示的数据条数
        /// </summary>
        public long page_size { get; set; }

        /// <summary>
        ///     总条数
        /// </summary>
        public long total_number { get; set; }

        /// <summary>
        ///     总页数
        /// </summary>
        public long total_page { get; set; }
    }
}