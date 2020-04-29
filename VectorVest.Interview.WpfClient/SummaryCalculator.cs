using System.Collections.Generic;
using System.Linq;
using VectorVest.Interview.Api.Client;

namespace VectorVest.Interview.WpfClient
{
    public class SummaryCalculator
    {
        public int CalculateTotalBuys(IEnumerable<Stock> stocks)
        {
            return stocks.Where(x => x.Recommendation == Recommendation.Buy).Count();
        }

        public int CalculateTotalSells(IEnumerable<Stock> stocks)
        {
            return stocks.Where(x => x.Recommendation == Recommendation.Buy).Count();
        }
    }
}
