using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service.IService
{
    public interface IInvestmentServices
    {
        Task<IList<InvestmentPortfolio>> GetAll();
    }
}
