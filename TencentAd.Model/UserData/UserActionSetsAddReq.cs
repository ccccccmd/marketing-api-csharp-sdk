using TencentAd.Model.Enums;

namespace TencentAd.Model.UserData
{
    /// <summary>
    ///     创建用户行为数据源
    /// </summary>
    public class UserActionSetsAddReq : TencentAdRequest
    {
        /// <summary>
        ///     推广帐号 id，有操作权限的帐号 id，包括代理商和广告主帐号 id
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     用户行为源类型
        /// </summary>
        public am_user_action_set_type type { get; set; }

        /// <summary>
        ///     应用 id，IOS：App Store id ； ANDROID：应用宝 id，type=ANDROID 或 IOS 时必填
        /// </summary>
        public long mobile_app_id { get; set; }

        /// <summary>
        ///     微信 AppID，当 type = WECHAT 或 WECHAT_MINI_PROGRAM 或 WECHAT_MINI_GAME 时必填
        /// </summary>
        public string wechat_app_id { get; set; }

        /// <summary>
        ///     用户行为源名称，当 type=WEB 时必填，当 type=ANDROID 或 IOS 时，若未填写该字段，则默认通过 mobile_app_id 获取名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     用户行为源描述
        /// </summary>
        public string description { get; set; }

        public am_user_action_set_type[] usages { get; set; }

        /// <summary>
        ///     是否开启转化归因，true 表示开启，false 表示不开启，不传则默认开启
        /// </summary>
        public bool enable_conversion_claim { get; set; } = true;
    }
}