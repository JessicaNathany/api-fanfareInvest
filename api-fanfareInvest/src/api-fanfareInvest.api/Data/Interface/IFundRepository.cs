using api_fanfareInvest.api.Model;
using api_fanfareInvest.repository.Response;

namespace api_fanfareInvest.api.Data.Interface
{
    public interface IFundRepository
    {
        Task<IList<FundReponse>> GetAsync();
    }
}
