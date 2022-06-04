using api_fanfareInvest.api.Model;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Response
{
    public class DirectTreasuryResponse
    {
        [JsonProperty("directTreasury")]
        public IList<DirectTreasury> DirectTreasurys { get; set; }
    }
}
