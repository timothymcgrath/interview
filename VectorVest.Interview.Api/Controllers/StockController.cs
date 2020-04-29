using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using VectorVest.Interview.Api.Client;

namespace VectorVest.Interview.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockController : ControllerBase
    {
        private static int _requestCount;
        
        public StockController()
        { }

        [HttpGet]
        public async Task<IEnumerable<Stock>> Get()
        {
            var stocks = new List<Stock>
            {
                new Stock { Symbol = "MSFT", Price = 100 + _requestCount, Recommendation = Recommendation.Buy},
                new Stock { Symbol = "AAPL", Price = 20 + _requestCount, Recommendation = Recommendation.Sell},
                new Stock { Symbol = "FB", Price = 200 + _requestCount, Recommendation = Recommendation.Buy},
                new Stock { Symbol = "GOOG", Price = 35 + _requestCount, Recommendation = Recommendation.Sell},
                new Stock { Symbol = "IBM", Price = 18 + _requestCount, Recommendation = Recommendation.Buy},
                new Stock { Symbol = "NFLX", Price = 70 + _requestCount, Recommendation = Recommendation.Buy},
            };

            _requestCount++;

            return stocks;
        }
    }
}
