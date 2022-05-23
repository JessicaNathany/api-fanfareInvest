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

            var variableIncomeResponse = await _variableIncomeRepository.GetAsync();

            if (variableIncomeResponse == null)
                return variableIncomes;

            foreach (var variableIncomeRepository in variableIncomeResponse)
            {
                foreach (var item in variableIncomeRepository.VariableIncomes)
                {
                    variableIncome.InvestedCapital = item.InvestedCapital;
                    variableIncome.CurrentCapital = item.CurrentCapital;
                    variableIncome.Quantity = item.Quantity;
                    variableIncome.Name = item.Name;
                    variableIncome.UnitPrice = item.UnitPrice;
                }
            }

            variableIncomes.Add(variableIncome);

            return variableIncomes;
        }
    }
}
