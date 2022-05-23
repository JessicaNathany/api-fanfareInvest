using api_fanfareInvest.api.Model;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Response
{
    public class FixedIncomeResponse
    {
        [JsonProperty("cdbs")]
        public IEnumerable<FixedIncome> FixedIncomesCDB { get; set; }

        [JsonProperty("lcis")]
        public IEnumerable<FixedIncome> FixedIncomesLCI { get; set; }
    }
}
