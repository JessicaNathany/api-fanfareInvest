namespace api_fanfareInvest.api.Model
{
    public class TirectTreasury
    {
        public double InvestedCapital { get; set; }
        public double CurrentCapital { get; set; }
        public int Quantity { get; set; }
        public DateTime DueDate { get; set; }
        public int Iof { get; set; }
        public int OtherTaxes { get; set; }
        public int Taxes { get; set; }
        public string Liquidity { get; set; }
        public string Type { get; set; }
        public bool FGC { get; set; }
        public DateTime OperationDate { get; set; }
        public double UnitPrice { get; set; }
        public string Market { get; set; }
        public int IR { get; set; }
    }
}
