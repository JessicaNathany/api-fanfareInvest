using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Service.IService;

namespace api_fanfareInvest.api.Service
{
    public class VariableIncomeService : IVariableIncomeService
    {
        private readonly IVariableIncomeRepository _variableIncomeRepository;
        public VariableIncomeService(IVariableIncomeRepository variableIncomeRepository)
        {
            _variableIncomeRepository = variableIncomeRepository;
        }
        public async Task<IEnumerable<VariableIncome>> Get()
        {
            var variableIncomes = new List<VariableIncome>();
            var variableIncome = new VariableIncome();

            var variableIncomeResponse = await _variableIncomeRepository.Get();
            foreach (var item in variableIncomeResponse.SelectMany(s => s.VariableRent))
            {
                variableIncomes.Add(new VariableIncome
                {
                    InvestedCapital = item.InvestedCapital,
                    CurrentCapital = item.CurrentCapital,
                    Quantity = item.Quantity,
                    Name = item.Name,
                    UnitPrice = item.UnitPrice
                });
            }

            variableIncomes.Add(variableIncome);

            return variableIncomes;
        }
    }
}
