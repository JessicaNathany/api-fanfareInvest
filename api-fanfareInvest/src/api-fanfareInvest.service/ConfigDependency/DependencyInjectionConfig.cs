using api_fanfareInvest.repository.Data.Interface;
using api_fanfareInvest.repository.Data.Repository;
using api_fanfareInvest.service.IService;
using api_fanfareInvest.service.Service;
using Microsoft.Extensions.DependencyInjection;

namespace api_fanfareInvest.service.ConfigDependency
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
