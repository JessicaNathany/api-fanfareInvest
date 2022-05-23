using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Response;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace api_fanfareInvest.api.Data.Repository
{
    public class VariableIncomeRepository : IVariableIncomeRepository
    {
        public async Task<IEnumerable<VariableIncomeResponse>> GetAsync()
        {
            using var client = new HttpClient();
            var listVariableIncomes = new List<VariableIncomeResponse>();

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var response = client.GetAsync("https://run.mocky.io/v3/4fcc8f18-8ab7-4a36-abc1-f466566e9785").Result;
            response.EnsureSuccessStatusCode();

            var result = response.Content.ReadAsStringAsync().Result;

            var variableIncomeResult = JsonConvert.DeserializeObject<VariableIncomeResponse>(result);
            listVariableIncomes.Add(variableIncomeResult);

            return listVariableIncomes;
        }
    }
}
