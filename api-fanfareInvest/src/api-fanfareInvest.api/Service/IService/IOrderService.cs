using api_fanfareInvest.api.Entity;
using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service.IService
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllAsync();

        Task<Order>GetByIdAsync(int idOrder);

        Task CreateOrder(OrderModel orderModel);
    }
}
