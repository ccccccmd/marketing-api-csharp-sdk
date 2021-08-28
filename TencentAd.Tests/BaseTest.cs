namespace TencentAd.Tests
{
    public class BaseTest
    {
        protected const long AccountId = 1318;
        protected const string AccessToken = "b5a2652c5d55816f576e6cb76965f6cf";

        protected BaseTest()
        {
            TencentAdContext.Init(new TencentAdConfig(1, "xxxx"), true, true, null);
        }
    }
}