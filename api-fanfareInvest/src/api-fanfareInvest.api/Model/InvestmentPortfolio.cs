namespace api_fanfareInvest.api.Model
{
    public class InvestmentPortfolio
    {
        public int Id { get; set; }
        public List<FixedIncome> FixedIncomes { get; set;}
        public List<Fund> Funds { get; set; }
        public List<DirectTreasury> DirectTreasuries { get; set; }
        public List<VariableIncome> VariableIncomes { get; set; }
    }
}
