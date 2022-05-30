using api_fanfareInvest.api.Service.IService;
using api_fanfareInvest.api.Model;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest/investiment")]
    public class InvestmentController : ControllerBase
    {

        [HttpGet]
        [Route("/investiment/GetAll")]
        public async Task<ActionResult> GetAllInvestiments([FromServices] IFundService service)
        {
            Task<IList<Fund>> response = service.Get(); // refatorar para trazer todos investimentos
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
        [Route("/direct-treasury/Get")]
        public async Task<ActionResult> GetTirectTreasury([FromServices] IDirectTreasuryService service)
        {
            Task<IList<DirectTreasury>> response = service.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("/variable-income/Get")]
        public async Task<ActionResult> GetVariableIncome([FromServices] IVariableIncomeService service)
        {
            Task<IEnumerable<VariableIncome>> response = service.Get();
            return Ok(response);
        }

        [HttpGet]
        [Route("/fixed-income/Get")]
        public async Task<ActionResult> GetFixedIncome([FromServices] IFixedIncomeService service)
        {
            Task<IEnumerable<FixedIncome>> response = service.GetAsync();
            return Ok(response);
        }
    }
}
