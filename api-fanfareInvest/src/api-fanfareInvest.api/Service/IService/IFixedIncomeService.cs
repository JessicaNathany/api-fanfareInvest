using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Response;

namespace api_fanfareInvest.api.Service.IService
{
    public interface IFixedIncomeService
    {
        Task<IEnumerable<FixedIncome>> Get();
    }
}
