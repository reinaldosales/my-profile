using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProfile.Application.Responses;

public class Index
{
    public string stock { get; set; }
    public string name { get; set; }
}

public class BrApiFundsResponse
{
    public IEnumerable<Index> indexes { get; set; }
    public IEnumerable<Stock> stocks { get; set; }
    public IEnumerable<string> availableSectors { get; set; }
    public IEnumerable<string> availableStockTypes { get; set; }
}

public class Stock
{
    public string stock { get; set; }
    public string name { get; set; }
    public decimal close { get; set; }
    public decimal change { get; set; }
    public decimal? volume { get; set; }
    public decimal? market_cap { get; set; }
    public string logo { get; set; }
    public string sector { get; set; }
    public string type { get; set; }
}

