using api_fanfareInvest.api.Service;
using Microsoft.AspNetCore.Mvc;


namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FundController : ControllerBase
    {
        [HttpGet]
        [Route("invest/getfund")]
        public async Task<ActionResult> GetFund([FromServices] FundService service)
        {
            var response = service.Get();
            return Ok(response);
        }
    }
}
