using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service.IService
{
    public interface IFundService
    {
        Task<IList<Fund>> Get();
    }
}
