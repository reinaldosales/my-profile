using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProfile.Domain.Entities;

public class RealEstateFund : EntityBase
{
    public RealEstateFund(
        int? id,
        string stock,
        string name,
        decimal close,
        decimal change,
        decimal? volume,
        decimal? marketCapital,
        string logo,
        string sector,
        DateTime updatedAt,
        DateTime? deletedAt,
        DateTime createdAt
    ) : base(id, updatedAt, deletedAt, createdAt)
    {
        Stock = stock;
        Name = name;
        Close = close;
        Volume = volume;
        Change = change;
        MarketCapital = marketCapital;
        Logo = logo;
        Sector = sector;
    }

    public string Stock { get; private set; }
    public string Name { get; private set; }
    public decimal Close { get; private set; }
    public decimal Change { get; private set; }
    public decimal? Volume { get; private set; }
    public decimal? MarketCapital { get; private set; }
    public string Logo { get; private set; }
    public string Sector { get; private set; }
}
