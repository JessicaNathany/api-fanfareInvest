using api_fanfareInvest.api.Entity.Enum;

namespace api_fanfareInvest.api.Entity
{
    public class Order
    {
        public int IdOrder { get; set; }
        public string InvestmentName { get; set; }
        public string OrderTitle { get; set; }
        public DateTime OrderDateCreate { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
