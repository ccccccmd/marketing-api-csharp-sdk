using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using TencentAd.Api;
using TencentAd.Exceptions;
using TencentAd.Model.Oauth;

namespace TencentAd
{
    public interface ITokenContext
    {
        Task<string> AccessToken(long accountId);

        /// <summary>
        ///     授权成功后调用
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        Task<TokenInfoRes> AuthSuccess(GetTokenByCodeReq req);
    }

    public class DefaultTokenContext : ITokenContext
    {
        private readonly IMemoryCache _cache;

        public DefaultTokenContext(IMemoryCache cache)
        {
            _cache = cache;
        }

        public async Task<string> AccessToken(long accountId)
        {
            var accessToken = _cache.Get<string>($"accessToken-{accountId}");
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                return accessToken;
            }

            var refreshToken = _cache.Get<string>($"refreshToken-{accountId}");
            if (string.IsNullOrWhiteSpace(refreshToken))
            {
                throw new TencentAdsException("RefreshToken Is Null");
            }

            var res = await new OAuthApi(TencentAdContext.ClientConfig).GetAccessToken(
                new GetTokenByRefreshTokenReq(refreshToken));

            _cache.Set($"accessToken-{accountId}", res.access_token,
                TimeSpan.FromSeconds(res.access_token_expires_in - 120));

            return res.access_token;
        }

        public async Task<TokenInfoRes> AuthSuccess(GetTokenByCodeReq req)
        {
            var res = await new OAuthApi(TencentAdContext.ClientConfig).GetAccessToken(req);

            var accountId = res.authorizer_info.account_id;

            _cache.Set($"refreshToken-{accountId}", res.refresh_token,
                TimeSpan.FromSeconds(res.refresh_token_expires_in - 120));

            _cache.Set($"accessToken-{accountId}", res.access_token,
                TimeSpan.FromSeconds(res.access_token_expires_in - 120));
            return res;
        }
    }
}