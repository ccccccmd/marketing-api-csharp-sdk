using TencentAd.Model.Enums;

namespace TencentAd.Model.Oauth
{
    /// <summary>
    ///     获取 Authorization Code
    /// </summary>
    public class GetAuthorizationCodeReq
    {
        /// <summary>
        ///     应用 id
        /// </summary>
        public long client_id { get; set; }

        /// <summary>
        ///     应用回调地址，仅支持 http 和 https，不支持指定端口号，且主域名必须与创建应用时登记的回调域名一致，若地址携带参数，需要对地址进行 urlencod
        /// </summary>
        public string redirect_uri { get; set; }

        /// <summary>
        ///     验证请求有效性参数，值为用户自取，用于阻止跨站请求伪造攻击
        /// </summary>

        public string state { get; set; }

        /// <summary>
        ///     授权范围，可选值：ads_management（广告投放）、ads_insights（数据洞察）、account_management（帐号服务）、audience_management（人群管理）、user_actions（用户行为数据接入），不传即为授权全部权限
        /// </summary>

        public string scope { get; set; }

        public AccountTypeEnum account_type { get; set; } = AccountTypeEnum.ACCOUNT_TYPE_QQ;

        /// <summary>
        ///     权页面展示账号类型(QQ 账号/微信账号)数量，当取值为 1 时授权页面仅展示 account_type 指定的账号类型，当取值为 2 时授权页面展示所有账号类型授权页面，默认优先显示 account_type
        ///     指定的账号类型，只能取值 1 或 2
        /// </summary>
        public int account_display_number { get; set; } = 1;
    }
}