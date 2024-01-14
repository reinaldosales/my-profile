using Dapper;
using Microsoft.Data.SqlClient;
using MyProfile.Domain;
using MyProfile.Shared;

namespace MyProfile.Infra.Data.Repositories;

public class InvestmentFundRepository : IInvestmentFundRepository
{
    public async Task<InvestmentFund> GetInvestmentFundBySymbol(string symbol)
    {
        try
        {
            using var connection = new SqlConnection(MyProfileSettings.GetInstance().DefaultConnectionStrings);
        
            var investmentFund = await connection.QueryFirstOrDefaultAsync<InvestmentFund>("SELECT * FROM InvestmentFund WHERE Symbol = @symbol", new { symbol = symbol });

            return investmentFund;
        }
        catch (Exception ex)
        {
            throw;
        }
    }
}
