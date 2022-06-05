using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Service.IService;
using api_fanfareInvest.api.Model;

namespace api_fanfareInvest.api.Service
{
    public class FundService : IFundService
    {
        private readonly IFundRepository _fundRepository;
        public FundService(IFundRepository fundRepository)
        {
            _fundRepository = fundRepository;
        }
        public async Task<IEnumerable<Fund>> GetAsync()
        {
            var funds = new List<Fund>();
            var fund = new Fund();

            var fundsRepository =  await _fundRepository.GetAsync();

            if (fundsRepository == null) funds = null;

            foreach (var fundRepository in fundsRepository)
            {
                foreach (var itemFund in fundRepository.Funds)
                {
                    fund.Name = itemFund.Name;
                    fund.Quantity = itemFund.Quantity;
                    fund.UnitPrice = itemFund.UnitPrice;
                    fund.InvestedCapital = itemFund.InvestedCapital;
                    fund.CurrentCapital = itemFund.CurrentCapital;

                    funds.Add(fund);
                }
            }

           return funds;
        }
    }
}
