using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.repository.Response;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Data.Repository
{
    public class FundRepository : IFundRepository
    {
        public async Task<IList<FundReponse>> GetAsync()
        {
            using var client = new HttpClient();
            var listFunds = new List<FundReponse>();

            var result = ClientConnection.ClientResult("https://run.mocky.io/v3/7ac36199-db5c-4d21-bc8a-74fe91fa43b1");

            var fund = JsonConvert.DeserializeObject<FundReponse>(result);
            listFunds.Add(fund);

            return listFunds;
        }
    }
}
