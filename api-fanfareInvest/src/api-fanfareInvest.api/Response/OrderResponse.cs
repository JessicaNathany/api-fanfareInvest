using api_fanfareInvest.api.Entity;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Response
{
    public class OrderResponse
    {
        [JsonProperty("order")]
        public IList<Order> Orders { get; set; }
    }
}
