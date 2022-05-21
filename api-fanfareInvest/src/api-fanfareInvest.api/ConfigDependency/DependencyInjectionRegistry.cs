using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Data.Repository;
using api_fanfareInvest.api.IService;
using api_fanfareInvest.api.Service;
using api_fanfareInvest.api.Service.IService;

namespace api_fanfareInvest.api.ConfigDependency
{
    public static class DependencyInjectionRegistry
    {
        public static void ResolveDependencies(this IServiceCollection service)
        {
            service.AddScoped<IFundService, FundService>();
            service.AddScoped<IFundRepository, FundRepository>();
            service.AddScoped<ITirectTreasuryService, TirectTreasuryService>();
            service.AddScoped<ITirectTreasuryRepository, TirectTreasuryRepository>();
        }
    }
}
