using api_fanfareInvest.api.Connections;
using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Response;
using Newtonsoft.Json;


namespace api_fanfareInvest.api.Data.Repository
{
    public class FixedIncomeRepository : IFixedIncomeRepository
    {
        public async Task<IEnumerable<FixedIncomeResponse>> Get()
        {
            var listFixedIncomes = new List<FixedIncomeResponse>();

            var result = ClientConnection.ClientResult("https://run.mocky.io/v3/ba42dc71-9176-46d0-8ede-a21faeb5b3ba");
            var fixedIncomeResult = JsonConvert.DeserializeObject<FixedIncomeResponse>(result);
            
            listFixedIncomes.Add(fixedIncomeResult);
            return listFixedIncomes;
        }
    }
}
