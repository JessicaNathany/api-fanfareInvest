using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Data.Repository;
using api_fanfareInvest.api.IService;
using api_fanfareInvest.api.Service;

namespace api_fanfareInvest.api.ConfigDependency
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependecies(this IServiceCollection services)
        {
            services.AddScoped<IFundRepository, FundRepository>();
            services.AddScoped<IFundService, FundService>();

            return services;
        }
    }
}
