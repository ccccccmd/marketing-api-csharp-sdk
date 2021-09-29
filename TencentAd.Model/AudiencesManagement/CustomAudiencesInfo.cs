using TencentAd.Model.Enums;

namespace TencentAd.Model.AudiencesManagement
{
    public class CustomAudiencesInfo
    {
        /// <summary>
        ///     人群 id
        /// </summary>
        public long audience_id { get; set; }

        /// <summary>
        ///     人群归属的推广帐号 id
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     人群名称
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     广告主对人群在自己系统里的编码
        /// </summary>
        public string external_audience_id { get; set; }

        /// <summary>
        ///     人群描述
        /// </summary>
        public string description { get; set; }

        /// <summary>
        ///     深度数据合作：可将您的数据数据从 DMP 平台导出，平台将为您进行定制化的挖掘，进行深度数据合作
        /// </summary>
        public bool cooperated { get; set; }

        /// <summary>
        ///     人群类型
        /// </summary>
        public api_audience_type type { get; set; }

        /// <summary>
        ///     处理状态
        /// </summary>
        public api_process_status status { get; set; }

        /// <summary>
        ///     人群错误码, 1 表示系统错误； 101 表示种子人群活跃用户低于 2K ； 102 表示种子人群无共同特征； 201 表示人群上传的号码包文件格式错误； 202 表示解析人群上传的号码包文件失败； 203
        ///     表示号码包文件人群匹配失败
        /// </summary>
        public long error_code { get; set; }

        /// <summary>
        ///     用户覆盖数
        /// </summary>

        public long user_count { get; set; }

        /// <summary>
        ///     创建时间，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string created_time { get; set; }

        /// <summary>
        ///     最后更新时间，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        public string last_modified_time { get; set; }

        /// <summary>
        ///     人群信息，和 type 相关
        /// </summary>
        public Audience_Spec audience_spec { get; set; }
    }

    public class Audience_Spec
    {
        /// <summary>
        ///     Lookalike 人群信息，当 type=LOOKALIKE 时必填
        /// </summary>
        public lookalike_spec lookalike_spec { get; set; }

        /// <summary>
        ///     UserAction 人群信息，当 type=USER_ACTION 时必填
        /// </summary>
        public user_action_spec user_action_spec { get; set; }

        /// <summary>
        ///     LBS 人群信息，当 type=LBS 时必填
        /// </summary>
        public lbs_spec lbs_spec { get; set; }

        /// <summary>
        ///     Keyword 人群信息，当 type=KEYWORD 时必填
        /// </summary>
        public keyword_spec keyword_spec { get; set; }

        /// <summary>
        ///     广告人群信息，当 type=AD 时必填
        /// </summary>
        public ad_rule_spec ad_rule_spec { get; set; }

        /// <summary>
        ///     组合人群信息，当 type=COMBINE 时必填，最多允许用 500 个人群做组合
        /// </summary>
        public combine_spec combine_spec { get; set; }
    }

    public class lookalike_spec
    {
        /// <summary>
        ///     种子人群 id，种子人群：覆盖人数 100-30000000, 状态必须是'成功可用', 不能是扩展人群
        /// </summary>
        public long seed_audience_id { get; set; }

        /// <summary>
        ///     lookalike 目标人数，是 500000 的整数倍
        /// </summary>
        public long expand_user_count { get; set; }
    }

    public class user_action_spec
    {
        /// <summary>
        ///     用户行为源 id，通过 [user_action_sets 接口] 创建用户行为源时分配的唯一 id。请注意，当填写的用户行为数据源类型为 {WECHAT, WECHAT_MINI_PROGRAM,
        ///     WECHAT_MINI_GAME} 时，必填 user_id 字段中的 wechat_openid (或 wechat_unionid) 及 wechat_app_id。
        /// </summary>
        public long user_action_set_id { get; set; }

        /// <summary>
        ///     匹配规则类型，当 user_action_set 为 Android/iOS APP 类型时只可选 ACTION，[枚举详情]
        /// </summary>
        public string match_rule_type { get; set; }

        /// <summary>
        ///     行为人群提取类型，当 match_rule_type=ACTION 时生效
        /// </summary>
        public string extract_type { get; set; }

