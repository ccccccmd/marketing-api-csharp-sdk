using System.Collections.Generic;
using TencentAd.Model.Enums;

namespace TencentAd.Model.UserData
{
    /// <summary>
    ///     上传用户行为数据
    /// </summary>
    public class UserActionsAddReq : TencentAdRequest
    {
        public UserActionsAddReq(long accountId, long userActionSetId, List<UserActionsAdd_Action> actions)
        {
            account_id = accountId;
            user_action_set_id = userActionSetId;
            this.actions = actions;
        }

        /// <summary>
        ///     推广帐号 id，有操作权限的帐号 id，包括代理商和广告主帐号 id
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     用户行为源 id
        /// </summary>
        public long user_action_set_id { get; set; }

        public List<UserActionsAdd_Action> actions { get; set; }
    }


    public class UserActionsAdd_UserId
    {
        public string hash_imei { get; set; }
        public string md5_sha256_imei { get; set; }
        public string hash_idfa { get; set; }
        public string md5_sha256_idfa { get; set; }
        public string gdt_openid { get; set; }
        public string hash_phone { get; set; }
        public string sha256_phone { get; set; }
        public string hash_android_id { get; set; }
        public string hash_mac { get; set; }
        public string oaid { get; set; }
        public string md5_sha256_oaid { get; set; }
        public string wechat_openid { get; set; }
        public string wechat_unionid { get; set; }
        public string wechat_app_id { get; set; }
    }


    public class UserActionsAdd_ProductInform
    {
        /// <summary>
        ///     商品库行业
        /// </summary>
        public action_product_inform_type? content_type { get; set; }

        public string product_catalog_id { get; set; }
        public string[] product_id { get; set; }
        public List<string> category_path { get; set; }
    }

    public class UserActionsAdd_Action
    {
        /// <summary>
        ///     用户自定义的行为 id 标识
        /// </summary>
        public string external_action_id { get; set; }

        /// <summary>
        ///     行为发生时，客户端的时间点。UNIX 时间，单位为秒
        /// </summary>
        public long action_time { get; set; }

        /// <summary>
        ///     用户标识，app 数据上报时必填，web 数据上报时可以不填 user_id，但建议填写，方便后续优化
        /// </summary>
        public UserActionsAdd_UserId user_id { get; set; }

        /// <summary>
        ///     标准行为类型，当值为 'CUSTOM' 时表示自定义行为类型
        /// </summary>
        public api_action_type? action_type { get; set; }

        /// <summary>
        ///     自定义行为类型，当 action_type=CUSTOM 时必填
        /// </summary>
        public string custom_action { get; set; }

        /// <summary>
        ///     行为所带的参数,
        ///     action_param是一个Map，key 类型为 string，value 的类型支持以下几种：
        ///     int 或 int[] : 64位整数；
        ///     float 或 float[]: 最大值100000000000 (一千亿)，保留3位小数精度，超过的截断，而非四舍五入；
        ///     boolean 或 boolean[]: 支持字面值为：true,false；
        ///     string 或 string[]: 字符串；
        /// </summary>
        public object action_param { get; set; }

        /// <summary>
        ///     商品信息
        /// </summary>
        public UserActionsAdd_ProductInform product_inform { get; set; }

        /// <summary>
        ///     渠道信息，标识该条行为发生在何渠道上
        /// </summary>
        public action_channel_type? channel { get; set; }

        /// <summary>
        ///     url，网页回传时必须要填写 url，请填写效果数据发生 h5 页面 URL 地址
        /// </summary>
        public string url { get; set; }

        /// <summary>
        ///     跟踪信息
        /// </summary>
        public UserActionsAdd_Trace trace { get; set; }
    }

    public class UserActionsAdd_Trace
    {
        public string click_id { get; set; }
    }
}