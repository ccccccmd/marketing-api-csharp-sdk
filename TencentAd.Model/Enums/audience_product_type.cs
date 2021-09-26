namespace TencentAd.Model.Enums
{
    /// <summary>
    ///     https://developers.e.qq.com/docs/reference/enum?version=1.3#audience_product_type
    ///     商品类型
    /// </summary>
    public enum audience_product_type
    {
        /// <summary>
        ///     腾讯开放平台移动应用，创建广告前需通过 products/add 接口（V1.0）、promoted_objects/add 接口（V1.1）登记腾讯开放平台的应用 id，创建广告时需填写之前登记的应用
        ///     id，仅普通展示广告（campaign_type = CAMPAIGN_TYPE_NORMAL）支持
        /// </summary>
        PRODUCT_TYPE_APP_ANDROID_OPEN_PLATFORM,

        /// <summary>
        ///     苹果应用，创建广告前需通过 products/add 接口（V1 .0）、promoted_objects/add 接口（V1 .1）登记 App Store 的应用 id，创建广告时需填写之前登记的应用
        ///     id，仅普通展示广告（campaign_type = CAMPAIGN_TYPE_NORMAL）支持
        /// </summary>
        PRODUCT_TYPE_APP_IOS,

        /// <summary>
        ///     京东 POP 商户直投广告，创建广告时无需先创建和指定标的物
        /// </summary>
        PRODUCT_TYPE_LINK_JD,

        /// <summary>
        ///     点评商铺，创建广告时无需先创建和指定标的物
        /// </summary>
        PRODUCT_TYPE_DIANPING_SHOP,

        /// <summary>
        ///     点评优惠券，创建广告时无需先创建和指定标的物
        /// </summary>
        PRODUCT_TYPE_DIANPING_COUPON,

        /// <summary>
        ///     点评团购，创建广告时无需先创建和指定标的物
        /// </summary>
        PRODUCT_TYPE_DIANPING_TUAN,

        /// <summary>
        ///     电商推广，创建广告时无需创建和指定标的物，所有的 campaign_type 均支持投放
        /// </summary>
        PRODUCT_TYPE_ECOMMERCE,

        /// <summary>
        ///     微信品牌页，创建广告时无需创建和指定标的物，仅微信公众号广告（campaign_type = CAMPAIGN_TYPE_WECHAT_OFFICIAL_ACCOUNTS）以及微信朋友圈广告（campaign_type
        ///     =CAMPAIGN_TYPE_WECHAT_MOMENTS）支持
        /// </summary>
        PRODUCT_TYPE_LINK_WECHAT,

        /// <summary>
        ///     QQ 公众平台消息广告
        /// </summary>
        PRODUCT_TYPE_LINK_MOBILE_QQ_MP,

        /// <summary>
        ///     移动联盟 app
        /// </summary>
        PRODUCT_TYPE_APP_ANDROID_UNION,

        /// <summary>
        ///     微信本地门店推广，创建广告前需在对应的微信公众号中注册登记门店信息，创建广告时需填写之前登记的门店 id，仅微信朋友圈广告（campaign_type
        ///     =CAMPAIGN_TYPE_WECHAT_MOMENTS）支持门店信息的登记及获取可以通过微信公众平台提供的接口进行操作，具体方式可以参考 [本地门店的创建及获取]
        /// </summary>
        PRODUCT_TYPE_LBS_WECHAT,

        /// <summary>
        ///     认证空间-视频说说
        /// </summary>
        PRODUCT_TYPE_QZONE_PAGE_VIDEO,

        /// <summary>
        ///     普通链接，创建广告时无需创建和指定标的物，仅普通展示广告（campaign_type = CAMPAIGN_TYPE_NORMAL）支持
        /// </summary>
        PRODUCT_TYPE_LINK
    }
}