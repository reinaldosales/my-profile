using MyProfile.Domain;
using MyProfile.Infra.Data;

namespace MyProfile.Application;

public class InvestmentFundService : IInvestmentFundService
{
    private readonly IInvestmentFundRepository _investmentFundRepository;

    public InvestmentFundService(IInvestmentFundRepository investmentFundRepository)
    {
        _investmentFundRepository = investmentFundRepository;
    } 

    public async Task<InvestmentFund> GetInvestmentFundBySymbol(string symbol)
    {
        var investmentFund = await _investmentFundRepository.GetInvestmentFundBySymbol(symbol);

        return investmentFund;
    }
}
