using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.IService;
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
        public async Task<IList<Fund>> Get()
        {
            var funds = new List<Fund>();
            var fund = new Fund();

            var fundRepository = _fundRepository.Get();

           return funds;
        }
    }
}
