using System.Net.Http;
using System.Threading.Tasks;
using VectorVest.Interview.Api.Client;

namespace VectorVest.Interview.Console
{
    class Program
    {
        static async Task Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("Press <ENTER> to execute...");
                System.Console.ReadLine();

                await Execute();

                System.Console.WriteLine();
                System.Console.WriteLine();
            }
        }

        private static async Task Execute()
        {
            var service = new InterviewService(HttpClientFactory.Create());
            var stocks = await service.GetStocksAsync();

            foreach(var stock in stocks)
            {
                System.Console.WriteLine($"{stock.Symbol}: {stock.Price}");
            }

            return;
        }
    }
}
