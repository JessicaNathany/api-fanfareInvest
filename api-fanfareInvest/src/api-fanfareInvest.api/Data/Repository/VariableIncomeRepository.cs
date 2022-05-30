using api_fanfareInvest.api.Connections;
using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Response;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Data.Repository
{
    public class VariableIncomeRepository : IVariableIncomeRepository
    {
        public async Task<IEnumerable<VariableIncomeResponse>> Get()
        {
            using var client = new HttpClient();
            var listVariableIncomes = new List<VariableIncomeResponse>();

            var result = ClientConnection.ClientResult("https://run.mocky.io/v3/4fcc8f18-8ab7-4a36-abc1-f466566e9785");

            var variableIncomeResult = JsonConvert.DeserializeObject<VariableIncomeResponse>(result);
            listVariableIncomes.Add(variableIncomeResult);

            return listVariableIncomes;
        }
    }
}
