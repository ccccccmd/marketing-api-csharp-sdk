using TencentAd.Model.Enums;

namespace TencentAd.Model.AdsInsight
{
    public class WechatAdFollowersInfo
    {
        /// <summary>
        /// 用户标识，对当前公众号唯一
        /// </summary>
        public string openid { get; set; }

        /// <summary>
        /// 产生该关注的微信广告组 id（待废弃，请使用 adgroup_id 字段）
        /// </summary>
        public long wechat_adgroup_id { get; set; }

        /// <summary>
        /// 产生该关注的微信计划 id（待废弃，请使用 campiagn_id 字段）
        /// </summary>
        public long wechat_campaign_id { get; set; }

        /// <summary>
        /// 微信账号 id,即产生该关注的广告的广告主 appid
        /// </summary>
        public string wechat_account_id { get; set; }

        /// <summary>
        /// 	微信服务商 id
        /// </summary>
        public string wechat_agency_id { get; set; }

        /// <summary>
        /// 产生该关注的微信计划 id
        /// </summary>
        public long campaign_id { get; set; }

        /// <summary>
        /// 产生该关注的微信广告组 id
        /// </summary>
        public long adgroup_id { get; set; }

        /// <summary>
        /// 关注时间
        /// </summary>
        public long subscribe_time { get; set; }

        /// <summary>
        /// 	微信广告位信息
        /// </summary>
        public wechat_position_type position_type { get; set; }
    }
}