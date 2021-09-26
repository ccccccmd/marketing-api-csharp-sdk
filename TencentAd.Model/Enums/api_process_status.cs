namespace TencentAd.Model.Enums
{
    /// <summary>
    ///     https://developers.e.qq.com/docs/reference/enum?version=1.3#api_process_status
    /// </summary>
    public enum api_process_status
    {
        /// <summary>
        ///     待处理
        /// </summary>
        PENDING,

        /// <summary>
        ///     处理中
        /// </summary>
        PROCESSING,

        /// <summary>
        ///     成功可用
        /// </summary>
        SUCCESS,

        /// <summary>
        ///     错误
        /// </summary>
        ERROR,

        /// <summary>
        ///     冻结
        /// </summary>
        FROZEN,

        /// <summary>
        ///     解冻中
        /// </summary>
        THAWING,

        /// <summary>
        ///     锁定
        /// </summary>
        LOCKING
    }
}