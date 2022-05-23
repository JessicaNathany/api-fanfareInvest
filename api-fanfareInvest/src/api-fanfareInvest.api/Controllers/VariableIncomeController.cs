using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest")]
    public class VariableIncomeController : ControllerBase
    {
        [HttpGet]
        [Route("/variableincome/Get")]
        public async Task<ActionResult> GetFixedIncome([FromServices] IVariableIncomeService service)
        {
            Task<IEnumerable<VariableIncome>> response =  service.Get();
            return Ok(response);
        }
    }
}
