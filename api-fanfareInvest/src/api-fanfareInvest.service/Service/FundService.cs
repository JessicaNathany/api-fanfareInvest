using api_fanfareInvest.api.Model;
using api_fanfareInvest.repository.Data.Interface;
using api_fanfareInvest.service.IService;

namespace api_fanfareInvest.service.Service
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
