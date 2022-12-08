using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Response;
using Newtonsoft.Json;

namespace api_fanfareInvest.api.Data.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public async Task<IList<OrderResponse>> GetAllAsync()
        {
            using var client = new HttpClient();
            var ordersResponse = new List<OrderResponse>();

            var result = ClientConnection.ClientResult("https://run.mocky.io/v3/2a3fed0d-f956-4386-aaab-e2bb0a54f2b5");
            var orders = JsonConvert.DeserializeObject<OrderResponse>(result);
            ordersResponse.Add(orders);

            return ordersResponse;
        }
    }
}
