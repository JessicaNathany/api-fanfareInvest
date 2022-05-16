using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.service.IService
{
    public interface IFundService
    {
        Task<IList<Fund>> Get();
    }
}
