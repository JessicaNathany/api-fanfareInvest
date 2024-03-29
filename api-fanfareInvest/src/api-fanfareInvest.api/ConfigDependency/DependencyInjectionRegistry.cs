﻿using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Data.Repository;
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
            service.AddScoped<IDirectTreasuryService, DirectTreasuryService>();
            service.AddScoped<IInvestmentServices, InvestmentServices>();
            service.AddScoped<IDirectTreasuryRepository, DirectTreasuryRepository>();
            service.AddScoped<IFixedIncomeRepository, FixedIncomeRepository>();
            service.AddScoped<IVariableIncomeService, VariableIncomeService>();
            service.AddScoped<IFixedIncomeService, FixedIncomeService>();
            service.AddScoped<IVariableIncomeRepository, VariableIncomeRepository>();
            service.AddScoped<IVariableIncomeRepository, VariableIncomeRepository>();
            service.AddScoped<IOrderService, OrderService>();
            service.AddScoped<IOrderRepository, OrderRepository>();
        }
    }
}
