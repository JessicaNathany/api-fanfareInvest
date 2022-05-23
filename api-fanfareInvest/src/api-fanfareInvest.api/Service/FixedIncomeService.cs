using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
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
        public async Task<IEnumerable<FixedIncome>> Get()
        {
            var fixedIncomes = new List<FixedIncome>();
            var fixedIncome = new FixedIncome();

            var fixedIncomeResponse = await _fixedIncomeRepository.Get();

            foreach (var fixedIncomeRepository in fixedIncomeResponse)
            {
                foreach (var item in fixedIncomeRepository.FixedIncomes)
                {
                    fixedIncome.InvestedCapital = item.InvestedCapital;
                    fixedIncome.CurrentCapital = item.CurrentCapital;
                    fixedIncome.Quantity = item.Quantity;
                    fixedIncome.DueDate = item.DueDate;
                    fixedIncome.Iof = item.Iof;
                    fixedIncome.OtherTaxes = item.OtherTaxes;
                    fixedIncome.Taxes = item.Taxes;
                    fixedIncome.Index = item.Index;
                    fixedIncome.Type = item.Type;
                    fixedIncome.Name = item.Name;
                    fixedIncome.FGC = item.FGC;
                    fixedIncome.OperationDate = item.OperationDate;
                    fixedIncome.UnitPrice = item.UnitPrice;
                    fixedIncome.Market = item.Market;
                }
            }

            fixedIncomes.Add(fixedIncome);

            return fixedIncomes;
        }
    }
}
