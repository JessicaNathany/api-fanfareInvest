using System;

namespace api_fanfareInvest.api.Model
{
    public class OrderModel
    {
        public int IdOrder { get; set; }
        public DateTime OrderDateCreate { get; set; }
        public string TitleName { get; set; }

        // incluir o restante das propriedades relacioadas a ordem
        
    }
}
