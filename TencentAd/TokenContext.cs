using System.Threading.Tasks;

namespace TencentAd
{
    public interface ITokenContext
    {
        Task<string> AccessToken(long account_id);
    }
}