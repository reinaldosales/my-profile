
using Microsoft.Extensions.DependencyInjection;
using MyProfile.Application;
using MyProfile.Application.Interfaces;
using MyProfile.Application.Services;

namespace MyProfile.Infra.IoC;

public static class ServiceDependencyInjection
{
    public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
    {
        services.AddTransient<IInvestmentFundService, InvestmentFundService>();
        services.AddTransient<IBrApiService, BrApiService>();
        services.AddTransient<IRealEstateFundService, RealEstateFundService>();

        return services;
    }
}
