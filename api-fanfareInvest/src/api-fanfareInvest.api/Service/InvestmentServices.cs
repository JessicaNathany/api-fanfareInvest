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
        Task<IList<InvestmentPortfolio>> IInvestmentServices.GetAll()
        {
            var listInvestimentPortfolio = new List<InvestmentPortfolio>();
            var portfolio = new InvestmentPortfolio();

            // criar métodos separados privado para trazer todos os invesitmntos separados

            return listInvestimentPortfolio;
        }
    }
}





