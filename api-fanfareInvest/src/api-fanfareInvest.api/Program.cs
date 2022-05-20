using api_fanfareInvest.api.Data.Interface;
using api_fanfareInvest.api.Data.Repository;
using api_fanfareInvest.api.IService;
using api_fanfareInvest.api.Service;
using api_fanfareInvest.api.Service.IService;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IFundService, FundService>();
builder.Services.AddScoped<IFundRepository, FundRepository>();
builder.Services.AddScoped<ITirectTreasuryService, TirectTreasuryService>();
builder.Services.AddScoped<ITirectTreasuryRepository, TirectTreasuryRepository>();

// refactor

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
