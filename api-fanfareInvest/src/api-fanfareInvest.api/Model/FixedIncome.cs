namespace api_fanfareInvest.api.Model
{
    public class FixedIncome
    {
        public int InvestedCapital { get; set; }
        public decimal CurrentCapital { get; set; }
        public int Quantity { get; set; }
        public DateTime DueDate { get; set; }
        public int Iof { get; set; }
        public int OtherTaxes { get; set; }
        public int Taxes { get; set; }
        public string Index { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public bool FGC { get; set; }
        public DateTime OperationDate { get; set; }
        public decimal UnitPrice { get; set; }
        public string Market { get; set; }
    }
}

