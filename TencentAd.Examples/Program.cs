using System;
using System.Threading.Tasks;
using TencentAd.Api;
using TencentAd.Model.AdsInsight;
using TencentAd.Model.Common;

namespace TencentAd.Examples
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            long clientId = 1;
            var clientSecret = "xxx";

            TencentAdContext.Init(new TencentAdConfig(clientId, clientSecret), true, true, null);


            const long accountId = 1318;
            const string token = "b5a2652c5d55816f576e6cb76965f6cf";
            var res = await new AdsInsightApi().GetLeadClues(
                new LeadCluesGetReq(accountId,
                    new TimeRange(DateTime.Now.AddDays(-10).ToUnixTimeSeconds(), DateTime.Now.ToUnixTimeSeconds()))
                , token, null);

            Console.WriteLine("ok");
        }
    }
}