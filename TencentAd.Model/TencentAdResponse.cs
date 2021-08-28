namespace TencentAd.Model
{
    public class TencentAdResponse<T> : TencentAdResponse
    {
        public T data { get; set; }
    }

    public class TencentAdResponse
    {
        public long code { get; set; }
        public string message { get; set; }
        public string message_cn { get; set; }

        public object errors { get; set; }
        public bool success => code == 0;
    }
}