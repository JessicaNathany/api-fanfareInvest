using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Response;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Data.Repository
{
    public class DirectTreasuryRepository : IDirectTreasuryRepository
    {
        public async Task<IList<DirectTreasuryResponse>> GetAsync()
        {
            using var client = new HttpClient();
            var listDirectTreasuryResponses = new List<DirectTreasuryResponse>();

            var result = ClientConnection.ClientResult("https://run.mocky.io/v3/52ad684e-30a4-4a45-9c88-3b18169c6137");

            var directTreasury = JsonConvert.DeserializeObject<DirectTreasuryResponse>(result);
            listDirectTreasuryResponses.Add(directTreasury);

            return listDirectTreasuryResponses;
        }
    }
}
