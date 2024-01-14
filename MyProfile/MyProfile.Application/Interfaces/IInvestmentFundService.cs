using MyProfile.Domain;

namespace MyProfile.Application;

public interface IInvestmentFundService
{
    Task<InvestmentFund> GetInvestmentFundBySymbol(string symbol);
}
