using TencentAd.Model.Enums;

namespace TencentAd.Model.AdsInsight
{
    public class OuterCluesAddReq : TencentAdRequest
    {
        public OuterCluesAddReq(long accountId, OuterLeadsInfoAddInput[] leadsInfoList)
        {
            account_id = accountId;
            leads_info_list = leadsInfoList;
        }

        /// <summary>
        ///     广告主账号 id，直客账号或子客账号
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     线索匹配类型，不填认为是 NONE
        /// </summary>
        public leads_match_type match_type { get; set; } = leads_match_type.NONE;

        public OuterLeadsInfoAddInput[] leads_info_list { get; set; }
    }

    public class OuterLeadsInfoAddInput
    {
        public OuterLeadsInfoAddInput(string outerLeadsId, lead_clues_leads_type leadsType)
        {
            outer_leads_id = outerLeadsId;
            leads_type = leadsType;
        }

        /// <summary>
        ///     外部线索 id，作为线索管理平台的线索与客户侧 CRM 系统的线索关联的唯一标识
        /// </summary>
        public string outer_leads_id { get; set; }

        /// <summary>
        ///     线索 id match_type=LEADSID 时必填
        /// </summary>
        public long? leads_id { get; set; }

        /// <summary>
        ///     手机号
        /// </summary>
        public string leads_tel { get; set; }

        /// <summary>
        ///     QQ 号
        /// </summary>
        public string leads_qq { get; set; }

        /// <summary>
        ///     微信号
        /// </summary>
        public string leads_wechat { get; set; }

        /// <summary>
        ///     点击 id，用于线索归因，也可填写曝光 id（trace_id）
        /// </summary>
        public string click_id { get; set; }

        /// <summary>
        ///     线索类型
        /// </summary>

        public lead_clues_leads_type leads_type { get; set; }

        /// <summary>
        ///     线索用户 id
        /// </summary>
        public string leads_user_id { get; set; }

        /// <summary>
        ///     线索用户类型，线索用户 id 有值时必填
        /// </summary>

        public leads_user_type? leads_user_type { get; set; }

        /// <summary>
        ///     线索用户的微信 AppId（微信公众号/小程序/小游戏的开发者 id）
        /// </summary>
        public string leads_user_wechat_appid { get; set; }

        /// <summary>
        ///     姓名
        /// </summary>
        public string leads_name { get; set; }

        /// <summary>
        ///     性别
        /// </summary>

        public lead_clues_gender_type? leads_gender { get; set; }

        /// <summary>
        ///     邮箱
        /// </summary>
        public string leads_email { get; set; }

        /// <summary>
        ///     所在地
        /// </summary>
        public string leads_area { get; set; }

        /// <summary>
        ///     其他线索信息，K-V 键值对, 字符串对字符串的 json 串，key 不能重复
        /// </summary>
        public string bundle { get; set; }

        /// <summary>
        ///     外部线索状态，无效原因有值时必填
        /// </summary>
        public string outer_leads_convert_type { get; set; }

        /// <summary>
        ///     外部无效原因，线索状态为无效时填写
        /// </summary>
        public string outer_leads_ineffect_reason { get; set; }

        /// <summary>
        ///     线索渠道
        /// </summary>

        public outer_leads_comefrom? outer_leads_comefrom { get; set; }

        /// <summary>
        ///     备注
        /// </summary>
        public string memo { get; set; }
    }
}