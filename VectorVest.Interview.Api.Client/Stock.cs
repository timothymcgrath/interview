namespace VectorVest.Interview.Api.Client
{
    public class Stock
    {
        public string Symbol { get; set; }

        public decimal Price { get; set; }

        public Recommendation Recommendation { get; set; }
    }

    public enum Recommendation
    {
        Buy = 0,
        Sell = 1
    }
}
