using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
using api_fanfareInvest.api.Response;
using api_fanfareInvest.api.Service.IService;

namespace api_fanfareInvest.api.Service
{
    public class DirectTreasuryService : IDirectTreasuryService
    {
        private readonly IDirectTreasuryRepository _directTreasuryRepository;

        public DirectTreasuryService(IDirectTreasuryRepository directTreasuryRepository)
        {
            _directTreasuryRepository = directTreasuryRepository;
        }
        
        public async Task<IEnumerable<DirectTreasury>> GetAsync()
        {
            var listDirectTreasury = new List<DirectTreasury>();
            var directTreasury = new DirectTreasury();

            var listDirectTreasuryrepository = await _directTreasuryRepository.GetAsync();

            if (listDirectTreasuryrepository == null) return listDirectTreasury = null;

            return AssociateDirectTreasury(listDirectTreasury, directTreasury, listDirectTreasuryrepository);
        }

        private static IList<DirectTreasury> AssociateDirectTreasury(List<DirectTreasury>? listDirectTreasury, 
                                                                    DirectTreasury directTreasury, 
                                                                    IList<DirectTreasuryResponse> listDirectTreasuryrepository)
        {
            foreach (var directTreasuryItem in listDirectTreasuryrepository)
            {
                AssociatedDirectTreasury(listDirectTreasury, directTreasury, directTreasuryItem);
            }

            return listDirectTreasury;
        }

        private static void AssociatedDirectTreasury(List<DirectTreasury>? listDirectTreasury, DirectTreasury directTreasury, DirectTreasuryResponse directTreasuryItem)
        {
            foreach (var item in directTreasuryItem.DirectTreasurys)
            {
                directTreasury.CurrentCapital = item.CurrentCapital;
                directTreasury.DueDate = item.DueDate;
                directTreasury.FGC = item.FGC;
                directTreasury.InvestedCapital = item.InvestedCapital;
                directTreasury.Iof = item.Iof;
                directTreasury.IR = item.IR;
                directTreasury.Liquidity = item.Liquidity;
                directTreasury.Market = item.Market;
                directTreasury.OperationDate = item.OperationDate;
                directTreasury.OtherTaxes = item.OtherTaxes;
                directTreasury.Quantity = item.Quantity;
                directTreasury.Taxes = item.Taxes;
                directTreasury.UnitPrice = item.UnitPrice;

                listDirectTreasury.Add(directTreasury);
            }
        }

        public Task<OrderModel> PostAsync(int idTitle, DateTime currentDate)
        {
            throw new NotImplementedException();
        }
    }
}
