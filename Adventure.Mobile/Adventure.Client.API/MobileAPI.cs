using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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
