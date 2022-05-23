using api_fanfareInvest.api.IService;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest")]
    public class InvestmentController : ControllerBase
    {

        [HttpGet]
        [Route("/investiment/Get")]
        public async Task<ActionResult> GetAllInvestiments([FromServices] IFundService service)
        {
            Task<IList<Fund>> response = service.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("/fund/Get")]
        public async Task<ActionResult> GetFund([FromServices] IFundService service)
        {
            Task<IList<Fund>> response = service.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("/tirect-treasury/Get")]
        public async Task<ActionResult> GetTirectTreasury([FromServices] ITirectTreasuryService service)
        {
            Task<IList<DirectTreasury>> response = service.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("/variableincome/Get")]
        public async Task<ActionResult> GetVariableIncome([FromServices] IVariableIncomeService service)
        {
            Task<IEnumerable<VariableIncome>> response = service.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("/fixedincome/Get")]
        public async Task<ActionResult> GetFixedIncome([FromServices] IFixedIncomeService service)
        {
            Task<IEnumerable<FixedIncome>> response = service.GetAsync();
            return Ok(response);
        }
    }
}
