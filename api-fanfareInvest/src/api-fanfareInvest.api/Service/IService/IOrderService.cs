namespace api_fanfareInvest.api.Service.IService
{
    public interface IOrderService
    {
        Task PostTitleRedemption(int IdTitle, DateTime currentDate);
        /* Essa classe tem como responsabilidade gerenciar a ordem de serviço
         * no caso, cada titulo que for comprado ou vendido, é criado uma ordem pra isso
         * 
         * Essa ordem, precisa ser gerado um extrato e extrair o investimento da carteira
         * do cliente
         * 
         * criar o método CreatedOrder
         
         */

    }
}
