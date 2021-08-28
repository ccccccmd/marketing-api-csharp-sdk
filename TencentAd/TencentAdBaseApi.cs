using System.Threading.Tasks;
using Flurl.Http;
using TencentAd.Exceptions;
using TencentAd.Model;

namespace TencentAd
{
    /// <summary>
    ///     process get or post request
    /// </summary>
    public static class TencentAdBaseApi
    {
        public static async Task<TRes> PostAsync<TRes>(string subPath, object req, string accessToken,
            string[] fields = null)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new TencentAdsException("AccessToken Can Not Be Null");
            }

            var result = await $"{TencentAdContext.BasePath}{subPath}"
                .WithHeader("charset", "utf-8")
                .SetQueryParams(new BasicTencentAdRequest(accessToken, fields))
                .PostJsonAsync(req)
                .ReceiveJson<TencentAdResponse<TRes>>();


            if (result.success)
            {
                return result.data;
            }

            throw new TencentAdsResponseException(result.code, result.message, result.message_cn, result.errors);
        }

        public static async Task<TRes> GetAsync<TRes>(string subPath, object req, string accessToken,
            string[] fields = null)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
            {
                throw new TencentAdsException("AccessToken Can Not Be Null");
            }

            using var response = await $"{TencentAdContext.BasePath}{subPath}"
                .WithHeaders(new {charset = "utf-8", Content_Type = "application/json"})
                .SetQueryParams(new BasicTencentAdRequest(accessToken, fields))
                .SetQueryParams(req)
                .GetAsync();
            var result = await response.GetJsonAsync<TencentAdResponse<TRes>>();

            if (result.success)
            {
                return result.data;
            }

            throw new TencentAdsResponseException(result.code, result.message, result.message_cn, result.errors);
        }
    }
}