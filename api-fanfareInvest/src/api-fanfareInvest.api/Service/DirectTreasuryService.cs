using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Model;
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
        
        public async Task<IEnumerable<DirectTreasury>> GetAllAsync()
        {
            var listDirectTreasury = new List<DirectTreasury>();
            var directTreasury = new DirectTreasury();

            var listDirectTreasuryResponse = await _directTreasuryRepository.GetAsync();

            if (listDirectTreasuryResponse == null) 
                return listDirectTreasury;

            foreach (var directTreasuryItem in listDirectTreasuryResponse.SelectMany(d=> d.DirectTreasurys))
            {
                listDirectTreasury.Add(new DirectTreasury
                {
                    CurrentCapital = directTreasuryItem.CurrentCapital,
                    DueDate = directTreasuryItem.DueDate,
                    FGC = directTreasuryItem.FGC,
                    InvestedCapital = directTreasuryItem.InvestedCapital,
                    Iof = directTreasuryItem.Iof,
                    IR = directTreasuryItem.IR,
                    Liquidity = directTreasuryItem.Liquidity,
                    Market = directTreasuryItem.Market,
                    OperationDate = directTreasuryItem.OperationDate,
                    OtherTaxes = directTreasuryItem.OtherTaxes,
                    Quantity = directTreasuryItem.Quantity,
                    Taxes = directTreasuryItem.Taxes,
                    UnitPrice = directTreasuryItem.UnitPrice,
                });
            }

            return listDirectTreasury;
        }
    }
}
