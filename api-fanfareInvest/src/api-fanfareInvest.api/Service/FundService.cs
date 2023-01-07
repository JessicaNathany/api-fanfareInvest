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

            var fundsRepository = await _fundRepository.GetAsync();

            if (fundsRepository == null)
                return funds; 

            foreach (var itemFund in fundsRepository.SelectMany(x => x.Funds))
            {
                funds.Add(new Fund
                {
                    Name = itemFund.Name,
                    Quantity = itemFund.Quantity,
                    UnitPrice = itemFund.UnitPrice,
                    InvestedCapital = itemFund.InvestedCapital,
                    CurrentCapital = itemFund.CurrentCapital,
                });
            }

            return funds;
        }
    }
}
