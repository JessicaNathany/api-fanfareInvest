using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service;
using Moq;
using System.Collections.Generic;
using Xunit;
using FizzWare.NBuilder;
using api_fanfareInvest.api.Response;
using System.Threading.Tasks;
using api_fanfareInvest.api.Service.IService;
using System;

namespace api_fanfareInvest.test.Service
{
    public class DirectTreasuryServiceTest
    {
        private readonly IDirectTreasuryService _service;
        public DirectTreasuryServiceTest()
        {
            var mockDirectTreasury = MockDirectTresuaryRepository();

            _service = new DirectTreasuryService(mockDirectTreasury.Object);
        }

        [Fact]
        public async void Should_result_direct_treasury_not_null()
        {
            var result = await _service.GetAllAsync();
            Assert.NotNull(result);
        }

        [Fact]
        public async void Should_not_redeem_direct_treasury_for_less_than_one_month()
        {
            var result = await _service.GetAllAsync();
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

            var listDirectTreasury = new List<DirectTreasury>()
            {
                new DirectTreasury
                {
                    CurrentCapital = 1060,
                    DueDate = DateTime.Now.AddYears(5),
                    FGC = true,
                    InvestedCapital = 1047,
                    Iof = 0,
                    IR = 22,
                    Liquidity = "D+1",
                    Quantity = 30,
                    Market = "primary",
                    OperationDate = DateTime.Now,
                    UnitPrice = 31.40,
                    OtherTaxes = 0,
                    Taxes = 0,
                    Type = "IPCA + 2026"
                }
            };

            var listDirectTreasuryResponse = Builder<DirectTreasuryResponse>
                                        .CreateListOfSize(1)
                                        .All()
                                        .With(d=> d.DirectTreasurys = listDirectTreasury).Build();

            directTreasuryMock.Setup(d => d.GetAsync()).Returns(Task.FromResult(listDirectTreasuryResponse));
            return directTreasuryMock;
        }
    }
}
