using System.Diagnostics.CodeAnalysis;

namespace TencentAd.Model.Oauth
{
    public class GetTokenByCodeReq : TencentAdRequest
    {
        public string grant_type { get; } = "authorization_code";

        /// <summary>
        ///     OAuth 认证 code，可通过获取 Authorization Code 接口获取
        /// </summary>
        [NotNull]
        public string authorization_code { get; set; }

        /// <summary>
        ///     应用回调地址，当 grant_type=authorization_code 时，redirect_uri 为必传参数，仅支持 http 和 https，不支持指定端口号，且传入的地址需要与获取
        ///     authorization_code 时，传入的回调地址保持一致字段长度最小 1 字节，长度最大 1024 字节
        /// </summary>
        [NotNull]
        public string redirect_uri { get; set; }
    }
}