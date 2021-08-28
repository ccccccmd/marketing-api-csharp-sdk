using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Flurl.Http;

namespace TencentAd
{
    public static class TencentAdContext
    {
        private const string SandBoxApi = "https://sandbox-api.e.qq.com/v1.3";
        private const string ProdApi = "https://api.e.qq.com/v1.3";

        public static string BasePath { get; private set; } = "https://sandbox-api.e.qq.com/v1.3";


        /// <summary>
        ///     Init
        /// </summary>
        /// <param name="useSandBox"></param>
        /// <param name="debug"></param>
        /// <param name="timeout"></param>
        public static void Init(bool useSandBox, bool debug, TimeSpan? timeout)
        {
            BasePath = useSandBox ? SandBoxApi : ProdApi;

            FlurlHttp.Configure(settings =>
            {
                if (timeout.HasValue)
                {
                    settings.Timeout = timeout;
                }

                if (!debug) return;
                settings.BeforeCallAsync = call =>
                {
                    Debug.WriteLine("====BeforeCall====");
                    Debug.WriteLine($"StartedUtc:{call.StartedUtc}");
                    Debug.WriteLine($"URL:{call.Request.Url}");
                    Debug.WriteLine($"Headers:{call.Request.Headers}");
                    Debug.WriteLine($"RequestBody:{call.RequestBody}");
                    return Task.CompletedTask;
                };

                settings.AfterCallAsync = async call =>
                {
                    Debug.WriteLine("====AfterCall====");
                    Debug.WriteLine($"EndedUtc:{call.EndedUtc}");
                    Debug.WriteLine($"ResponseMessage:{call.Response.ResponseMessage}");

                    Debug.WriteLine(
                        $"ResponseContent:{await call.Response.ResponseMessage.Content.ReadAsStringAsync()}");
                };
            });
        }
    }
}