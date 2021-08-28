namespace TencentAd.Model.Enums
{
    /// <summary>
    ///     线索类型
    /// </summary>
    public enum LeadsTypeEnum
    {
        /// <summary>
        ///     表单预约
        /// </summary>
        /// <returns></returns>
        LEADS_TYPE_FORM,

        /// <summary>
        ///     在线咨询
        /// </summary>
        LEADS_TYPE_ONLINE_CONSULT,

        /// <summary>
        ///     普通电话
        /// </summary>
        LEADS_TYPE_MAKE_PHONE_CALL,

        /// <summary>
        ///     智能电话
        /// </summary>
        LEADS_TYPE_PHONE,

        /// <summary>
        ///     发券
        /// </summary>
        LEADS_TYPE_PROMOTION_COUPON,

        /// <summary>
        ///     智能咨询
        /// </summary>
        LEADS_TYPE_INTELLIGENT_TOOL,

        /// <summary>
        ///     抽奖
        /// </summary>
        LEADS_TYPE_LOTTERY,

        /// <summary>
        ///     落地页点击
        /// </summary>
        LEADS_TYPE_LANDING_PAGE_CLICK,

        /// <summary>
        ///     一键授权
        /// </summary>
        LEADS_TYPE_ONE_CLICK_AUTHORIZE,

        /// <summary>
        ///     加企业微信客服
        /// </summary>
        LEADS_TYPE_PAGE_SCAN_CODE,

        /// <summary>
        ///     微信关注
        /// </summary>
        LEADS_TYPE_PROMOTION_FOLLOW
    }

    /// <summary>
    ///     线索用户类型
    /// </summary>
    public enum LeadsUserTypeEnum
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


    public enum LeadsGenderTypeEnum
    {
        /// <summary>
        ///     未知
        /// </summary>
        GENDER_TYPE_UNKNOWN,

        /// <summary>
        ///     女性
        /// </summary>
        GENDER_TYPE_FEMALE,

        /// <summary>
        ///     男性
        /// </summary>
        GENDER_TYPE_MALE
    }
}