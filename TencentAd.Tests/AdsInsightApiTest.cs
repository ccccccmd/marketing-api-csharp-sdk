using System;
using System.Threading.Tasks;
using TencentAd.Api;
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
            _api = new AdsInsightApi();
        }

        [Fact]
        public async Task GetLeadCluesTest()
        {
            var res = await _api.GetLeadClues(
                new LeadCluesGetReq(AccountId,
                    new TimeRange(DateTime.Now.AddDays(-10).ToUnixTimeSeconds(), DateTime.Now.ToUnixTimeSeconds()))
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
                    new OuterLeadsInfoAddInput(id, LeadsTypeEnum.LEADS_TYPE_FORM)
                    {
                        leads_name = $"leadsname_{id}", leads_gender = LeadsGenderTypeEnum.GENDER_TYPE_MALE,
                        leads_user_type = LeadsUserTypeEnum.USER_TYPE_TEL,
                        leads_tel = "13188888888"
                    }
                })
                , AccessToken);

            Assert.True(res.success_lead_id_list.Length > 0);
            Assert.True(res.success_lead_id_list[0].outer_leads_id == id);
        }
    }
}