using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TencentAd.Api;
using TencentAd.Model;
using TencentAd.Model.AdsInsight;
using TencentAd.Model.Common;
using TencentAd.Model.Enums;
using Xunit;

namespace TencentAd.Tests
{
    public class AdsInsightApiTest : BaseTest
    {
        private readonly AdsInsightApi _api;

        public AdsInsightApiTest()
        {
            _api = new TencentAdApi().Insight;
        }

        [Fact]
        public async Task GetLeadCluesTest()
        {
            var res = await _api.GetLeadClues(
                new LeadCluesGetReq(AccountId,
                    new TimeRange(DateTime.Now.AddMinutes(-3).ToUnixTimeSeconds(), DateTime.Now.ToUnixTimeSeconds()))
                , AccessToken, null);

            Assert.NotNull(res.page_info);
        }

        [Fact]
        public async Task OuterCluesAddTest()
        {
            var id = Guid.NewGuid().ToString();
            var res = await _api.OuterCluesAdd(
                new OuterCluesAddReq(AccountId, new[]
                {
                    new OuterLeadsInfoAddInput(id, lead_clues_leads_type.LEADS_TYPE_FORM)
                    {
                        leads_name = $"leadsname_{id}", leads_gender = lead_clues_gender_type.GENDER_TYPE_MALE,
                        leads_user_type = leads_user_type.USER_TYPE_TEL,
                        leads_tel = "188xxxx3xxx", bundle = JsonConvert.SerializeObject(
                            new Dictionary<string, string>
                            {
                                {"shop_name", "上海大丸百货"},
                                {"gender", "男"}
                            })
                    }
                })
                , AccessToken);

            Assert.True(res.success_lead_id_list.Length > 0);
            Assert.True(res.success_lead_id_list[0].outer_leads_id == id);
        }
    }
}