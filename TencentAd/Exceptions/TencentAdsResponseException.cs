using System;

namespace TencentAd.Exceptions
{
    public class TencentAdsResponseException : Exception
    {
        public TencentAdsResponseException(long code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public TencentAdsResponseException(long code)
        {
            this.code = code;
        }

        public TencentAdsResponseException(string message)
        {
            this.message = message;
        }

        public TencentAdsResponseException(long code, string message, string messageCn, object errors)
        {
            this.code = code;
            this.message = message;
            message_cn = messageCn;
            this.errors = errors;
        }

        public long code { get; set; }
        public string message { get; set; }
        public string message_cn { get; set; }

        public object errors { get; set; }
    }
}