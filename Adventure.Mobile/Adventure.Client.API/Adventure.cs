using System.Net.Http;

namespace Adventure.Client.API
{
    public partial class Adventure
    {
        public Adventure(IHttpClientFactory httClientFactory)
        {
            this.HttpClient = httClientFactory.CreateClient("AdventureAPI");
            this.BaseUri = this.HttpClient.BaseAddress;
        }
    }
}
