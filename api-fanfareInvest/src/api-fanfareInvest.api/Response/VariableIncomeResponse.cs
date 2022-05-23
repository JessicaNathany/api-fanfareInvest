using api_fanfareInvest.api.Model;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Response
{
    public class VariableIncomeResponse
    {
        [JsonProperty("variableRent")]
        public IList<VariableIncome> VariableIncomes { get; set; }
    }
}
