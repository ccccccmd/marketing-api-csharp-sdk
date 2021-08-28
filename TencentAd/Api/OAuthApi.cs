using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using TencentAd.Exceptions;
using TencentAd.Model;
using TencentAd.Model.Oauth;

namespace TencentAd.Api
{
    public class OAuthApi
    {
        private readonly TencentAdConfig _config;

        public OAuthApi(TencentAdConfig config)
        {
            _config = config;
        }

        public Task<TokenInfoRes> GetAccessToken(GetTokenByCodeReq req)
        {
            return Query(new
            {
                _config.client_id, _config.client_secret, req.authorization_code, req.grant_type, req.redirect_uri
            });
        }


        private async Task<TokenInfoRes> Query(object queryParams)
        {
            var api = $"{TencentAdContext.BasePath}/oauth/token";

            var result = await api.SetQueryParams(queryParams).GetJsonAsync<TencentAdResponse<TokenInfoRes>>();
            if (result.success)
            {
                return result.data;
            }

            throw new TencentAdsResponseException(result.code, result.message, result.message_cn, result.errors);
        }


        public Task<TokenInfoRes> GetAccessToken(GetTokenByRefreshTokenReq req)
        {
            return Query(new
                {_config.client_id, _config.client_secret, req.grant_type, req.refresh_token});
        }
    }
}