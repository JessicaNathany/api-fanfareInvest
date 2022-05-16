using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.IService
{
    public interface IFundService
    {
        Task<IList<Fund>> Get();
    }
}
