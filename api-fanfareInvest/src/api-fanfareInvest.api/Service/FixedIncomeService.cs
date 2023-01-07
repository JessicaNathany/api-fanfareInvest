using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Response;
using api_fanfareInvest.api.Service.IService;

namespace api_fanfareInvest.api.Service
{
    public class FixedIncomeService : IFixedIncomeService
    {
        private readonly IFixedIncomeRepository _fixedIncomeRepository;
        public FixedIncomeService(IFixedIncomeRepository fixedIncomeRepository)
        {
            _fixedIncomeRepository = fixedIncomeRepository;
        }

        public async Task<IEnumerable<FixedIncome>> GetAsync()
        {
            var fixedIncomes = new List<FixedIncome>();

            var fixedIncomeResponses = await _fixedIncomeRepository.GetAsync();

            AssociateFixedIncomes(fixedIncomes, fixedIncomeResponses);
            return fixedIncomes;
        }

        private static void AssociateFixedIncomes(List<FixedIncome> fixedIncomes, IEnumerable<FixedIncomeResponse> fixedIncomeResponses)
        {
            foreach (var item in fixedIncomeResponses.SelectMany(s => s.FixedIncomesLCI))
            {
                fixedIncomes.Add(new FixedIncome
                {
                    InvestedCapital = item.InvestedCapital,
                    CurrentCapital = item.CurrentCapital,
                    Quantity = item.Quantity,
                    DueDate = item.DueDate,
                    Iof = item.Iof,
                    OtherTaxes = item.OtherTaxes,
                    Taxes = item.Taxes,
                    Index = item.Index,
                    Type = item.Type,
                    Name = item.Name,
                    FGC = item.FGC,
                    OperationDate = item.OperationDate,
                    UnitPrice = item.UnitPrice,
                    Market = item.Market

                });

                foreach (var item1 in fixedIncomeResponses.SelectMany(s => s.FixedIncomesCDB))
                {
                    fixedIncomes.Add(new FixedIncome
                    {
                        InvestedCapital = item1.InvestedCapital,
                        CurrentCapital = item1.CurrentCapital,
                        Quantity = item1.Quantity,
                        DueDate = item1.DueDate,
                        Iof = item1.Iof,
                        OtherTaxes = item1.OtherTaxes,
                        Taxes = item1.Taxes,
                        Index = item1.Index,
                        Type = item1.Type,
                        Name = item1.Name,
                        FGC = item1.FGC,
                        OperationDate = item1.OperationDate,
                        UnitPrice = item1.UnitPrice,
                        Market = item1.Market

                    });
                }
            }
        }
    }
}
