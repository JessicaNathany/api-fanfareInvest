using api_fanfareInvest.api.Entity;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service.IService;

namespace api_fanfareInvest.api.Service
{
    public class OrderService : IOrderService
    {
        public Task CreateOrder(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Order>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByIdAsync(int idOrder)
        {
            throw new NotImplementedException();
        }
    }
}
