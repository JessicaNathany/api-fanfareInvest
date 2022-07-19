using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service.IService
{
    public interface IDirectTreasuryService
    {
        Task<IEnumerable<DirectTreasury>> GetAsync();
        Task<OrderModel> PostAsync(int idTitle, DateTime currentDate);
    }
}
