using TencentAd.Model.Enums;

namespace TencentAd.Model.AdsInsight
{
    public class LeadCluesInfo
    {
        /// <summary>
        ///     广告主账号 id，直客账号或子客账号
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     线索 id
        /// </summary>
        public long leads_id { get; set; }

        /// <summary>
        ///     外部线索 id，作为线索管理平台的线索与客户侧 CRM 系统的线索关联的唯一标识
        /// </summary>
        public string outer_leads_id { get; set; }

        /// <summary>
        ///     点击 id，预览数据的点击 id 为空
        /// </summary>
        public string click_id { get; set; }

        /// <summary>
        ///     服务商 id：广点通服务商=服务商 id 微信服务商=服务商 spid
        /// </summary>
        public string agency_id { get; set; }

        /// <summary>
        ///     服务商名称
        /// </summary>
        public string agency_name { get; set; }

        /// <summary>
        ///     微信 appId
        /// </summary>
        public string wechat_appid { get; set; }

        /// <summary>
        ///     推广计划 id
        /// </summary>
        public string campaign_id { get; set; }

        /// <summary>
        ///     推广计划名称
        /// </summary>
        public string campaign_name { get; set; }

        /// <summary>
        ///     广告 id
        /// </summary>
        public string adgroup_id { get; set; }

        /// <summary>
        ///     广告名称
        /// </summary>
        public string adgroup_name { get; set; }

        /// <summary>
        ///     创意 id（废弃中）
        /// </summary>
        public string creative_id { get; set; }

        /// <summary>
        ///     创意名称
        /// </summary>
        public string creative_name { get; set; }

        /// <summary>
        ///     组件 id
        /// </summary>
        public string component_id { get; set; }

        /// <summary>
        ///     组件名称
        /// </summary>
        public string component_name { get; set; }

        /// <summary>
        ///     落地页 id
        /// </summary>
        public string page_id { get; set; }

        /// <summary>
        ///     落地页名称
        /// </summary>
        public string page_name { get; set; }

        /// <summary>
        ///     落地页地址
        /// </summary>
        public string page_url { get; set; }

        /// <summary>
        ///     线索类型
        /// </summary>
        public lead_clues_leads_type? leads_type { get; set; }

        /// <summary>
        ///     线索来源
        ///     OUTER_TRAFFIC : 其他OFFLINE : 外部导入AD_PREVIEW : 广告创意XJ : 蹊径落地页 ONE_LEAF : 一叶智能 WECHAT_CANVAS : 微信原生推广页 XUNDA : 讯达小程序
        ///     INTERACTIVEPAGE : 互动落地页
        /// </summary>
        public string leads_source { get; set; }

        //系统评分
        public string leads_potential_score { get; set; }

        /// <summary>
        ///     线索状态
        ///     LEADS_FOLLOW_TAG_DEFAULT : 未分配LEADS_FOLLOW_TAG_ASSIGNED : 已分配待跟进LEADS_FOLLOW_TAG_FOLLOWING :
        ///     跟进中LEADS_FOLLOW_TAG_VALID : 已转换-潜在客户 LEADS_FOLLOW_TAG_VALID_HIGH_INTENTION : 已转换-已成单
        ///     LEADS_FOLLOW_TAG_VALID_CONVERTED : 无效-重复LEADS_FOLLOW_TAG_INVALID_REPEAT : 无效-非本人LEADS_FOLLOW_TAG_INVALID_NOTSELF :
        ///     无效-未接通LEADS_FOLLOW_TAG_INVALID_NOTTOUCH : 无效-无意向LEADS_FOLLOW_TAG_INVALID_NOTINTENTION :
        ///     已转换-高意向客户LEADS_FOLLOW_TAG_INVALID_REGION_MISMATCHED : 无效-定向外LEADS_FOLLOW_TAG_INVALID_OTHER : 无效-其他
        /// </summary>
        public string leads_follow_tag { get; set; }

        /// <summary>
        ///     外部线索状态
        /// </summary>
        public string outer_leads_convert_type { get; set; }

        /// <summary>
        ///     外部无效原因
        /// </summary>
        public string outer_leads_ineffect_reason { get; set; }

        /// <summary>
        ///     线索用户 id
        /// </summary>
        public string leads_user_id { get; set; }

        /// <summary>
        ///     线索用户类型
        /// </summary>
        public leads_user_type? leads_user_type { get; set; }

        /// <summary>
        ///     线索用户的微信 AppId，微信公众号/小程序/小游戏的开发者 id
        /// </summary>
        public string leads_user_wechat_appid { get; set; }

        /// <summary>
        ///     姓名
        /// </summary>
        public string leads_name { get; set; }

        /// <summary>
        ///     电话
        /// </summary>
        public string leads_telephone { get; set; }

        /// <summary>
        ///     号码归属地，非用户常驻地
        /// </summary>
        public string telephone_location { get; set; }

        /// <summary>
        ///     所在地
        /// </summary>
        public string leads_area { get; set; }

        /// <summary>
        ///     邮箱
        /// </summary>
        public string leads_email { get; set; }

        /// <summary>
        ///     qq 号
        /// </summary>
        public string leads_qq { get; set; }

        /// <summary>
        ///     微信号
        /// </summary>
        public string leads_wechat { get; set; }

        /// <summary>
        ///     性别
        /// </summary>
        public lead_clues_gender_type? leads_gender { get; set; }

        /// <summary>
        ///     国籍
        /// </summary>
        public string nationality { get; set; }

        /// <summary>
        ///     工作年限
        /// </summary>
        public string working_years { get; set; }

        /// <summary>
        ///     年龄
        /// </summary>
        public string age { get; set; }

        /// <summary>
        ///     职业
        /// </summary>
        public string profession { get; set; }

        /// <summary>
        ///     身份证号
        /// </summary>
        public string id_number { get; set; }

        /// <summary>
        ///     详细地址
        /// </summary>
        public string address { get; set; }

        /// <summary>
        ///     其他表单字段
        /// </summary>
        public string bundle { get; set; }

        /// <summary>
        ///     广告位类型
        /// </summary>
        public long pos_type { get; set; }

        /// <summary>
        ///     线索入库时间，表示录入线索管理平台时间。
        /// </summary>

        public string leads_create_time { get; set; }

        /// <summary>
        ///     线索提交时间，表示用户留资时间或拨打电话时间
        /// </summary>
        public string leads_action_time { get; set; }

        /// <summary>
        ///     线索标签
        /// </summary>
        public string leads_tags { get; set; }

        /// <summary>
        ///     门店名称
        /// </summary>
        public string shop_name { get; set; }

        /// <summary>
        ///     门店地址
        /// </summary>
        public string shop_address { get; set; }
    }
}