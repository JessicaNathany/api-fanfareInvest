using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Entity;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Response;
using api_fanfareInvest.api.Service.IService;

namespace api_fanfareInvest.api.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task CreateOrder(OrderModel orderModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            var orders = new List<Order>();
            var order = new Order();

            var listResponse = await _orderRepository.GetAllAsync();

            if (listResponse == null)
                return orders;

            foreach (var itemResponseOrder in listResponse.SelectMany(o => o.Orders))
            {
                order.IdOrder = itemResponseOrder.IdOrder;
                order.InvestmentName = itemResponseOrder.InvestmentName;
                order.OrderDateCreate = itemResponseOrder.OrderDateCreate;
                order.OrderStatus = itemResponseOrder.OrderStatus;
                order.OrderTitle = itemResponseOrder.OrderTitle;
                order.Quantity = itemResponseOrder.Quantity;
                order.TotalPrice = itemResponseOrder.TotalPrice;
                order.UnitPrice = order.UnitPrice;

                orders.Add(order);
            }

            return orders;
        }

        public Task<Order> GetByIdAsync(int idOrder)
        {
            throw new NotImplementedException();
        }
    }
}
