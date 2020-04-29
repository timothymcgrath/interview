using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using VectorVest.Interview.Api.Client;

namespace VectorVest.Interview.WpfClient
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private IEnumerable<Stock> _stocks;

        public MainWindowViewModel()
        {
            Task.Run(() => Load());
        }

        private async Task Load()
        {
            // FILL IN THIS METHOD.
            // This method should load the Stocks from the InterviewService class (proxy to the API),
            // and update the UI with the result every 5 seconds.
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public IEnumerable<Stock> Stocks
        {
            get
            {
                return _stocks;
            }
            set
            {
                _stocks = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Stocks)));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SummaryText)));
            }
        }

        public string SummaryText
        {
            get
            {
                if (Stocks == null)
                {
                    return null;
                }

                var calculator = new SummaryCalculator();
                var buys = calculator.CalculateTotalBuys(Stocks);
                var sells = calculator.CalculateTotalSells(Stocks);

                return $"{buys} Buys, {sells} sells";
            }
        }
    }
}
