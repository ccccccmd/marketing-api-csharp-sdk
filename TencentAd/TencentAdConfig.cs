namespace TencentAd
{
    public class TencentAdConfig
    {
        public TencentAdConfig(long clientId, string clientSecret)
        {
            client_id = clientId;
            client_secret = clientSecret;
        }

        public long client_id { get; }

        public string client_secret { get; }
    }
}