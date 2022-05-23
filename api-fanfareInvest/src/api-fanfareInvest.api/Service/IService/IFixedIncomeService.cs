using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service.IService
{
    public interface IFixedIncomeService
    {
        Task<IEnumerable<FixedIncome>> GetAsync();
    }
}
