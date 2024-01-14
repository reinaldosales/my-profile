using MyProfile.Application;
using MyProfile.Application.Interfaces;
using MyProfile.Application.Services;
using MyProfile.Domain.Entities;
using MyProfile.Shared;

namespace MyProfile.Consumer.BrApi;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;
    private readonly IBrApiService _brApiService;
    private readonly IRealEstateFundService _realEstateFundService;

    public Worker(ILogger<Worker> logger, IBrApiService brApiService, IRealEstateFundService realEstateFundService)
    {
        _logger = logger;
        _brApiService = brApiService;
        _realEstateFundService = realEstateFundService;
    }

    protected override async Task ExecuteAsync(CancellationToken cancellationToken)
    {
        try
        {
            var response = await _brApiService.GetAllFundsAsync(MyProfileSettings.GetInstance().BrApiToken, cancellationToken: cancellationToken);

            foreach (var item in response.stocks)
            {
                var realEstateFund = new RealEstateFund(null, item.stock, item.name, item.close, item.change, item.volume, item.market_cap, item.logo, item.sector, DateTime.Now, null, DateTime.Now);

                await _realEstateFundService.Save(realEstateFund);
            }
        }
        catch (Exception ex)
        {
            Environment.Exit(0);
            _logger.LogError("Erro: ", ex.Message);
        }
    }
}