        /// <summary>
        ///     时间窗，用来圈定最近多少天发生过某行为的人群，如今天是 1 月 14 日，则最近 14 天的范围是 1 月 1 日至 1 月 14 日。当 extractType = AGGREGATION 时，时间窗最大取值为 90 天
        /// </summary>
        public long gtime_window { get; set; }

        /// <summary>
        ///     url 匹配规则，当 match_rule_type = URL 时必填
        /// </summary>
        public url_match_rule url_match_rule { get; set; }

        /// <summary>
        ///     行为和参数匹配规则，当 match_rule_type = ACTION，extractType 为空或者 extractType = FITLER 时必填
        /// </summary>
        public action_match_rule action_match_rule { get; set; }

        /// <summary>
        ///     行为和参数聚合规则，当 match_rule_type = ACTION，extractType = AGGREGATION 时必填
        /// </summary>
        public action_aggregation_rule action_aggregation_rule { get; set; }
    }

    public class lbs_spec
    {
        /// <summary>
        ///     LBS 类型，LBS 类型只允许 POI、CROSS_CITY、CUSTOM_LOCATION
        /// </summary>
        public api_lbs_type lbs_type { get; set; }

        /// <summary>
        ///     跨城市规则，当 lbs_type=CROSS_CITY 时必填； route 不能超过 10 个
        /// </summary>
        public cross_city_rule cross_city_rule { get; set; }

        /// <summary>
        ///     POI 规则，当 lbs_type=POI 时必填； region_id 个数不能超过 50 个； poi_category_id 个数不能超过 10 个
        /// </summary>
        public poi_rule poi_rule { get; set; }

        /// <summary>
        ///     自定义地理位置规则，当 lbs_type=CUSTOM_LOCATION 时必填
        /// </summary>
        public custom_location_rule custom_location_rule { get; set; }
    }

    public class custom_location_rule
    {
        /// <summary>
        ///     LBS 兴趣点类型
        /// </summary>
        public api_lbs_p_o_i_type poi_type { get; set; }

        public date_range date_range { get; set; }

        public frequency_spec frequency_spec { get; set; }

        /// <summary>
        ///     地理位置列表
        /// </summary>
        public area_list[] area_list { get; set; }
    }

    public class area_list
    {
        /// <summary>
        ///     LBS 自定义区域类型
        /// </summary>
        public api_lbs_area_type area_type { get; set; }

        /// <summary>
        ///     圆形区域定义，当 area_type 为 CIRCLE 是必填
        /// </summary>
        public circle_area circle_area { get; set; }
    }


    public class circle_area
    {
        /// <summary>
        ///     经度，单位度
        /// </summary>
        public float longitude { get; set; }

        /// <summary>
        ///     纬度，单位度
        /// </summary>
        public float latitude { get; set; }

        /// <summary>
        ///     自定义 lbs 打点半径，单位：米
        /// </summary>
        public int tradius { get; set; }
    }

    public class frequency_spec
    {
        /// <summary>
        ///     LBS 频次比较操作符类型，目前仅支持 COMPARATOR_BETWEEN
        /// </summary>
        public api_frequency_comparator_type comparator { get; set; }

        /// <summary>
        ///     最小频次值，当 comparator 为 COMPARATOR_BETWEEN 时必填
        /// </summary>
        public long? frequency_min_value { get; set; }

        /// <summary>
        ///     最大频次值，当 comparator 为 COMPARATOR_BETWEEN 时必填
        /// </summary>

        public long? frequency_max_value { get; set; }
    }

    public class poi_rule
    {
        /// <summary>
        ///     地区编码
        /// </summary>
        public long[] region_id { get; set; }

        /// <summary>
        ///     POI 分类编码
        /// </summary>
        public long[] poi_category_id { get; set; }

        /// <summary>
        ///     时间范围，日期格式，{"start_date":"2017-03-01","end_date":"2017-04-02"}
        /// </summary>
        public date_range date_range { get; set; }


        /// <summary>
        ///     week 类型，week 类型只允许 MONDAY、TUESDAY、WEDNESDAY、THURSDAY、FRIDAY、SATURDAY、SUNDAY
        /// </summary>
        public api_week[] day_of_week { get; set; }

        /// <summary>
        ///     行为次数，行为次数至少为 1
        /// </summary>
        public int frequency { get; set; }
    }

