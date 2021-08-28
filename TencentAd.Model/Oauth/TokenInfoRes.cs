namespace TencentAd.Model.Oauth
{
    public class TokenInfoRes
    {
        /// <summary>
        ///     权限信息，当 grant_type=refresh_token 时不返回
        /// </summary>
        public AuthorizerInfo authorizer_info { get; set; }

        /// <summary>
        ///     应用 access token
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        ///     access_token 过期时间，单位（秒）
        /// </summary>
        public long access_token_expires_in { get; set; }

        /// <summary>
        ///     refresh_token 过期时间，单位（秒），当 grant_type=refresh_token 时不返回
        /// </summary>
        public long refresh_token_expires_in { get; set; }

        /// <summary>
        ///     应用 refresh token，当 grant_type=refresh_token 时不返回
        /// </summary>
        public string refresh_token { get; set; }
    }
}