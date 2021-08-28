namespace TencentAd
{
    public class TencentAdConfig
    {
        public TencentAdConfig(string clientId, string clientSecret)
        {
            client_id = clientId;
            client_secret = clientSecret;
        }

        public string client_id { get; }

        public string client_secret { get; }
    }
}