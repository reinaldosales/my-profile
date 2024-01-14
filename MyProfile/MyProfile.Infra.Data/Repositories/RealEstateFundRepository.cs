using Dapper;
using Microsoft.Data.SqlClient;
using MyProfile.Domain.Entities;
using MyProfile.Infra.Data.Interfaces;
using MyProfile.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProfile.Infra.Data.Repositories;

public class RealEstateFundRepository : IRealEstateFundRepository
{
    public async Task Save(RealEstateFund realEstateFund)
    {
        using var connection = new SqlConnection(MyProfileSettings.GetInstance().DefaultConnectionStrings);

        var id = await connection.ExecuteScalarAsync<int>(
            sql: "INSERT INTO RealEstateFund VALUES(@stock, @name, @close, @change, @volume, @marketCapital, @logo, @sector, @updatedAt, @createdAt, null)", new
            {
                stock = realEstateFund.Stock,
                name = realEstateFund.Name,
                close = realEstateFund.Close,
                change = realEstateFund.Change,
                volume = realEstateFund.Volume,
                marketCapital = realEstateFund.MarketCapital,
                logo = realEstateFund.Logo,
                sector = realEstateFund.Sector,
                updatedAt = DateTimeOffset.Now,
                createdAt = DateTimeOffset.Now
            });
    }
}
