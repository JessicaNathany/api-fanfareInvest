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

        public async Task<IEnumerable<Order>> GetAllAsync()
        {
            var orders = new List<Order>();

            var listResponse = await _orderRepository.GetAllAsync();

            if (listResponse == null) return orders;

            foreach (var itemOrder in listResponse.SelectMany(o=> o.Orders))
            {
                orders.Add(new Order
                {
                    IdOrder = itemOrder.IdOrder,
                    InvestmentName = itemOrder.InvestmentName,
                    OrderDateCreate = itemOrder.OrderDateCreate,
                    OrderStatus = itemOrder.OrderStatus,
                    OrderTitle = itemOrder.OrderTitle,
                    Quantity = itemOrder.Quantity,
                    TotalPrice = itemOrder.TotalPrice,
                    UnitPrice = itemOrder.UnitPrice,
                });
            }

            return orders;
        }

        public Task<Order> GetByIdAsync(int idOrder)
        {
            throw new NotImplementedException();
        }
    }
}
