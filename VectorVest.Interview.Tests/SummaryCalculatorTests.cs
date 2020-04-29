using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VectorVest.Interview.Api.Client;
using VectorVest.Interview.WpfClient;

namespace VectorVest.Interview.Tests
{
    [TestClass]
    public class SummaryCalculatorTests
    {
        [TestMethod]
        public void CalculateTotalBuys_3Buys1Sell_Returns3()
        {
            var stocks = new List<Stock>
            {
                new Stock{ Recommendation = Recommendation.Buy },
                new Stock{ Recommendation = Recommendation.Sell },
                new Stock{ Recommendation = Recommendation.Buy },
                new Stock{ Recommendation = Recommendation.Buy },
            };

            var target = new SummaryCalculator();
            var actual = target.CalculateTotalBuys(stocks);
            var expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CalculateTotalSells_3Buys1Sell_Returns1()
        {
            var stocks = new List<Stock>
            {
                new Stock{ Recommendation = Recommendation.Buy },
                new Stock{ Recommendation = Recommendation.Sell },
                new Stock{ Recommendation = Recommendation.Buy },
                new Stock{ Recommendation = Recommendation.Buy },
            };

            var target = new SummaryCalculator();
            var actual = target.CalculateTotalSells(stocks);
            var expected = 1;

            Assert.AreEqual(expected, actual);
        }
    }
}