    public class cross_city_rule
    {
        /// <summary>
        ///     路线，出发地和目的地的组合，均使用地址的编码值，比如北京的编码为 1，上海的编码为 2 则北京到上海表示为"1~2"； 0 表示不限，出发的和目的地最多只能一个为 0，不能都为 0，不能填写"0~0"，路线不能为空
        /// </summary>
        public string[] route { get; set; }

        /// <summary>
        ///     时间范围，日期格式，{"start_date":"2017-03-01","end_date":"2017-04-02"}
        /// </summary>
        public date_range date_range { get; set; }

        /// <summary>
        ///     行为次数，行为次数至少为 1
        /// </summary>
        public int frequency { get; set; }
    }

    public class date_range
    {
        /// <summary>
        ///     开始时间，大于等于 0，不能早于 1 年前，且小于 end_date
        /// </summary>
        public string start_date { get; set; }

        /// <summary>
        ///     结束时间，小于等于今天，且大于 start_date
        /// </summary>
        public string end_date { get; set; }
    }

    public class keyword_spec
    {
        /// <summary>
        ///     包含关键词，最多 100 个，单个关键词字数不超过 10
        /// </summary>
        public string[] include_keyword { get; set; }

        /// <summary>
        ///     排除关键词，最多 20 个，单个关键词字数不超过 10
        /// </summary>
        public string[] exclude_keyword { get; set; }
    }


    public class ad_rule_spec
    {
        /// <summary>
        ///     广告行为类型，其中 EXPOSURE 类型需要线下联系运营开通白名单方可使用
        /// </summary>
        public string rule_type { get; set; }

        /// <summary>
        ///     广告转化类型，当 rule_type=CONVERSION 时该字段必填，否则该字段不能填写
        /// </summary>
        public string[] conversion_type { get; set; }

        /// <summary>
        ///     数据起始日期，格式为 yyyy-MM-dd，必须在 90 天以内，且在今天（不包含）以前
        /// </summary>
        public string start_date { get; set; }

        /// <summary>
        ///     数据结束日期,格式为 yyyy-MM-dd，必须在 start_date（包含）之后，且在今天（不包含）以前。如果未填写，则人群数据会随源投放数据更新。
        /// </summary>
        public string end_date { get; set; }

        /// <summary>
        ///     需要提取人群的 campaign id 列表,通过 [campaigns/get] 接口可获得账号下的推广计划列表，campaign_id_list 和 product_list 字段至多只能填写一个，二者都不填则表示提取该广告主
        ///     id 下的所有 campaign 的广告行为数据
        /// </summary>
        public long[] campaign_id_list { get; set; }

        /// <summary>
        ///     需要提取人群的推广目标列表，通过 [products/get] 模块可获得账号下的推广目标列表，campaign_id_list 和 product_list 字段至多只能填写一个，二者都不填则表示提取该广告主 id 下的所有
        ///     campaign 的广告行为数据
        /// </summary>
        public string[] promoted_object_list { get; set; }

        /// <summary>
        ///     需要提取人群的 adgroup id 列表,通过 [adgroups/get] 接口可获得账号下的广告组列表，campaign_id_list,product_list 和 adgroup_id_list
        ///     字段至多只能填写一个，三者都不填则表示提取该广告主 id 下的所有广告行为数据
        /// </summary>
        public long[] adgroup_id_list { get; set; }
    }


    public class promoted_object_list
    {
        /// <summary>
        ///     推广目标类型
        /// </summary>
        public audience_product_type promoted_object_type { get; set; }

        /// <summary>
        ///     推广目标 id
        /// </summary>
        public string product_refs_id { get; set; }
    }

    public class combine_spec
    {
        /// <summary>
        ///     包含的人群，注意这是个二维数组，第一层数组元素之间为 AND 关系，第二层数组元素之间为 OR 关系
        /// </summary>
        public combine_model[] include { get; set; }

        /// <summary>
        ///     排除的人群，注意这是个二维数组，第一层数组元素之间为 AND 关系，第二层数组元素之间为 OR 关系
        /// </summary>
        public combine_model[] exclude { get; set; }
    }

