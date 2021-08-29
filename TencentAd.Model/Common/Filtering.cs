using TencentAd.Model.Enums;

namespace TencentAd.Model.Common
{
    public class Filtering
    {
        /// <summary>
        ///     过滤字段
        /// </summary>
        public string field { get; set; }

        /// <summary>
        ///     field 取值
        /// </summary>
        public string[] values { get; set; }

        /// <summary>
        ///     操作符
        /// </summary>
        public operator_type @operator { get; set; }
    }
}