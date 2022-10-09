namespace api_fanfareInvest.api.Entity
{
    public class Order
    {
        public int IdOrder { get; set; }
        public DateTime OrderDateCreate { get; set; }
        public string TitleName { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
    }
}
