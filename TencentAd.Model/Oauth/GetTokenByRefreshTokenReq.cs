using System.Diagnostics.CodeAnalysis;

namespace TencentAd.Model.Oauth
{
    public class GetTokenByRefreshTokenReq : TencentAdRequest
    {
        public GetTokenByRefreshTokenReq(string refreshToken)
        {
            refresh_token = refreshToken;
        }

        public string grant_type { get; } = "refresh_token";

        /// <summary>
        ///     应用 refresh token，当 grant_type=refresh_token 时必填 字段长度最小 1 字节，长度最大 256 字节
        /// </summary>
        [NotNull]
        public string refresh_token { get; set; }
    }
}