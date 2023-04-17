using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace SMSDC.Swagger.Smsdc
{
    public class SmsdcBaseClient
    {
        public string BaseUrl { get; set; }
        protected Task<HttpClient> CreateHttpClientAsync(CancellationToken cancellationToken = default)
        {
            var result = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7257/")
            };
            BaseUrl = "https://localhost:7257/";
            return Task.FromResult(result);
        }
    }
}
