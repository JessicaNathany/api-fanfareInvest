using api_fanfareInvest.api.Response;

namespace api_fanfareInvest.api.Data.Interface
{
    public interface ITirectTreasuryRepository
    {
        Task<IList<TirectTreasuryResponse>> Get();
    }
}
