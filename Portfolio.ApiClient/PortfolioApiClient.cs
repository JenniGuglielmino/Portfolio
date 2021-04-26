using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Portfolio.ApiClient
{
    public static class PortfolioApiClient
    {
        public static HttpClient Get()
        {
            // var client = new HttpClient { BaseAddress = new Uri("https://apijenniferguglielmino.azurewebsites.net/api/") };
            var client = new HttpClient { BaseAddress = new Uri("https://localhost:44388/api/") };
            //client.DefaultRequestHeaders.Add("ApiKey", "Clave123");
            return client;
        }
    }
}
