using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Response
{
    public class FixedIncomeResponse
    {
        public IEnumerable<FixedIncome> lcis { get; set; }
        public IEnumerable<FixedIncome> cbs { get; set; }
    }
}
