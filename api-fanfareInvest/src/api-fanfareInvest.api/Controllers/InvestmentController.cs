using api_fanfareInvest.api.Service.IService;
using api_fanfareInvest.api.Model;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest/investiment/")]
    public class InvestmentController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public async Task<ActionResult> GetAllInvestimentsAsync([FromServices] IInvestmentServices service)
        {
            Task<IEnumerable<InvestmentPortfolio>> response = service.GetAll();
            return Ok(response);
        }

        [HttpGet]
        [Route("fund/GetAll")]
        public async Task<ActionResult> GetFundAsync([FromServices] IFundService service)
        {
            Task<IEnumerable<Fund>>? response = service.GetAsync();
            return Ok(response);
        }

        [HttpGet]
        [Route("direct-treasury/GetAll")]
        public async Task<ActionResult> GetTirectTreasuryAsync([FromServices] IDirectTreasuryService service)
        {
            var response = service.GetAsync();
            return Ok(response);
        }

        [HttpGet]
        [Route("variable-income/GetAll")]
        public async Task<ActionResult> GetVariableIncomeAsync([FromServices] IVariableIncomeService service)
        {
            Task<IEnumerable<VariableIncome>> response = service.GetAsync();
            return Ok(response);
        }

        [HttpGet]
        [Route("fixed-income/GetAll")]
        public async Task<ActionResult> GetFixedIncomeAsync([FromServices] IFixedIncomeService service)
        {
            Task<IEnumerable<FixedIncome>> response = service.GetAsync();
            return Ok(response);
        }
    }
}