    public class combine_model
    {
        /// <summary>
        ///     人群 id 或标签 id，通过 [custom_audiences] 模块创建客户人群或[custom_tags] 模块创建客户标签获得，即此处支持填写"audience_id":"
        ///     <AUDIENCE_ID>"，也支持填写"audience_id":"<TAG_ID>"，不支持 LOOKALIKE 和 COMBINE 人群的 id
        /// </summary>
        public long audience_id { get; set; }

        /// <summary>
        ///     时间窗，仅对客户标签有效，目前仅支持以下几个时间窗选项：1、3、7、10、15、30、90、180、365
        /// </summary>
        public long time_window { get; set; }
    }

    public class url_match_rule
    {
        /// <summary>
        ///     匹配规则组，如果为空表示全站浏览人群，多个组之间是 AND 关系
        /// </summary>
        public url_matcher_group[] url_matcher_group { get; set; }
    }

    public class url_matcher_group
    {
        /// <summary>
        ///     匹配规则，多个匹配规则之间是 OR 关系
        /// </summary>
        public url_matcher[] url_matcher { get; set; }
    }

    public class url_matcher
    {
        /// <summary>
        ///     参数值
        /// </summary>
        public string param_value { get; set; }

        /// <summary>
        ///     运算符，operator 只允许 EQ、NE、CONTAIN、NOT_CONTAIN
        /// </summary>
        public api_operator @operator { get; set; }
    }

    public class action_match_rule
    {
        /// <summary>
        ///     标准行为类型，当值为 'CUSTOM' 时表示自定义行为类型
        /// </summary>
        public api_action_type action_type { get; set; }

        /// <summary>
        ///     自定义行为类型，当 action_type=CUSTOM 时必填
        /// </summary>
        public string custom_action { get; set; }

        /// <summary>
        ///     匹配规则组，多个组之间是 AND 关系
        /// </summary>
        public param_matcher_group[] param_matcher_group { get; set; }
    }

    public class param_matcher_group
    {
        /// <summary>
        ///     匹配规则，多个匹配规则之间是 OR 关系
        /// </summary>
        public param_matcher[] param_matcher { get; set; }
    }

    public class param_matcher
    {
        /// <summary>
        ///     参数名称
        /// </summary>
        public string param_name { get; set; }

        /// <summary>
        ///     参数值
        /// </summary>
        public string param_value { get; set; }

        /// <summary>
        ///     运算符
        /// </summary>

        public api_operator @operator { get; set; }
    }

    public class action_aggregation_rule
    {
        public api_action_type action_type { get; set; }

        public string custom_action { get; set; }

        /// <summary>
        ///     聚合规则数组，多个组之间是 AND 关系
        /// </summary>
        public aggregation_group[] aggregation_group { get; set; }

        /// <summary>
        ///     匹配规则组，多个组之间是 AND 关系
        /// </summary>
        public filter_group[] filter_group { get; set; }
    }

    public class aggregation_group
    {
        /// <summary>
        ///     匹配规则组，多个组之间是 OR 关系
        /// </summary>
        public aggregation_matcher[] aggregation_matcher { get; set; }
    }

    public class aggregation_matcher
    {
        /// <summary>
        ///     聚合类型
        /// </summary>
        public api_aggregation_type aggregation_type { get; set; }

        /// <summary>
        ///     频次类型，aggregation_type = COUNT 时必填
        /// </summary>
        public api_count_type count_type { get; set; }

        /// <summary>
        ///     参数名称，当 aggregation_type != COUNT 时必填
        /// </summary>
        public string param_name { get; set; }

        /// <summary>
        ///     比较符
        /// </summary>
        public api_comparator comparator { get; set; }

        /// <summary>
        ///     参数值，当 comparator != COMPARATOR_BETWEEN 时必填
        /// </summary>
        public long? comparison_value { get; set; }

        /// <summary>
        ///     参数值，当 comparator = COMPARATOR_BETWEEN 时必填
        /// </summary>
        public long? comparison_min_value { get; set; }

        /// <summary>
        ///     参数值，当 comparator = COMPARATOR_BETWEEN 时必填
        /// </summary>
        public long? comparison_max_value { get; set; }
    }


    public class filter_group
    {
        /// <summary>
        ///     匹配规则，多个匹配规则之间是 OR 关系
        /// </summary>
        public param_matcher[] param_matcher { get; set; }
    }
}