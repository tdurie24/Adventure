using IdentityModel.Client;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Adventure.IdentityServerPOC
{
    class Program
    {
        public static void Main(string[] args) => MainAsync().GetAwaiter().GetResult();

        private static async Task MainAsync()
        {
            var client = new HttpClient();

            var disco = await client.GetDiscoveryDocumentAsync("https://demo.identityserver.io");

            if (disco.IsError)
                throw new Exception(disco.Error);

            // tokenClient = new TokenClient(disco.TokenEndpoint, "client", "secret");
        }
    }
}
