using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Adventure.IdentityServer4.Services
{
    public class Config
    {
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new List<ApiResource>
            {
                new ApiResource("AdventureAPI", "Adventure API")
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>
            {
                new Client()
                {
                  ClientId = "client",
                  ClientName  ="AdventureAPI",
                  AllowedGrantTypes = GrantTypes.ClientCredentials,
                  ClientSecrets =
                    {
                        new Secret("secret".Sha256())
                    },
                  AllowedScopes  = { "AdventureAPI" }

                }
            };
        }
    }
}

