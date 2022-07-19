namespace api_fanfareInvest.api.Model
{
    public class VariableIncome
    {
        public decimal InvestedCapital { get; set; }
        public decimal CurrentCapital { get; set; }
        public int Quantity { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
