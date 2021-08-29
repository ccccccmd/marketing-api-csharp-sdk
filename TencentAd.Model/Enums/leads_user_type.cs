namespace TencentAd.Model.Enums
{
    /// <summary>
    ///     线索用户类型
    ///     https://developers.e.qq.com/docs/reference/enum?version=1.1#leads_user_type
    /// </summary>
    public enum leads_user_type
    {
        /// <summary>
        ///     QQ 号
        /// </summary>
        USER_TYPE_QQ,

        /// <summary>
        ///     QQ 号-MD5
        /// </summary>
        USER_TYPE_QQ_MD5,

        /// <summary>
        ///     手机号，11 位纯数字
        /// </summary>
        USER_TYPE_TEL,

        /// <summary>
        ///     手机号-MD5
        /// </summary>
        USER_TYPE_TEL_MD5,

        /// <summary>
        ///     IDFA，苹果设备 id
        /// </summary>
        USER_TYPE_IDFA,

        /// <summary>
        ///     IDFA-MD5
        /// </summary>
        USER_TYPE_IDFA_MD5,

        /// <summary>
        ///     IMEI，安卓设备 id
        /// </summary>
        USER_TYPE_IMEI,

        /// <summary>
        ///     IMEI-MD5
        /// </summary>
        USER_TYPE_IMEI_MD5,

        /// <summary>
        ///     广点通 OpenID
        /// </summary>
        USER_TYPE_GDT_OPENID,

        /// <summary>
        ///     MAC 地址
        /// </summary>
        USER_TYPE_MAC_ADDRESS,

        /// <summary>
        ///     MAC 地址-MD5
        /// </summary>
        USER_TYPE_MAC_ADDRESS_MD5,

        /// <summary>
        ///     OAID，移动安全联盟（MSA）制定的匿名设备标识符
        /// </summary>
        USER_TYPE_OAID,

        /// <summary>
        ///     OAID-MD5
        /// </summary>
        USER_TYPE_OAID_MD5,

        /// <summary>
        ///     微信 OpenID
        /// </summary>
        USER_TYPE_WX_OPENID,

        /// <summary>
        ///     微信 UnionID
        /// </summary>
        USER_TYPE_WX_UNIONID,

        /// <summary>
        ///     其他
        /// </summary>
        USER_TYPE_OTHERS
    }
}