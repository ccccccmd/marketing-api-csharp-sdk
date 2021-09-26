namespace TencentAd.Model.Enums
{
    /// <summary>
    ///     https://developers.e.qq.com/docs/reference/enum?version=1.3#api_operator
    /// </summary>
    public enum api_operator
    {
        /// <summary>
        ///     小于，应用于数字间的比较
        /// </summary>
        LT,

        /// <summary>
        ///     大于，应用于数字的比较
        /// </summary>
        GT,

        /// <summary>
        ///     等于，应用于数字、字符串、布尔型变量的比较
        /// </summary>
        EQ,

        /// <summary>
        ///     不等于，应用于数字、字符串、布尔型变量，比较
        /// </summary>
        NE,

        /// <summary>
        ///     包含，应用于字符串的包含
        /// </summary>
        CONTAIN,

        /// <summary>
        ///     不包含，等于字符串的不包含
        /// </summary>
        NOT_CONTAIN
    }
}