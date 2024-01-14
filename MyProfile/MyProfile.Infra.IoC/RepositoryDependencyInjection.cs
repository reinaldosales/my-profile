using Microsoft.Extensions.DependencyInjection;
using MyProfile.Infra.Data;
using MyProfile.Infra.Data.Interfaces;
using MyProfile.Infra.Data.Repositories;

namespace MyProfile.Infra.IoC;

public static class RepositoryDependencyInjection
{
    public static IServiceCollection AddRepositoriesDependencies(this IServiceCollection services)
    {
        services.AddTransient<IInvestmentFundRepository, InvestmentFundRepository>();
        services.AddTransient<IRealEstateFundRepository, RealEstateFundRepository>();

        return services;
    }
}
