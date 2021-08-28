using System;

namespace TencentAd.Exceptions
{
    public class TencentAdsException : Exception
    {
        public TencentAdsException(long code, string message)
        {
            this.code = code;
            this.message = message;
        }

        public TencentAdsException(string message)
        {
            this.message = message;
        }

        public long code { get; set; }
        public string message { get; set; }
    }
}