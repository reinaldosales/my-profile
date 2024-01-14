using MyProfile.Domain;

namespace MyProfile.Infra.Data;

public interface IInvestmentFundRepository
{
    Task<InvestmentFund> GetInvestmentFundBySymbol(string symbol);
}
