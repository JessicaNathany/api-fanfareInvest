using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Service;
using api_fanfareInvest.api.Service.IService;
using Moq;
using Xunit;
using FizzWare.NBuilder;
using api_fanfareInvest.repository.Response;
using api_fanfareInvest.api.Model;
using System.Collections.Generic;

namespace api_fanfareInvest.test
{
    public class FundServiceTest
    {
        public FundServiceTest()
        {
            var mockFund = MockFundRepository();

            var fundService = new FundService(mockFund.Object);

        }

        [Fact]
        public void Get_Should_be_fund_is_null()
        {
            
        }


        private Mock<IFundRepository> MockFundRepository()
        {

            var fundResponse = new List<FundReponse>()
            {
               
            };

            var mockFundRepository = new Mock<IFundRepository>();
            mockFundRepository.Setup(x => x.GetAsync());

           return mockFundRepository;
        }

    }
}