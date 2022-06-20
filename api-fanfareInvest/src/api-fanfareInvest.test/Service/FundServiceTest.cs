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

        [Fact]
        public void Get_Should_be_fund_is_null()
        {
            //var mockFund = MockFundRepository();

            //var service = new FundService(mockFund.Object);
            //var result = service.Get();

            //Assert.Null(result);
        }


        private Mock<IFundRepository> MockFundRepository()
        {

            var fundResponse = new List<FundReponse>()
            {
               
            };

            var mockFundRepository = new Mock<IFundRepository>();
            mockFundRepository.Setup(x => x.GetAsync()).ReturnsAsync(fundResponse);

           return mockFundRepository;
        }

    }
}