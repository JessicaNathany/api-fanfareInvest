using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.repository.Response;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace api_fanfareInvest.api.Data.Repository
{
    public class FundRepository : IFundRepository
    {
        public async Task<IList<FundReponse>> GetAsync()
        {
            using var client = new HttpClient();
            var listFunds = new List<FundReponse>();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("https://run.mocky.io/v3/7ac36199-db5c-4d21-bc8a-74fe91fa43b1").Result;
            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            var fund = JsonConvert.DeserializeObject<FundReponse>(result);
            listFunds.Add(fund);

            return listFunds;
        }
    }
}
