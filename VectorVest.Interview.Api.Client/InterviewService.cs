using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace VectorVest.Interview.Api.Client
{
    public class InterviewService
    {
        private static Uri _baseUrl = new Uri("http://localhost:51715/");
        private static string _stockPath = "stock";

        private readonly HttpClient _httpClient;

        public InterviewService(HttpClient httpClient)
        {
            _httpClient = httpClient;

            if (_httpClient.BaseAddress == null)
            {
                _httpClient.BaseAddress = _baseUrl;
            }
        }

        public async Task<IEnumerable<Stock>> GetStocksAsync()
        {
            var response = await _httpClient.GetStringAsync(_stockPath);
            return JsonConvert.DeserializeObject<IEnumerable<Stock>>(response);
        }
    }
}
