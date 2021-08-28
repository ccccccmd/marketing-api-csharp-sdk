using System.Collections.Generic;

namespace TencentAd.Model.Oauth
{
    public class AuthorizerInfo
    {
        /// <summary>
        ///     授权的推广帐号对应的 QQ 号
        /// </summary>
        public long account_uin { get; set; }

        /// <summary>
        ///     授权的推广帐号 id，大部分接口均需同步该字段，请妥善保存
        /// </summary>
        public long account_id { get; set; }

        /// <summary>
        ///     权限列表，若为空，则表示拥有所属应用的所有权限
        /// </summary>
        public List<string> scope_list { get; set; }

        /// <summary>
        ///     授权的推广帐号对应的微信帐号 id
        /// </summary>
        public string wechat_account_id { get; set; }

        /// <summary>
        ///     授权账号身份类型，授权账号类型广告主,代理商,T1 账户,商务管家账户
        /// </summary>
        public string account_role_type { get; set; }

        /// <summary>
        ///     账号类型
        /// </summary>
        public string account_type { get; set; }

        /// <summary>
        ///     角色
        /// </summary>
        public string role_type { get; set; }
    }
}