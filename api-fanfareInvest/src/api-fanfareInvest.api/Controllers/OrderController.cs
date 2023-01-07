using api_fanfareInvest.api.Entity;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest/order/")]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetOrdersAsync([FromServices] IOrderService service)
        {
            Task<IEnumerable<Order>> response = service.GetAllAsync();
            return Ok(response);
        }

        [HttpGet]
        [Route("idOrder/{idOrder}")]
        public async Task<ActionResult> GetOrderByIdAsynt(int idOrder, [FromServices] IOrderService service)
        {
            Task<Order> response = service.GetByIdAsync(idOrder);
            return Ok(response);
        }

        [HttpPost]
        [Route("idOrder/{idOrder}")]
        public async Task<ActionResult> CreateOrderAsynt([FromBody] OrderModel orderModel, [FromServices] IOrderService service)
        {
            var response = service.CreateOrder(orderModel);
            return Ok(response);
        }
    }
}
