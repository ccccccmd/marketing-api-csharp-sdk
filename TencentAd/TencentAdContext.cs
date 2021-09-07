using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TencentAd
{
    public static class TencentAdContext
    {
        private const string SandBoxApi = "https://sandbox-api.e.qq.com/v1.3";
        private const string ProdApi = "https://api.e.qq.com/v1.3";


        public static string BasePath { get; private set; }


        public static TencentAdConfig ClientConfig { get; private set; }

        /// <summary>
        ///     Init
        /// </summary>
        public static void Init(TencentAdConfig config, bool useSandBox, bool debug, TimeSpan? timeout)
        {
            ClientConfig = config;
            BasePath = useSandBox ? SandBoxApi : ProdApi;

            FlurlHttp.Configure(settings =>
            {
                if (timeout.HasValue)
                {
                    settings.Timeout = timeout;
                }

                settings.JsonSerializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings
                {
                    Converters = new List<JsonConverter> {new StringEnumConverter()}
                });

                if (!debug) return;
                settings.BeforeCallAsync = call =>
                {
                    Console.WriteLine("====BeforeCall====");
                    Console.WriteLine($"StartedUtc:{DateTime.UtcNow}");
                    Console.WriteLine($"URL:{call.Request.Url}");
                    Console.WriteLine($"Headers:{call.Request.Headers}");
                    Console.WriteLine($"RequestBody:{call.RequestBody}");
                    return Task.CompletedTask;
                };

                settings.AfterCallAsync = async call =>
                {
                    Console.WriteLine("====AfterCall====");
                    Console.WriteLine($"EndedUtc:{call.EndedUtc}");
                    Console.WriteLine($"ResponseMessage:{call.Response.ResponseMessage}");

                    Console.WriteLine(
                        $"ResponseContent:{await call.Response.ResponseMessage.Content.ReadAsStringAsync()}");
                };
            });
        }
    }
}