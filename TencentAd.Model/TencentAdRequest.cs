using System;

namespace TencentAd.Model
{
    public abstract class TencentAdRequest
    {
    }


    public class BasicTencentAdRequest : TencentAdRequest
    {
        public BasicTencentAdRequest(string accessToken, string[] fields)
        {
            access_token = accessToken;
            this.fields = fields;
        }

        public BasicTencentAdRequest(string accessToken)
        {
            access_token = accessToken;
        }

        public string access_token { get; }

        public long timestamp { get; set; } = new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();

        public string nonce { get; } = Guid.NewGuid().ToString().Substring(0, 30);

        public string[] fields { get; }
    }
}