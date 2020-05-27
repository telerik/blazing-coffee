using System.Net.Http;

namespace BlazingCoffee.Services
{
    public class PublicClient
    {
        public HttpClient Client { get; private set; }

        public PublicClient(HttpClient httpClient)
        {
            Client = httpClient;
        }
    }
}
