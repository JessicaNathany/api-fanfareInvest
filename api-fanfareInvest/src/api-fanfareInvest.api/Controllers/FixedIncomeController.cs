using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest")]
    public class FixedIncomeController : ControllerBase
    {
        [HttpGet]
        [Route("/fixedincome/Get")]
        public async Task<ActionResult> GetFixedIncome([FromServices] IFixedIncomeService service)
        {
            Task<IEnumerable<FixedIncome>> response =  service.Get();
            return Ok(response);
        }
    }
}
