using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service.IService
{
    public class InvestmentServices : IInvestmentServices
    {
        private readonly IDirectTreasuryService _directTreasuryService;
        private readonly IFixedIncomeService _fixedIncomeService;
        private readonly IVariableIncomeService _variableIncomeService;
        private readonly IFundService _fundService;

        public InvestmentServices(IDirectTreasuryService directTreasuryService, 
                                  IFixedIncomeService fixedIncomeService, 
                                  IVariableIncomeService variableIncomeService,
                                  IFundService fundService  )
        {
            _directTreasuryService = directTreasuryService;
            _fixedIncomeService = fixedIncomeService;
            _variableIncomeService = variableIncomeService;
            _fundService = fundService;
        }

        public async Task<IEnumerable<InvestmentPortfolio>> GetAll()
        {
            var listInvestimentPortfolio = new List<InvestmentPortfolio>();
            var portfolio = new InvestmentPortfolio();

            var directTreasuries = GetDirectTreasury().Result.ToList();
            var fixedIncomes = GetFixedIncome().Result.ToList();
            var variableIncomes = GetVariableIncome().Result.ToList();
            var funds = GetFund().Result.ToList();

            portfolio.Guid = Guid.NewGuid();
            portfolio.DirectTreasuries = directTreasuries;
            portfolio.FixedIncomes = fixedIncomes;
            portfolio.Funds = funds;
            portfolio.VariableIncomes = variableIncomes;
            listInvestimentPortfolio.Add(portfolio);

            return listInvestimentPortfolio.ToList();
        }

        private async Task<IEnumerable<DirectTreasury>> GetDirectTreasury()
        {
            return await _directTreasuryService.GetAllAsync();
        }

        private async Task<IEnumerable<FixedIncome>> GetFixedIncome()
        {
            return await _fixedIncomeService.GetAsync();
        }

        private async Task<IEnumerable<VariableIncome>> GetVariableIncome()
        {
            return await _variableIncomeService.GetAsync();
        }

        private async Task<IEnumerable<Fund>> GetFund()
        {
            return await _fundService.GetAsync();
        }
    }
}





