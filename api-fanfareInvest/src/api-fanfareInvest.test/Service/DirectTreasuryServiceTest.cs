using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service;
using Moq;
using System.Collections.Generic;
using Xunit;
using FizzWare.NBuilder;

namespace api_fanfareInvest.test.Service
{
    public class DirectTreasuryServiceTest
    {
        private readonly IDirectTreasuryRepository _directTreasuryRepository;

        public DirectTreasuryServiceTest()
        {
            var mockDirectTreasury = MockDirectTresuaryRepository();

            var service = new DirectTreasuryService(mockDirectTreasury.Object);
        }

        [Fact]
        public void Should_not_redeem_direct_treasury_for_less_than_one_month()
        {

        }

        [Fact]
        public void Should_deduct_20_percent_of_IR_of_the_yield_if_the_bonds_maturity_date_is_greater_than_6_months()
        {

        }

        [Fact]
        public void Should_deduct_10_percent_of_IR_of_the_yield_if_the_bonds_maturity_date_is_greater_than_12_months()
        {

        }

        [Fact]
        public void Should_deduct_5_percent_of_IR_of_the_yield_if_the_bonds_maturity_date_is_greater_than_12_months()
        {

        }

        private Mock<IDirectTreasuryRepository> MockDirectTresuaryRepository()
        {
            var directTreasuryMock = new Mock<IDirectTreasuryRepository>();

            var listDirectTreasury = Builder<DirectTreasury>.CreateListOfSize(1).All().Build();


            //var listDirectTreasury = new List<DirectTreasury>()
            //{

            //}


            //directTreasuryMock.Setup(d => d.GetAsync()).Returns(listDirectTreasury);

            return directTreasuryMock;
        }
    }
}
