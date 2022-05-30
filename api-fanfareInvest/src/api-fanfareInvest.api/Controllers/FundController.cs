﻿using api_fanfareInvest.api.IService;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service;
using api_fanfareInvest.api.Service.IService;
using Microsoft.AspNetCore.Mvc;

namespace api_fanfareInvest.api.Controllers
{
    [ApiController]
    [Route("api-invest")]
    public class FundController : ControllerBase
    {
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
            Task<IList<TirectTreasury>> response = service.Get();
            return Ok(response);
        }
    }
}