namespace MyProfile.Domain;

public class InvestmentFund : EntityBase
{
        public InvestmentFund
        (
            int? id,
            string symbol,
            string currency,
            decimal twoHundredDayAverage,
            decimal twoHundredDayAverageChange,
            decimal twoHundredDayAverageChangePercent,
            decimal marketCap,
            string shortName,
            string longName,
            decimal regularMarketChange,
            decimal regularMarketChangePercent,
            DateTime regularMarketTime,
            decimal regularMarketPrice,
            int regularMarketDayHigh,
            string regularMarketDayRange,
            int regularMarketDayLow,
            int regularMarketVolume,
            decimal regularMarketPreviousClose,
            int regularMarketOpen,
            int averageDailyVolume3Month,
            int averageDailyVolume10Day,
            decimal fiftyTwoWeekLowChange,
            decimal fiftyTwoWeekLowChangePercent,
            string fiftyTwoWeekRange,
            decimal fiftyTwoWeekHighChange,
            decimal fiftyTwoWeekHighChangePercent,
            decimal fiftyTwoWeekLow,
            decimal fiftyTwoWeekHigh,
            decimal priceEarnings,
            decimal earningsPerShare,
            string logourl,
            DateTime updatedAt,
            DateTime createdAt,
            DateTime? deletedAt
        ) : base(id, updatedAt, deletedAt, createdAt)
        {
            Symbol = symbol;
            Currency = currency;
            TwoHundredDayAverage = twoHundredDayAverage;
            TwoHundredDayAverageChange = twoHundredDayAverageChange;
            TwoHundredDayAverageChangePercent = twoHundredDayAverageChangePercent;
            MarketCap = marketCap;
            ShortName = shortName;
            LongName = longName;
            RegularMarketChange = regularMarketChange;
            RegularMarketChangePercent = regularMarketChangePercent;
            RegularMarketTime = regularMarketTime;
            RegularMarketPrice = regularMarketPrice;
            RegularMarketDayHigh = regularMarketDayHigh;
            RegularMarketDayRange = regularMarketDayRange;
            RegularMarketDayLow = regularMarketDayLow;
            RegularMarketVolume = regularMarketVolume;
            RegularMarketPreviousClose = regularMarketPreviousClose;
            RegularMarketOpen = regularMarketOpen;
            AverageDailyVolume3Month = averageDailyVolume3Month;
            AverageDailyVolume10Day = averageDailyVolume10Day;
            FiftyTwoWeekLowChange = fiftyTwoWeekLowChange;
            FiftyTwoWeekLowChangePercent = fiftyTwoWeekLowChangePercent;
            FiftyTwoWeekRange = fiftyTwoWeekRange;
            FiftyTwoWeekHighChange = fiftyTwoWeekHighChange;
            FiftyTwoWeekHighChangePercent = fiftyTwoWeekHighChangePercent;
            FiftyTwoWeekLow = fiftyTwoWeekLow;
            FiftyTwoWeekHigh = fiftyTwoWeekHigh;
            PriceEarnings = priceEarnings;
            EarningsPerShare = earningsPerShare;
            Logourl = logourl;
            UpdatedAt = updatedAt;
        }

        public string Symbol { get; private set; }

        public string Currency { get; private set; }

        public decimal TwoHundredDayAverage { get; private set; }

        public decimal TwoHundredDayAverageChange { get; private set; }

        public decimal TwoHundredDayAverageChangePercent { get; private set; }

        public decimal MarketCap { get; private set; }

        public string ShortName { get; private set; }

        public string LongName { get; private set; }

        public decimal RegularMarketChange { get; private set; }

        public decimal RegularMarketChangePercent { get; private set; }

        public DateTime RegularMarketTime { get; private set; }

        public decimal RegularMarketPrice { get; private set; }

        public int RegularMarketDayHigh { get; private set; }

        public string RegularMarketDayRange { get; private set; }

        public int RegularMarketDayLow { get; private set; }

        public int RegularMarketVolume { get; private set; }

        public decimal RegularMarketPreviousClose { get; private set; }

        public int RegularMarketOpen { get; private set; }

        public int AverageDailyVolume3Month { get; private set; }

        public int AverageDailyVolume10Day { get; private set; }

        public decimal FiftyTwoWeekLowChange { get; private set; }

        public decimal FiftyTwoWeekLowChangePercent { get; private set; }

        public string FiftyTwoWeekRange { get; private set; }

        public decimal FiftyTwoWeekHighChange { get; private set; }

        public decimal FiftyTwoWeekHighChangePercent { get; private set; }

        public decimal FiftyTwoWeekLow { get; private set; }

        public decimal FiftyTwoWeekHigh { get; private set; }

        public decimal PriceEarnings { get; private set; }

        public decimal EarningsPerShare { get; private set; }

        public string Logourl { get; private set; }
}
